using Entities;
using Service;

namespace PlayerStats
{
    public partial class FrmCargarFutbolista : FrmCargarDeportista
    {
        public FrmCargarFutbolista()
        {
            //base.InitializeComponent();
            InitializeComponent();
            btnCargar.Text = "Cargar Futbolista";
            cmbPhHabil.DataSource = Enum.GetValues(typeof(EDeporte));
        }

        public void btnCargar_Click(object sender, EventArgs e)
        {
            if (base.CheckCamps())
            {
                DateTime fechaDebut = DateTime.Today.Date;
                string fullName = txtFullName.Text;
                string edad = txtEdad.Text;
                EDeporte deporte = EDeporte.Futbol;
                string posicion = txtPosicion.Text;
                string clubActual = txtClubActual.Text;
                string phHabil = cmbPhHabil.SelectedIndex.ToString();
                string altura = txtAltura.Text;
                string pais = txtNacionalidad.Text;

                Deportista futbolista = new Futbolista(fullName, edad, deporte, fechaDebut, posicion, clubActual, phHabil, altura, pais);
                D.AgregarAtleta = futbolista;
                MessageBox.Show("Deportista Cargado Con Exito", "Congratulations", MessageBoxButtons.OK);

                ClearCamps(); //Limpio todos los textboxs,etc.
            }


        }
    }
}
