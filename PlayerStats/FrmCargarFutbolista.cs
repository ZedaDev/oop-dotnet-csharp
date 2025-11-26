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
            cmbPhHabil.DataSource = Enum.GetValues(typeof(ELadoHabil));
            cmbPhHabil.SelectedIndex = -1;
           
        }
        public void btnCargar_Click(object sender, EventArgs e)
        {
            if (base.CheckCamps())
            {
               Deportista futbolista = GetDateControls();
                
                if (D + futbolista)
                {
                    D.CargarDeportistaAlArchivo(Paths.DeportistasPath, D.Atletas);
                    MessageBox.Show($"Deportista Cargado Con Exito", "Congratulations", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("El Deportista Que Intenta Registrar, Ya Se Encuentra Cargado..");

                    ClearCamps(); //Limpio todos los textboxs,etc.
            }
        }
        private Deportista GetDateControls()
        {
            DateTime d = mCalendar.SelectionStart;
            string fechaDebut = d.ToString("dd-MM-yyyy");
            string fullName = txtFullName.Text;
            string edad = txtEdad.Text;
            EDeporte deporte = EDeporte.Futbol;
            string posicion = txtPosicion.Text;
            string clubActual = txtClubActual.Text;
            string phHabil = cmbPhHabil.SelectedIndex.ToString();
            string altura = txtAltura.Text;
            string pais = txtNacionalidad.Text;
            string apodo = txtApodo.Text;

            return new Futbolista(fullName, edad, apodo, deporte, fechaDebut, posicion, clubActual, phHabil, altura, pais);

        }


    }
}
