using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase5WinForms.Ejercicio7
{
    public partial class Descuento : Form
    {
        public Descuento()
        {
            InitializeComponent();
        }
        private void Descuento_Load(object sender, EventArgs e)
        {
            txtDescuento.Enabled = false;
            txtTotal.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCostoInicial.Text, out double valor))
            {
                CalcularTotal(valor);
            }
            else txtCostoInicial.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if(control is TextBox) // borro el contenido de todos los 'TextsBoxs'.
                    control.Text = string.Empty;
                    txtCostoInicial.Focus();
            }
        }

        private void CalcularTotal(Double numero)
        {
            double descuento = 0;
            if (numero >= 5000)
            {///hago 3 cosas,obtengo el resultado, asigno a variable y, resto el valor.
                numero = numero - (descuento = numero * 20 / 100);
            }
            else if (numero >= 3000)
                numero = numero - (descuento = numero * 10 / 100);

            //Descuento ya quedo inicializado en los if.
            txtDescuento.Text = descuento.ToString();
            txtTotal.Text = numero.ToString("F2");
        }

        private void Descuento_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
