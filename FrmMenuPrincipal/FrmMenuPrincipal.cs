using Entities;
using Service;

using System.Text;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace FrmMenuPrincipal
{
    public partial class frmMenuPrincipal : Form
    {

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
                StringBuilder sb = new();
                int i = 1;
                foreach (Deportista value in D.Atletas)
                {
                    sb.AppendLine($"{i++}. {value.FullName} - {value.Deporte}");
                }

                lvTexto.Items.Add(sb.ToString());
            }
            else
                lvTexto.Items.Add("No Hay Deportistas Cargados");
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
    }
}
