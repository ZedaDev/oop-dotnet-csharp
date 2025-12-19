using Entities;
using Service;
using System.Text;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;



namespace PlayerStats
{
    public partial class frmMenuPrincipal : Form
    {

        public frmMenuPrincipal()
        {
            InitializeComponent();

        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            GenerarRutasDeArchivos();
            SetValuesControls();

            Deportistas.Atletas = Serializer<Deportista>.JsonDeserializeList(Paths.DeportistasPath);

            //Cargo los deportistas [Nombre - Deporte] en el visor.
            MessageAndVisorRefresh();
        }

        private void MessageAndVisorRefresh()
        {
            if (Deportistas.Atletas.Count == 0)
                lbVisorCargado.Text = "No Hay Deportistas Cargados Aun";
            else
            {
                lbVisorCargado.ForeColor = Color.Green;
                lbVisorCargado.Text = $"Deportistas Cargados : {Deportistas.Atletas.Count}";
                ActualizarVisor();
            }
        }


  


        private void cmbDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeporte.SelectedIndex != -1)
                btnAgregar.Enabled = true;
            else
                btnAgregar.Enabled = false;
        }

        public virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ComprobarCamposNull())
            {

                //Abrir FrmCargarDeportista, heredando segun el deportista seleccionado.
                FrmCargarDeportista frm = new();
                //if (cmbDeporte.SelectedIndex.ToString() == EDeporte.Futbol.ToString())
                    frm = new FrmCargarFutbolista();
                /*else if(cmbDeporte.SelectedIndex.ToString() == EDeporte.Boxeo.ToString())
                         //frm = new FrmCargarFutbolista ();
                else if(cmbDeporte.SelectedIndex.ToString() == EDeporte.Tenis.ToString())
                         //frm = new FrmCargarFutbolista ();*/

                  
                    this.Hide();
                    frm.ShowDialog();

                    this.Show();
                    MessageAndVisorRefresh();
                    //ActualizarVisor();
                
            }
            else
                MessageBox.Show("Asegurese de completar todos los campos", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        protected virtual void ActualizarVisor()
        {
            lvVisor.Clear();
            lvVisor.Items.Clear();

            if (Deportistas.Atletas.Count > 0)
            {
    
                StringBuilder sb = new();
                foreach (Deportista value in Deportistas.Atletas)
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
        protected bool ComprobarCamposNull<T, U>(List<T> list, U date) where U : TextBox
        {
            foreach (var value in this.Controls)
            {
                if (value is U txt && string.IsNullOrEmpty(txt.Text.Trim()))
                {
                    txt.Tag = "empty";
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

                
                // Verificar que el índice esté dentro de un rango válido
                if (i >= 0 && i < Deportistas.Atletas.Count)
                {
                    ;
                    // Verificar si el atleta es null
                    if (Deportistas.Atletas[i] != null)
                    {
                        Deportistas.MyAtleta = Deportistas.Atletas[i]; 
                        Deportistas.INDEX = i;
                        FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
                      
                        this.Hide();
                        frmEstadisticas.ShowDialog();

                        cmbDeporte.SelectedIndex = -1;
                        MessageAndVisorRefresh();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Asegúrese de seleccionar un deportista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        protected virtual void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lvVisor.SelectedIndices.Count > 0)
            {
                // Obtén el índice del elemento seleccionado
                int i = lvVisor.SelectedIndices[0];

                if (i >= 0 && i < Deportistas.Atletas.Count)
                {
                    Deportistas.MyAtleta = Deportistas.Atletas[i]; 
                    DialogResult res = MessageBox.Show($"Seguro Desea Eliminar Este Deportista?\n {Deportistas.MyAtleta.ToString()}", "Question",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if(res == DialogResult.Yes)
                    {
                        Deportistas.BorrarAtleta = Deportistas.MyAtleta;
                        MessageAndVisorRefresh();
                        Serializer<Deportista>.JsonSerializerList(Deportistas.Atletas, Paths.DeportistasPath);

                        MessageBox.Show($"Deportista Eliminado Con Exito", "Deportista Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }else
                MessageBox.Show($"Seleccione Un Deportista", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        /// <summary>
        // Settea la configuracion inicial a mostrar en el formulario de los TextBox, Label, ComboBox, Button.
        /// </summary>
        private void SetValuesControls()
        {

            lbDateTime.Text = DateTime.Now.Date.ToShortDateString();
            lbDateTime.ForeColor = Color.Green;
            lbUser.Text = Usuarios.MyUser.NickName;
            cmbDeporte.DataSource = Enum.GetValues(typeof(EDeporte));
            cmbDeporte.SelectedIndex = -1;
            btnAgregar.Visible = true;
            btnAgregar.Enabled = false;
        }


        /// <summary>
        /// Invoca a la clase estatica 'Paths', generando automaticamente la ruta en donde se guardan los Deportistas del Usuario.
        /// </summary>
        private void GenerarRutasDeArchivos()
        {
            Paths.SetDeportistaPath();
        }
    }
}
