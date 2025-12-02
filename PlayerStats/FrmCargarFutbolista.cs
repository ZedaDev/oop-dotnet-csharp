using Entities;
using Service;

namespace PlayerStats
{
    public partial class FrmCargarFutbolista : FrmCargarDeportista
    {
        public FrmCargarFutbolista()
        {
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

        //implementar lo mismo en los Frms heredados de los demas deportistas, boxeo, tenis, etc.
        private Deportista GetDateControls()
        {
            DateTime d = mCalendar.SelectionStart;
            string fechaDebut = d.ToString("dd-MM-yyyy");
            string fechaDeRegistro = DateTime.Now.Date.ToString("dd-MM-yyyy");
            string fullName = txtFullName.Text;
            string edad = txtEdad.Text;
            EDeporte deporte = EDeporte.Futbol;
            string posicion = txtPosicion.Text;
            string clubActual = txtClubActual.Text;
            ELadoHabil phHabil;
            if (cmbPhHabil.SelectedIndex.ToString() == ELadoHabil.Der.ToString())
                phHabil = ELadoHabil.Der;
            else
                phHabil = ELadoHabil.Izq;

                string altura = txtAltura.Text;
            string pais = txtNacionalidad.Text;
            string apodo = txtApodo.Text;

            return new Futbolista(fullName, edad, apodo, deporte, fechaDebut, posicion, clubActual, phHabil, altura, pais, fechaDeRegistro, NickName);

        }


    }
}
