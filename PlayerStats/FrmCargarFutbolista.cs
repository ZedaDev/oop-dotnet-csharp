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

                
                Deportista futbolista = new Futbolista(fullName, edad, apodo, deporte, fechaDebut, posicion, clubActual, phHabil, altura, pais);
                string pathJson = futbolista.MisDeportistas(base.NickName);
                //cambiar la ruta, para no sobreescribir el deportistas.json de usuarios.
                D.AgregarAtleta = futbolista;

               // if (D + futbolista)
                //{
                    D.CargarDeportistaAlArchivo(pathJson, D.Atletas);
                    MessageBox.Show($"Deportista Cargado Con Exito", "Congratulations", MessageBoxButtons.OK);
               // }
               // else
                  //  MessageBox.Show("El Deportista Que Intenta Registrar, Ya Se Encuentra Cargado..");

                    ClearCamps(); //Limpio todos los textboxs,etc.
            }


        }
    }
}
