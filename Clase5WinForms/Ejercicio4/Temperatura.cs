using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;

namespace Clase5WinForms
{
    public partial class Temperatura : Form
    {
        public Temperatura()
        {
            InitializeComponent();
        }


        private void Temperatura_Load(object sender, EventArgs e)
        {

            foreach (var control in this.Controls)
            {
                if (control is TextBox txt && txt.Tag?.ToString() == "convert")
                {
                    txt.Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtFahrenheit.Text, out double valor))
            {
                lbFaF.Text = txtFahrenheit.Text;
                Fahrenheit tF = new(valor);
                lbFaC.Text = ((Celcius)tF).GetTemperatura().ToString();
                lbFaK.Text = ((Kelvin)tF).GetTemperatura().ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCelsius.Text, out double valor))
            {
                lbCaC.Text = txtCelsius.Text;
                Celcius tC = new(valor);
                lbCaF.Text = ((Fahrenheit)tC).GetTemperatura().ToString();
                lbCaK.Text = ((Kelvin)tC).GetTemperatura().ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbKelvin.Text, out double valor))
            {
                lbKaK.Text = txtKelvin.Text;
                Kelvin tK = new(valor);
                lbKaF.Text = ((Fahrenheit)tK).GetTemperatura().ToString();
                lbKaC.Text = ((Celcius)tK).GetTemperatura().ToString();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            //me fijo si en el objeto sender hay un txt con el tag cotiz
            if (sender is TextBox txt && txt.Tag?.ToString() == "temp")
            {
                if (!double.TryParse(txt.Text, out double number)) txt.Focus();
            }
        }
    }
}
