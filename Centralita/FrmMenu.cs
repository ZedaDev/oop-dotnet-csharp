using CentralTelefonica;
namespace Centralita
{
    public partial class FrmMenu : Form
    {
        public CentralTelefonica.Centralita _centralita;
        public FrmMenu()
        {
            InitializeComponent();
            _centralita = new("Telephone Center");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
           FrmLlamador frmLlamar = new FrmLlamador(_centralita);
           frmLlamar.ShowDialog();

        }

        private void btnFTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(_centralita);

            if ((Button)sender == btnFLocal)
                frmMostrar.TipoLlamada = ETipoDeLlamada.Local;
            else if ((Button)sender == btnFProv)
                frmMostrar.TipoLlamada = ETipoDeLlamada.Provincial;
            else
                frmMostrar.TipoLlamada = ETipoDeLlamada.Todas;

            frmMostrar.ShowDialog();
        }

  


    }
}
