using FrmCargarDeportista;
using Entities;
using Service;
namespace FrmCargarFutbolista
{
    public partial class CargarFutbolista : FrmCargarDeportista.FrmCargarDeportista
    {
        public CargarFutbolista()
        {
            base.InitializeComponent();
            InitializeComponent();
            btnCargar.Click += btnCargar_Click;
            btnCargar.Text = "Cargar Futbolista";
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            if (ComprobarCamposNull())
            {
                DateTime fechaDebut = DateTime.Today.Date;
                string fullName = txtFullName.Text;
                string edad = txtEdad.Text;
                EDeporte deporte = EDeporte.Futbol;
                string posicion = txtPosicion.Text;
                string clubActual = txtClubActual.Text;
                string phHabil = "derecha";
                string altura = txtAltura.Text;

                if (mCalendar.SelectionRange.Start.Date == DateTime.Today.Date)
                {//si la fecha que selecciono es igual a la de hoy.
                    DialogResult res = MessageBox.Show("La fecha seleccionada es la actual, Desea asignarla?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else
                    fechaDebut = mCalendar.SelectionStart; //Asigno la fecha seleccionada

                
                //Deportista futbolista = new Futbolista(fullName, edad, deporte, fechaDebut, posicion, clubActual, phHabil, altura);
                D.AgregarAtleta = futbolista;
                MessageBox.Show("Deportista Cargado Con Exito", "Congratulations", MessageBoxButtons.OK);

                ClearCamps(); //Limpio todos los textboxs,etc.

            }
            else
                MessageBox.Show("Asegurese de completar todos los campos");
        }
    }
}
