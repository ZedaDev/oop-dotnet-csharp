using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades_8;

namespace Clase13WinForm
{
    public partial class FrmImpresoraMultiFuncion : Form
    {
        Impresora printer;
        public FrmImpresoraMultiFuncion()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printer = new();
            printer._colaDeImpresion = new();
            MessageBox.Show("Created Printer", "Created Sucessfully", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Document document = new();
            printer.AgregarImprimible(document);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Picture picture = new();
            printer.AgregarImprimible(picture);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Contrato contrat = new();
            printer.AgregarImprimible(contrat);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (printer is null || printer._colaDeImpresion.Count <= 0)
                MessageBox.Show("Aun No Hay Impresiones Por Imprimir");
            else
               rtbMessage.Text = printer.ImprimirTodo();
        }
    }
}
