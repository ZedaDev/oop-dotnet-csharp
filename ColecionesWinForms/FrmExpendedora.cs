using Clase6WinForms.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase6WinForms
{
    public partial class FrmExpendedora : Form
    {
        public FrmExpendedora()
        {
            InitializeComponent();
        }



        private void FrmExpendedora_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Control control in gBProductos.Controls)
            {
                if (control is PictureBox pic)
                {
                    string name = $"producto{i}";
                    i += 1;
                    object result = (Image)Resources.ResourceManager.GetObject(name);
                    if (result is not null)
                    {
                        pic.Image = (Image)result;
                        pic.SizeMode = PictureBoxSizeMode.Zoom;
                        pic.BackColor = Color.Black;
                    }
                }
            }

            int pos = 15;
            foreach (Control value in gBProductos.Controls)
            {
                if (value is Label texto && texto.Tag?.ToString() == "posicion")
                {
                    texto.Text = pos.ToString();
                    texto.BackColor = Color.Black;
                    texto.ForeColor = Color.Red;
                    pos--;
                }
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
                txtNumero.Text += btn.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == string.Empty)
            {
                lbText.Text = "Ningun Producto Seleccionado";
            }
            else if (Convert.ToInt32(txtNumero.Text) > 15)
            {
                lbText.Text = "Error, El Producto No Existe";
            }
            else lbText.Text = $"Producto {txtNumero.Text} Agregado";
        }
    }
}
