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
using Entidades;

namespace Clase6WinForms
{
    public partial class FrmExpendedora : Form
    {
        private Dictionary<int, Stack<Producto>> _expenderMachine;
        private Queue<string> _filaDeClientes;
        public FrmExpendedora()
        {
            InitializeComponent();
            _expenderMachine = new();
            _filaDeClientes = new();
        }



        private void FrmExpendedora_Load(object sender, EventArgs e)
        {
            CharguingImagesProducts();
            CharguingPositionsProducts();
            InicializateDictionaryAndCharguingProducts();
            CharguinClients();
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

            if(_filaDeClientes.Count == 0)
            {
               DialogResult result = MessageBox.Show($"No Quedan Clientes, Desea Agregar Mas?","Clientes",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CharguinClients();
                }
                
            }
            else
            {
                if (txtNumero.Text == string.Empty)
                {
                    lbText.Text = "Ningun Producto Seleccionado";
                }
                else if (!int.TryParse(txtNumero.Text, out _))
                {
                    txtNumero.Focus();
                }
                else if (Convert.ToInt32(txtNumero.Text) > 15 || Convert.ToInt32(txtNumero.Text) <= 0)
                {
                    lbText.Text = "Error, El Producto No Existe";
                }
                else
                {
                    int i = int.Parse(txtNumero.Text) - 1;
                    Stack<Producto> pila = _expenderMachine[i];
                    if (pila.Count > 0)
                    {
                        lbText.Text = $"{txtNumero.Text} - {pila.Peek().Mostrar()} - Disponibles : {pila.Count}";
                        MessageBox.Show($"{_filaDeClientes.Dequeue()} Se Lleva {pila.Pop().Mostrar()}\nClientes Restantes : {_filaDeClientes.Count()}");
                    }
                    else
                        lbText.Text = $"Producto {txtNumero.Text} Sin Stock";
                }
            }
                    txtNumero.Clear();
        }

        private Stack<Producto> CargarProductos(string name, double price)
        {
            Stack<Producto> p = new();
            CargarPilaProductos(price, p, 3, name);
             return p;
        }

        private void CargarPilaProductos(double precio, Stack<Producto> pila, int cantidad, string name)
        {

            for (int i = 0; i < cantidad; i++)
            {
                pila.Push(new Producto(i, name, precio));
            }
        }

        private void InicializateDictionaryAndCharguingProducts()
        {
               
            string[] nombres = {
                "Gatorade", "Red Label", "Lays", "Oreo", "Jugo Cepita",
                "Coca Cola", "Helado Oreo", "Gaseosa H2o", "Jack Daniels", "Fanta",
                "Kinder", "Pringless", "Red Bull", "7Up", "Milka"
            };

            double[] precios = {
                80.5, 115.0, 55.0, 75, 45.5,
                90.0, 78.5, 70.2, 140.0, 72.1,
                50.0, 49.5, 90.0, 85.5, 100.5
            };

            for (int j = 0; j < 15; j++)
            {
                Stack<Producto> p = CargarProductos(nombres[j], precios[j]);
                _expenderMachine.Add(j, p);
            }
        }

        private void CharguingImagesProducts()
        {

            //Cargo Las imagenes de los productos, en los PictureBox.
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
        }
        private void CharguingPositionsProducts()
        {
            //Cargo la posicion de cada producto.
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

        private void CharguinClients()
        {
     
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese nombres de nuevos clientes separados por coma:",
                "Agregar Clientes");
            
            if (!string.IsNullOrEmpty(input))
            {
                string[] clientes = input.Split(',',StringSplitOptions.RemoveEmptyEntries);
                foreach (string cliente in clientes)
                {
                    _filaDeClientes.Enqueue(cliente);
                }
                    MessageBox.Show($"Agregados {clientes.Count()} Nuevos Clientes");
            }

        }
    }
}
