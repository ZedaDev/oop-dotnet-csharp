using Entities;
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
        }

        protected void EnableDisabledTextBox()
        {
            foreach (Control value in Controls)
            {
                if(value is TextBox txt)
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

                if(value is Label lb)
                {
                    lb.BackColor = Color.Transparent;
                    lb.ForeColor = Color.White;
                }
            }
        }

    }
}
