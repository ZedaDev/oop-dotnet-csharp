using Models;


namespace FrmMenuPrincipal
{
    public partial class frmMenuPrincipal : Form
    {

        public User UserLogueado
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
            lbDateTime.Text = DateTime.Now.ToString();
            lbUser.Text = UserLogueado.NickName;
        }
    }
}
