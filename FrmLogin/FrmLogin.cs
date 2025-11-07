using Models;

namespace FrmLogin
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
            List<User> listaUsuarios = Usuarios.UsersList;
            listaUsuarios.Add(usuarioNuevo);


            if (Usuarios.UsersList.Count == 0)
            {
                Usuarios.SetUser = usuarioNuevo;
            }
            else if (Usuarios.UsersList.Count > 0 && Usuarios.UsersList == usuarioNuevo)
            {
                lbMessage.Text = "El Nombre De Usuario Ya Existe, Intente Otro";
                lbMessage.ForeColor = Color.Red;

                txtNickName.Clear(); txtNickName.Focus();
            } //Agregar el else para iniciar el FrmMenu.

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPass.Checked)
            {
                txtPw.PasswordChar = '\0';
            }else
                txtPw.PasswordChar = '*';

        }
    }
}
