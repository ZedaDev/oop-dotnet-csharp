using Entities;
using Service;
using System.Text;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;



namespace PlayerStats
{
    public partial class frmMenuPrincipal : Form
    {
        private string _nickName;
        private Deportistas _d;
        public string NickName
        {
            get => _nickName;
            set
            {
                if (value is not null)
                    _nickName = value;
            }
        }
        public Deportistas deportistas
        {
            get => _d;
            set
            {
                _d = new();
                if(value is not null)
                    _d = value;
            }
        }
       

        public frmMenuPrincipal()
        {
            InitializeComponent();
          
        }

        /*public void InitialiteAttributes(Deportistas d, User usuario)
        {
            _d = d;
            _userLogueado = usuario;
        }*/


        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

                lbDateTime.Text = DateTime.Now.Date.ToShortDateString();
                lbDateTime.ForeColor = Color.Green;
                lbUser.Text = NickName;
                cmbDeporte.DataSource = Enum.GetValues(typeof(EDeporte));
                cmbDeporte.SelectedIndex = -1;
                btnAgregar.Enabled = false;
                    


               
            deportistas.PathD = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Logs", "Users",NickName , "Deportistas", "Deportistas.json");
            MessageBox.Show($"{deportistas.PathD}");
            deportistas.TraerDeportistasDelArchivo(deportistas.PathD, deportistas);
            //List<EFutbolista> stats = new();
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Logs", "Users", NickName, "Deportistas", "Futbol.json");
            if (File.Exists(path))
            {
                foreach (Deportista value in deportistas.Atletas)
                {

                    List<EFutbolista> stats = new();
                    deportistas.TraerEstadisticasDelArchivo(value.MisEstadisticas(NickName), stats);
                    if(stats.Count > 0)
                    {
                        value.Estadisticas.AddRange(stats);
                    }

                }
            }

            //Cargo los deportistas [Nombre - Deporte] en el visor.
            if (deportistas.Atletas.Count == 0)
                lbVisorCargado.Text = "No Hay Deportistas Cargados Aun";
            else
            {
                lbVisorCargado.ForeColor = Color.Green;
                lbVisorCargado.Text = $"Deportistas Cargados : {deportistas.Atletas.Count}";
                ActualizarVisor(); 
            }

            }

        

       
        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //D.CargarDeportistaAlArchivo(D.PathD, D.Atletas);
        }

       
        private void cmbDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeporte.SelectedIndex != -1)
                btnAgregar.Enabled = true;
            else
                btnAgregar.Enabled = false;
        }

        protected virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ComprobarCamposNull())
            {

                //Abrir FrmCargarDeportista, heredando segun el deportista seleccionado.
                FrmCargarDeportista frm = new();
                //if (cmbDeporte.SelectedIndex.ToString() == EDeporte.Futbol.ToString())
                frm = new FrmCargarFutbolista();
                /*else if(cmbDeporte.SelectedIndex.ToString() == EDeporte.Boxeo.ToString())
                         frm = new FrmCargarFutbolista ();
                else if(cmbDeporte.SelectedIndex.ToString() == EDeporte.Tenis.ToString())
                         frm = new FrmCargarFutbolista ();*/
                if (frm != null)
                {
                    frm.D = this.deportistas;
                    frm.NickName = this.NickName;
                    this.Hide();
                    frm.ShowDialog();
                    //frm.Close();
                    this.Show();
                    ActualizarVisor();
                }
            }
            else
                MessageBox.Show("Asegurese de completar todos los campos", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        protected virtual void ActualizarVisor()
        {
            lvVisor.Clear();
            lvVisor.Items.Clear();
           
            if(deportistas.Atletas.Count > 0)
            {
                StringBuilder sb = new();
                foreach (Deportista value in deportistas.Atletas)
                {
                      lvVisor.Items.Add($"{value.FullName} - {value.Deporte} | Registrado {value.FechaDeRegistro}");
                }

            }
        }
        protected bool ComprobarCamposNull()
        {
            foreach (Control value in this.Controls)
            {
                if (value is TextBox txt && string.IsNullOrEmpty(txt.Text.Trim()))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnVer_Click(object sender, EventArgs e)
        {
            // Verifica que haya al menos un ítem seleccionado
            if (lvVisor.SelectedIndices.Count > 0)
            {
                // Obtén el índice del elemento seleccionado
                int i = lvVisor.SelectedIndices[0];

                // Mostrar información de depuración
               // MessageBox.Show($"Índice seleccionado: {i}, Total de atletas: {D.Atletas.Count}");

                // Verificar que el índice esté dentro de un rango válido
                if (i >= 0 && i < deportistas.Atletas.Count)
                {
                    // Obtener el atleta correspondiente al índice

                    Deportista atleta = deportistas.Atletas[i];  // Aquí accedemos directamente a D.Atletas[i]
                    // Crear y mostrar el formulario de estadísticas
                    // Verificar si el atleta es null
                    if (atleta != null)
                    {
                        // MessageBox.Show($"{atleta.ToString()}");
                        FrmVerEstadisticas frmEstadisticas = new FrmVerEstadisticas();
                       
                        frmEstadisticas.InicializarAttributos(NickName, deportistas, atleta);
                        this.Hide();
                        frmEstadisticas.ShowDialog();

                        cmbDeporte.SelectedIndex = -1;
                        ActualizarVisor();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("El atleta seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
                else
                {
                    // Si el índice está fuera del rango de la lista
                    MessageBox.Show($"Índice seleccionado fuera del rango: {i}", "Error de índice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si no se ha seleccionado ningún elemento
                MessageBox.Show("Asegúrese de seleccionar un deportista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
