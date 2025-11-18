using Entities;
using Service;
using System.Text;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;



namespace PlayerStats
{
    public partial class frmMenuPrincipal : Form
    {
        /*
         Configurar click de botones, Agregar,
        Estadisticas(Mismo formulario para agregar estadisticas, no deportistas),
        Eliminar, Modificar.

        Luego de agregar deportistas, chequear el mostrado del visor.
         */
        //private Deportista _deportista;
        public User UserLogueado
        {
            get;
            set;
        }
        public Deportistas D
        {
            get;
            set;
        }


        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            D = new();
            lbDateTime.Text = DateTime.Now.Date.ToShortDateString();
            lbDateTime.ForeColor = Color.Green;
            lbUser.Text = UserLogueado.NickName;
            cmbDeporte.DataSource = Enum.GetValues(typeof(EDeporte));
            cmbDeporte.SelectedIndex = -1;
            btnAgregar.Enabled = false;


            D.PathD = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Logs", "Users",UserLogueado.NickName , "Deportistas", "Deportistas.json");
            D.TraerDeportistasDelArchivo(D.PathD, D);

            //Cargo los deportistas [Nombre - Deporte] en el visor.
            if (D.Atletas.Count == 0)
                lvVisor.Items.Add("Aun No Hay Deportistas Cargados..");
            else
                ActualizarVisor(); 

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

        private void btnAgregar_Click(object sender, EventArgs e)
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
                    frm.D = this.D;
                    frm.UserLogueado = this.UserLogueado;
                    this.Hide();
                    frm.ShowDialog();
                    frm.Close();
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
            if(D.Atletas.Count > 0)
            {
                StringBuilder sb = new();
                foreach (Deportista value in D.Atletas)
                {
                    //if (value is not null)
                    string fechaRegistro = !string.IsNullOrEmpty(value.FechaDeRegistro)
               ? value.FechaDeRegistro
               : "Fecha no disponible";

                    lvVisor.Items.Add($"{value.FullName} - {value.Deporte} | Registro {fechaRegistro} - Debut {value.FechaDebut}");
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
            if(D.Atletas.Count > 0)
            {
                FrmVerEstadisticas frmEstadisticas = new();
                int i = lvVisor.SelectedIndices[0]; //devuelve los indices seleccionados, al estar multiselect en false, solo se selecciona un item por eso el index 0.
                Deportista atleta = D.Atletas[i];
                frmEstadisticas.Atleta = atleta;

            }
        }
    }
}
