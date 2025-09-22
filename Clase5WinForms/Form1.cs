namespace Clase5WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("EY EY CLICK ECHO","Saludos!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("YES APRETADO");
            } else MessageBox.Show("NO APRETADO");
        }
    }
}
