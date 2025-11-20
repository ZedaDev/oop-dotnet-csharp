using System.Text.Json;
using Entities;
using Service;

namespace PlayerStats
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            string nick = txtNickName.Text;
            string pw = txtPw.Text;
            User usuarioNuevo = new(nick, pw);

            if (string.IsNullOrEmpty(nick) || string.IsNullOrEmpty(pw))
                lbMessage.Text = "Asegurese De Completar Los Campos";
            else
            {
                if (Usuarios.UsersList.Count == 0)
                    lbMessage.Text = "Usuario No Registrado";
                    //Usuarios.SetUser = usuarioNuevo;

                if (Usuarios.UsersList.Count > 0 && !(Usuarios.UsersList.Contains(usuarioNuevo)))
                {
                    lbMessage.Text = "El Nombre De Usuario No Existe";
                    lbMessage.ForeColor = Color.Red;

                    txtNickName.Clear(); txtNickName.Focus();
                }
                else
                {
                    Deportistas d = new();
                    frmMenuPrincipal menu = new();
                    menu.InitialiteAttributes(d, usuarioNuevo);

                    this.Hide(); //oculta el formulario
                    DialogResult result = menu.ShowDialog();
                    if(result == DialogResult.OK)
                    {
                        this.txtNickName.Clear();
                        this.txtPw.Clear();
                        this.Show();
                    }
                    else
                        this.Close();
                }
            }


        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Ruta del archivo JSON
            string pathJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Logs", "Usuarios.json");

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

                    // Deserializamos la lista de usuarios
                    Usuarios.UsersList = JsonSerializer.Deserialize<List<User>>(textArchive, options);
                }
            }
        }


        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked)
                txtPw.PasswordChar = '\0';
            else
                txtPw.PasswordChar = '*';
        }
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            lbMessage.ResetText();
            string nick = txtNickName.Text;
            string pw = txtPw.Text;
            User usuarioNuevo = new(nick, pw);
            List<User> listaUsuarios = Usuarios.UsersList;

            if (string.IsNullOrEmpty(nick) || string.IsNullOrEmpty(pw))
            {
                lbMessage.Text = "Asegurese De Completar Los Campos";
            }
            else
            {
                bool usuarioExistente = false;

                // foreach para comprobar si el usuario ya existe en la lista
                foreach (User value in listaUsuarios)
                {
                    if (value == usuarioNuevo) // Compara el NickName
                    {
                        usuarioExistente = true;
                        break;
                    }
                }

                if (usuarioExistente)
                {
                    lbMessage.Text = "El Nombre De Usuario Ya Existe, Intente Otro";
                    lbMessage.ForeColor = Color.Red;
                }
                else
                {
                    // Si el usuario no existe, lo agregamos a la lista
                    listaUsuarios.Add(usuarioNuevo);

                    // Guardamos la lista actualizada en el archivo JSON
                    GuardarUsuariosEnArchivo("Logs","Usuarios.json");

                    MessageBox.Show("Registro Exitoso", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    txtNickName.Clear();
                    txtPw.Clear();
            }
        }
        private void GuardarUsuariosEnArchivo(string carpeta, string archivo)
        {
            // Ruta del archivo JSON donde guardaremos los usuarios
            string pathJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), carpeta, archivo);

            // Crear directorio si no existe
            string dir = Path.GetDirectoryName(pathJson);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // Configurar opciones para serialización
            JsonSerializerOptions jsonObject = new JsonSerializerOptions
            {
                WriteIndented = true,   // Formato legible (con indentación)
                IncludeFields = true    // Incluir campos privados
            };

            // Serializar la lista de usuarios
            string jsonUsuarios = JsonSerializer.Serialize(Usuarios.UsersList, jsonObject);

            // Sobrescribir el archivo JSON con la lista actualizada
            File.WriteAllText(pathJson, jsonUsuarios);
        }
    }

}
