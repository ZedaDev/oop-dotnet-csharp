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

            if (string.IsNullOrEmpty(nick) || string.IsNullOrEmpty(pw))
                lbMessage.Text = "Asegurese De Completar Los Campos";

            else if (Usuarios.UsersList.Count == 0)
                lbMessage.Text = "Usuario No Registrado";

            else if(Usuarios.UsersList.Count > 0)
            {
                 User usuarioNuevo = new(nick, pw);
                if(!Usuarios.UsersList.Contains(usuarioNuevo))
                {
                    lbMessage.Text = "El Nombre De Usuario No Existe";
                    lbMessage.ForeColor = Color.Red;
                    txtNickName.Clear(); txtNickName.Focus();
                }
                else
                    InicializarFormularioMenu(usuarioNuevo.NickName);
            }

        
        }

        private void InicializarFormularioMenu(string nickName)
        {
            Deportistas d = new();
            frmMenuPrincipal menu = new();
            menu.NickName = nickName;
            menu.Dportistas = d;

            this.Hide(); //oculta el formulario
            menu.ShowDialog();
            this.Close();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Paths.DeserializarArchivoUsuarios(Paths.LoginPath);
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

            if (string.IsNullOrEmpty(nick) || string.IsNullOrEmpty(pw))
                lbMessage.Text = "Asegurese De Completar Los Campos";
            else
            {
                User usuarioNuevo = new(nick, pw);
                if (Usuarios.VerificarUsuariosRegistrado(usuarioNuevo))
                {
                    lbMessage.Text = "El Nombre De Usuario Ya Existe, Intente Otro";
                    lbMessage.ForeColor = Color.Red;
                }
                else
                {
                    Usuarios.SetUser = usuarioNuevo;
                    Paths.GuardarUsuariosEnArchivo();
                    // Guardamos la lista actualizada en el archivo JSON
                    InicializarFormularioMenu(usuarioNuevo.NickName);
                    //MessageBox.Show("Registro Exitoso", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    txtNickName.Clear();
                    txtPw.Clear();
            }
        }
       
    }

}
