using Entities;
using Service;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace PlayerStats
{
    public partial class FrmVerEstadistica : Form
    {

        private IEstadistica _stat;

        public IEstadistica Stat
        {
            get => _stat;
            set
            {
                if (value is not null)
                    _stat = value;
            }
        }

        public FrmVerEstadistica()
        {
            InitializeComponent();
            btnInfo.Visible = false;
            rtbEstadisticas.Text = Deportistas.MyAtleta.ToString() + Deportistas.MyAtleta.CalcularsTATS();
        }

        public void EnableDisabledTextBox(bool v)
        {
            foreach (Control value in Controls)
            {
                if (value is TextBox txt)
                {
                   
                        txt.ReadOnly = !v;
                    /*else
                        txt.ReadOnly = false;*/

                    SetStyle(ControlStyles.UserPaint, true);
                    // Hacer que el TextBox no tenga borde
                    txt.BorderStyle = BorderStyle.None;

                    txt.TextAlign = HorizontalAlignment.Center;


                    // Cambiar el color del texto si es necesario
                    //txt.ForeColor = Color.White;
                }

                if (value is Label lb)
                {
                    lb.BackColor = Color.Transparent;
                    lb.ForeColor = Color.White;
                }
               if(value is RichTextBox rtb)
                {
                    rtb.ReadOnly = !v;
                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
           


            //logica de abrir un formulario nuevo con una grilla de todos los partidos en estilo lista
            //a lo largo, marcando partidos por año, competiciones, club
            //Con un fondo verde claro para las Victorias y, fondo Rojo tenue las derrotas, Gris los empates
            //Con un fondo verde claro para las Victorias y, fondo Rojo tenue las derrotas, Gris los empates
        }
    }
}
