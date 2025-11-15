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
            UserLogueado = new();
           
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.Date.ToShortDateString();
            lbDateTime.ForeColor = Color.Green;
            lbUser.Text = UserLogueado.NickName;

            cmbDeporte.DataSource = Enum.GetValues(typeof(EDeporte));
            cmbDeporte.SelectedIndex = -1;
            btnAgregar.Enabled = false;

            D = new();



            //Cargo la lista de deportistas desde Json
            // Ruta del archivo JSON
            string pathJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "LOGS", UserLogueado.NickName, "Deportistas.json");

            // Crear directorio si no existe
            string dir = Path.GetDirectoryName(pathJson);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // Si el archivo existe, deserializamos los usuarios
            if (File.Exists(pathJson))
            {
                using (StreamReader archivo = new(pathJson))
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        IncludeFields = true, // Incluir campos privados durante la deserialización
                    };

                    string textArchive = archivo.ReadToEnd();

                    if (!string.IsNullOrEmpty(textArchive.Trim()))
                        D.Atletas = JsonSerializer.Deserialize<List<Deportista>>(textArchive, options);
                    // Deserializamos la lista de usuarios
                }
            }

            //Cargo los deportistas [Nombre - Deporte] en el visor.
            if (D.Atletas.Count > 0)
            {
                ActualizarVisor();
            }
            else
                lvVisor.Items.Add("Aun No Hay Deportistas Cargados..");

        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ruta del archivo JSON donde guardaremos los usuarios
            string pathJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "LOGS", UserLogueado.NickName, "Deportistas.Json");


            // Configurar opciones para serialización
            JsonSerializerOptions jsonObject = new JsonSerializerOptions
            {
                WriteIndented = true,   // Formato legible (con indentación)
                IncludeFields = true    // Incluir campos privados
            };

            // Serializar la lista de usuarios
            string jsonDeportistas = JsonSerializer.Serialize(D.Atletas, jsonObject);

            // Sobrescribir el archivo JSON con la lista actualizada
            File.WriteAllText(pathJson, jsonDeportistas);
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
                    this.Show();
                    ActualizarVisor();
                }
            }
            else
                MessageBox.Show("Asegurese de completar todos los campos", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ActualizarVisor()
        {
            lvVisor.Clear();
            StringBuilder sb = new();
            foreach (Deportista value in D.Atletas)
            {
                if (value != null)
                    lvVisor.Items.Add($"{value.FullName} - {value.Deporte} | DATE  {value.FechaDeRegistro}");
            }
        }
        private bool ComprobarCamposNull()
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

        }
    }
}
