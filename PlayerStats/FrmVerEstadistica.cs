using Entities;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace PlayerStats
{
    public partial class FrmVerEstadistica : Form
    {

        private Estadisticas _stat;

        public Estadisticas Stat
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
            rtbEstadisticas.Text = Deportistas.MyAtleta.ToString();
        }

        protected void EnableDisabledTextBox()
        {
            foreach (Control value in Controls)
            {
                if (value is TextBox txt)
                {
                    if (txt.ReadOnly == false)
                        txt.ReadOnly = true;
                    else
                        txt.ReadOnly = false;

                    SetStyle(ControlStyles.UserPaint, true);
                    // Hacer que el TextBox no tenga borde
                    txt.BorderStyle = BorderStyle.None;

                    txt.TextAlign = HorizontalAlignment.Center;


                    // Cambiar el color del texto si es necesario
                    txt.ForeColor = Color.White;
                }

                if (value is Label lb)
                {
                    lb.BackColor = Color.Transparent;
                    lb.ForeColor = Color.White;
                }
            }
        }

        private void btnVerPartidos_Click(object sender, EventArgs e)
        {
            //logica de abrir un formulario nuevo con una grilla de todos los partidos en estilo lista
            //a lo largo, marcando partidos por año, competiciones, club
            //Con un fondo verde claro para las Victorias y, fondo Rojo tenue las derrotas, Gris los empates
            //Con un fondo verde claro para las Victorias y, fondo Rojo tenue las derrotas, Gris los empates
        }
    }
}
