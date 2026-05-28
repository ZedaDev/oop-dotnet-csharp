using Entities;
using Service;

namespace PlayerStats
{
    public partial class FrmLogin : Form
    {
        AccesoDatos _accesoDatos;
        Task TLoguearse;
        Action<User> SettNameUserPath = (usuario) =>
        {
            Paths.NickName = usuario.NickName;
            Usuarios.MyUser = usuario;
        };
        public AccesoDatos DataAccess { get => _accesoDatos;}

        public FrmLogin()
        {
            InitializeComponent();
        }




        private void InicializarFormularioMenu()
        {

            frmMenuPrincipal menu = new();

            this.Hide(); //oculta el formulario
            menu.ShowDialog();
            this.Close();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            _accesoDatos = new();
            DataAccess.ProbarConexion(); //BDD
            Usuarios.UsersList = Serializer<User>.JsonDeserializeList(Paths.LoginPath); //Json
        }


        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked)
                txtPw.PasswordChar = '\0';
            else
                txtPw.PasswordChar = '*';
        }
        private User ValidarUsuario(string name, string pw)
        {
            if (Helper.CheckText(name, pw))
            {
                return new User(name, pw);
            }
            else
                lbMessage.Text = "Asegurese De Completar Los Campos";
                lbMessage.ForeColor = Color.Red;

            return null;

        }

        /// <summary>
        /// Colorea el label mensaje en rojo y, cambia su texto a "El Nombre De Usuario Ya Existe, Intente Otro".
        /// </summary>
        private void MessageSetAndColor(string message)
        {
            lbMessage.Text = $"{message}";
            lbMessage.ForeColor = Color.Red;
        }
        private bool VerificarUsuarioExistenteJson(User us)
        {
            if (us is not null)
            {
                if (Usuarios.VerificarUsuariosRegistrado(us))
                {
                    return true;
                }
            }else
                MessageSetAndColor("El Nombre De Usuario no existe");

                return false;
        }
        private bool VerifyUserBDD(User us)
        {
            if (us is not null)
            {
                User newUser = DataAccess.Login(txtNickName.Text);

               
                if (newUser.Id != -1)
                {
                    
                        return true;
                }

            }
                return false;
        }
        private User VerificarUsuarioExistenteBDD(User us)
        {
            if (us is not null)
            {
                User newUser = DataAccess.Login(txtNickName.Text);
                if (newUser.Id != -1)
                {
                        return newUser;
                }

            }
                return null;
        }
        private void ProcesarUsuario(User usuario, bool esRegistro)
        {
                Verificar v = new();
            if (esRegistro)//Si es el metodo Registrarse
            {
               var VerificarUsuarioBDD = v.VerificarExistente<User>(3,VerifyUserBDD);
              
                if (!VerificarUsuarioExistenteJson(usuario) && !VerificarUsuarioBDD(usuario))//!VerifyUserBDD(usuario)
                {
                    usuario.FechaRegistro = DateTime.Now;
                    DataAccess.InsertarUsuario(usuario);
                    Usuarios.AgregarUsuario = usuario;
                    SettNameUserPath(usuario);
                   // Paths.NickName = usuario.NickName;
                   // Usuarios.MyUser = usuario;
                    Serializer<User>.JsonSerializerList(Usuarios.UsersList, Paths.LoginPath);
                    MessageBox.Show($"Usuario {usuario.NickName} Registrado con éxito.");
                    InicializarFormularioMenu();
                    //inserta el nuevo usuario
                }else
                    MessageSetAndColor("El Nombre De Usuario Ya Existe, Intente Otro");
            }
            else
            {
                // Si es un login, verificar el usuario en la base de datos
                //User usuarioExistente = DataAccess.Login(usuario.NickName);
                    usuario = VerificarUsuarioExistenteBDD(usuario);
                var verificar = v.VerificarExistente<User>(3,Usuarios.VerificarUsuariosRegistrado); //Json
                //uso delegados, se interfiere el tipo de dato, al llamarlo le paso el dato en si. Closure.
               
                if (usuario is not null)// && verificar(usuario))//VerificarUsuarioExistenteJson(usuario)
                {
                    SettNameUserPath(usuario);
                    //Paths.NickName = usuario.NickName;
                    //Usuarios.MyUser = usuario;
                    //MessageBox.Show($"Usuario cargado con éxito: {usuarioExistente}");
                    InicializarFormularioMenu();
                }
                else
                {
                    MessageSetAndColor("usuario o contraseña inexistente/incorrecta");
                }
            }
        
       }

       
        private void LoginProcess(bool option)
        {
            lbMessage.ResetText();
            if (this.InvokeRequired)
            {
                this.BeginInvoke(() => this.LoginProcess(option));
            }
            else
            {
                User usuarioNuevo = ValidarUsuario(txtNickName.Text, txtPw.Text);

                if (usuarioNuevo != null)
                {
                    ProcesarUsuario(usuarioNuevo, option);
                }
                txtNickName.Clear();
                txtPw.Clear();

            }

        }
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            RunLogTask(true);
        }   

        private void RunLogTask(bool value)
        {
            TLoguearse = Task.Run(() => LoginProcess(value));
        }
        private void btnIngreso_Click(object sender, EventArgs e)
        {
           // LoginProcess(false);
            RunLogTask(false);
        }
    }

}
