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
        public Deportistas Dportistas
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

        /// <summary>
        /// Settea la configuracion inicial a mostrar en el formulario de los TextBox, Label, ComboBox, Button.
        /// </summary>
        private void SetValuesControls()
        {

            lbDateTime.Text = DateTime.Now.Date.ToShortDateString();
            lbDateTime.ForeColor = Color.Green;
            lbUser.Text = NickName;
            cmbDeporte.DataSource = Enum.GetValues(typeof(EDeporte));
            cmbDeporte.SelectedIndex = -1;
            btnAgregar.Visible = true;
            btnAgregar.Enabled = false;
        }

        private void SetPaths()
        {
            Paths.SetDeportistaPath(NickName);
            Paths.SetFutbolStatsPath(NickName);
        }
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            SetPaths();
            SetValuesControls();

            Dportistas.FutbolistasArchiveTooList(Paths.DeportistasPath, Dportistas);
            Paths.AddStatsToList(Dportistas.Atletas);


           //Cargo los deportistas [Nombre - Deporte] en el visor.
            MessageAndVisorRefresh();
        }

        private void MessageAndVisorRefresh()
        {
            if (Dportistas.Atletas.Count == 0)
                lbVisorCargado.Text = "No Hay Deportistas Cargados Aun";
            else
            {
                lbVisorCargado.ForeColor = Color.Green;
                lbVisorCargado.Text = $"Deportistas Cargados : {Dportistas.Atletas.Count}";
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

        public  virtual void btnAgregar_Click(object sender, EventArgs e)
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
                    frm.D = this.Dportistas;
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
           
            if(Dportistas.Atletas.Count > 0)
            {
                StringBuilder sb = new();
                foreach (Deportista value in Dportistas.Atletas)
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
        protected virtual void btnVer_Click(object sender, EventArgs e)
        {
            // Verifica que haya al menos un ítem seleccionado
            if (lvVisor.SelectedIndices.Count > 0)
            {
                // Obtén el índice del elemento seleccionado
                int i = lvVisor.SelectedIndices[0];

                // Mostrar información de depuración
               // MessageBox.Show($"Índice seleccionado: {i}, Total de atletas: {D.Atletas.Count}");

                // Verificar que el índice esté dentro de un rango válido
                if (i >= 0 && i < Dportistas.Atletas.Count)
                {
                    // Obtener el atleta correspondiente al índice

                    Deportista atleta = Dportistas.Atletas[i];  // Aquí accedemos directamente a D.Atletas[i]
                    // Crear y mostrar el formulario de estadísticas
                    // Verificar si el atleta es null
                    if (atleta != null)
                    {
                        // MessageBox.Show($"{atleta.ToString()}");
                        FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
                       
                        frmEstadisticas.InicializarAttributos(NickName, Dportistas, atleta);
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
