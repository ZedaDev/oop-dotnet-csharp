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
    public partial class FrmVolarYVolar : Form
    {

        public FrmVolarYVolar()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Volador buzz = new BuzzLightyear();
            TorreDeControl.AgregarVolador(buzz);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Volador pato = new Pato();
            TorreDeControl.AgregarVolador(pato);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Volador boing = new Boing747();
            TorreDeControl.AgregarVolador(boing);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbMessage.Text = TorreDeControl.VuelenTodos();
        }
    }
}
