using Billetes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Clase5WinForms.Ejercicio3
{
    public partial class Conversor : Form
    {

        private bool _candado;

        public Conversor()
        {
            InitializeComponent();
            _candado = false;
        }

        private void Conversor_Load(object sender, EventArgs e)
        {
            //Cargo imagenes del candado
            pBoxCandado.Image = imageList1.Images[0];
            pBoxCandado.SizeMode = PictureBoxSizeMode.AutoSize;
            pBoxCandado.Cursor = Cursors.Hand;

            //Setteo la cotizacion de cada moneda 
            SettQuotes("-");

            //Desactivo los txt de conversion
            foreach (var control in this.Controls)
            {
                if (control is TextBox txt && txt.Tag?.ToString() == "convert")
                {
                    txt.Enabled = false;
                }
            }

            ActivateLabels(this);
        }

        private void pBoxCandado_Click(object sender, EventArgs e)
        {
            _candado = !_candado; //Logica inversa, si esta cerrado, click y se abre.
            pBoxCandado.Image = imageList1.Images[_candado ? 1 : 0];
            ActivateLabels(this);
        }

        private void ActivateLabels(Control container)
        {
            foreach (var control in container.Controls)
            {
                if (control is TextBox txt && txt.Tag?.ToString() == "cotiz")
                {
                    txt.Enabled = _candado;
                }
            }
        }

        private void SettQuotes(string name)
        {
            switch (name)
            {
                case "txtCotizEuro":
                     txtCotizEuro.Text = $"{Euro.GetQuote()}";
                    break;
                case "txtCotizPeso":
                     txtCotizPeso.Text = $"{Pesos.GetQuote():F6}";
                    break;
                default:

                     txtCotizDolar.Text = $"{Dolar.GetQuote():F2}";
                     txtCotizPeso.Text = $"{Pesos.GetQuote():F6}";
                     txtCotizEuro.Text = $"{Euro.GetQuote():F2}";
                break;
            }
        }

        private void txtCotizEuro_Leave_1(object sender, EventArgs e)
        {
            //me fijo si en el objeto sender hay un txt con el tag cotiz
            if(sender is TextBox txt && txt.Tag?.ToString() == "cotiz")
            {
                if (!double.TryParse(txt.Text, out double number)) txt.Focus();
                else
                {
                    if (txt.Name == "txtCotizEuro") Euro.SetCotizacion(number);
                    else if (txt.Name == "txtCotizPeso") Pesos.SetCotizacion(number);
                    SettQuotes(txt.Name);
                }
            }
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtEuro.Text, out double valor))
            {
                txtEuroAEuro.Text = valor.ToString();
                Euro euro = new(Convert.ToDouble(txtEuro.Text));

                txtEuroADolar.Text = ((Dolar)euro).GetAmount().ToString("F5");
                txtEuroAPeso.Text = ((Pesos)euro).GetAmount().ToString("F5");
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDolar.Text, out double valor))
            {
                txtDolarADolar.Text = valor.ToString();
                Dolar dolar = new(Convert.ToDouble(txtDolar.Text));

                txtDolarAEuro.Text = ((Euro)dolar).GetAmount().ToString("F5");
                txtDolarAPeso.Text = ((Pesos)dolar).GetAmount().ToString("F5");
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPeso.Text, out double valor))
            {
                txtPesoAPeso.Text = valor.ToString();
                Pesos peso = new(Convert.ToDouble(txtPeso.Text));

                txtPesoADolar.Text = ((Dolar)peso).GetAmount().ToString("F5");
                txtPesoAEuro.Text = ((Euro)peso).GetAmount().ToString("F5");
            }
        }
    }
}
