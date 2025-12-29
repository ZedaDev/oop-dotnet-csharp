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




        private void InicializarFormularioMenu()
        {

            frmMenuPrincipal menu = new();

            this.Hide(); //oculta el formulario
            menu.ShowDialog();
            this.Close();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Usuarios.UsersList = Serializer<User>.JsonDeserializeList(Paths.LoginPath);

        }


        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked)
                txtPw.PasswordChar = '\0';
            else
                txtPw.PasswordChar = '*';
        }
        private User DateValidate(string name, string pw)
        {
            if (Helper.CheckText(name, pw))
            {
                User usuarioNuevo = new(name, pw);
                return usuarioNuevo;
            }
            else
                lbMessage.Text = "Asegurese De Completar Los Campos";


            return null;

        }
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            lbMessage.ResetText();
            User usuarioNuevo = DateValidate(txtNickName.Text, txtPw.Text);

            if (usuarioNuevo is not null)
            {
                if (Usuarios.VerificarUsuariosRegistrado(usuarioNuevo))
                {
                    lbMessage.Text = "El Nombre De Usuario Ya Existe, Intente Otro";
                    lbMessage.ForeColor = Color.Red;
                }
                else
                {
                    Paths.NickName = usuarioNuevo.NickName;
                    Usuarios.MyUser = usuarioNuevo;
                    Usuarios.AgregarUsuario = usuarioNuevo;
                    Serializer<User>.JsonSerializerList(Usuarios.UsersList, Paths.LoginPath);
                    InicializarFormularioMenu();
                }
                txtNickName.Clear();
                txtPw.Clear();
            }
        }


        private void btnIngreso_Click(object sender, EventArgs e)
        {
            if (Usuarios.UsersList.Count == 0)
            {
                lbMessage.Text = "Usuario No Registrado";
            }
            else if (!Helper.CheckText(txtNickName.Text, txtPw.Text))
            {
                lbMessage.Text = "Asegurese De Completar Los Campos";
            }
            else
            {
                User usuarioNuevo = new(txtNickName.Text, txtPw.Text);
                if (!Usuarios.UsersList.Contains(usuarioNuevo))
                {
                    lbMessage.Text = "El Nombre De Usuario No Existe";
                    lbMessage.ForeColor = Color.Red;
                    txtNickName.Clear(); txtNickName.Focus();
                }
                else
                {
                    Paths.NickName = usuarioNuevo.NickName;
                    Usuarios.MyUser = usuarioNuevo;
                    InicializarFormularioMenu();
                }
            }
        }
    }

}
