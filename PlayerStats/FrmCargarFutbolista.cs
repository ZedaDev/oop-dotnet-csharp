using Entities;
using Service;
using System.Collections.Generic;

namespace PlayerStats
{
    public partial class FrmCargarFutbolista : FrmCargarDeportista
    {

       private bool _flag;
        public FrmCargarFutbolista()
        {
            InitializeComponent();
            btnCargar.Text = "Cargar Futbolista";
            cmbPhHabil.DataSource = Enum.GetValues(typeof(ELadoHabil));
            cmbPhHabil.SelectedIndex = -1;


        }
        public void CargarDatosParaModificar()
        {
          IFutbolista futbolista = (IFutbolista)Deportistas.MyAtleta;
            if(futbolista is not null)
            {
                txtClubActual.Text = futbolista.ClubActual;
                txtApodo.Text = futbolista.Apodo;
                txtAltura.Text = futbolista.Altura;
                txtEdad.Text = futbolista.Edad;
                txtFullName.Text = futbolista.FullName;
                txtNacionalidad.Text = futbolista.Nacionalidad;
                txtPosicion.Text = futbolista.Posicion;
                rtbDescripcion.Text = futbolista.Comentario;
                if (futbolista.PhHabil.ToString() == ELadoHabil.Der.ToString())
                    cmbPhHabil.SelectedIndex = 0;
                else
                    cmbPhHabil.SelectedIndex = 1;

                btnCargar.Text = "Actualizar Futbolista";
                _flag = true;
            }

        }

        public void btnCargar_Click(object sender, EventArgs e)
        {
            if (base.CheckCamps())
            {
                Deportista futbolista = GetDateControls();
                if (_flag)
                {
                    futbolista.Estadisticas.AddRange(Deportistas.Atletas[Deportistas.INDEX].Estadisticas);
                    Deportistas.Atletas[Deportistas.INDEX] = futbolista;
                    Serializer<Deportista>.JsonSerializerList(Deportistas.Atletas, Paths.DeportistasPath);
                    MessageBox.Show($"{Messages.CongratsMessage("Deportista")}", "Congratulations", MessageBoxButtons.OK);
                }
                else if (Deportistas.Atletas + futbolista)
                {
                    Serializer<Deportista>.JsonSerializerList(Deportistas.Atletas, Paths.DeportistasPath);
                    MessageBox.Show($"{Messages.CongratsMessage("Deportista")}", "Congratulations", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("El Deportista Que Intenta Registrar, Ya Se Encuentra Cargado..");

                ClearCamps(); //Limpio todos los textboxs,etc.
            }
        }

        //implementar lo mismo en los Frms heredados de los demas deportistas, boxeo, tenis, etc.
        private Deportista GetDateControls()
        {
            DateTime fechaDebut = mCalendar.SelectionStart;
           // DateTime fechaDebut = d.ToString("dd-MM-yyyy");
            DateTime fechaDeRegistro = DateTime.Now.Date;
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
            string comentario = rtbDescripcion.Text;

            return new Futbolista(fullName, edad, apodo, deporte, fechaDebut, posicion, clubActual, phHabil, altura, pais, fechaDeRegistro, NickName, comentario);

        }


    }
}
