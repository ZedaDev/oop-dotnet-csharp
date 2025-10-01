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
using static System.Net.Mime.MediaTypeNames;

namespace Clase5WinForms
{
    public partial class ConversorB : Form
    {
        public ConversorB()
        {
            InitializeComponent();
        }

        private void ConversorB_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox txt && txt.Tag?.ToString() == "convert")
                    txt.Enabled = false;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox txt && txt.Tag?.ToString() == "number")
            {
                if (!double.TryParse(txt.Text, out double valor)) txt.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNumBinario.Text != "0" && txtNumBinario.Text != "1")
            {
                NumeroBinario bin = txtNumBinario.Text.Trim();
                txtBaD.Text = bin.ConvertirBinarioADecimal((string)bin).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumDecimal.Text, out double valor))
            {
                txtDaB.Text = NumeroDecimal.ConvertirDecimalABinario(valor);
            }
        }
    }
}
