using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase5WinForms.Ejercicio6
{
    public partial class TablaMultiplicar : Form
    {
        public TablaMultiplicar()
        {
            InitializeComponent();
        }
        private void TablaMultiplicar_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void txtNumero_Enter(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero.Text, out double number))
            {
                MostrarTabla(number);
            }
        }

        private void MostrarTabla(double number)
        {
            for (double i = 0; i < number; i++)
            {
                lstTabla.Items.Add($"{number} x {i} = {number * i:F0}");
            }

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (double.TryParse(txtNumero.Text, out double number))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    lstTabla.Items.Clear();
                    MostrarTabla(number);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clear();
        }


        private void clear()
        {
            txtNumero.Clear();
            lstTabla.Items.Clear();
        }
    }
}
