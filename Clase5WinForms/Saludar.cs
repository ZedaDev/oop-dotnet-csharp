using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase5WinForms
{
    public partial class Saludar : Form
    {
        private string _titulo;
        private string _mensaje;
        public Saludar(string titulo, string mensaje)
        {
            InitializeComponent();
            _titulo = titulo;
            _mensaje = mensaje;
            ConfigLabels();
        }

        private void ConfigLabels()
        {
            label1.Text = _titulo;
            label1.Font = new("inter", 14, FontStyle.Bold | FontStyle.Italic); //se usa | por que unifica los bytes en un solo Font.
            label2.Text = _mensaje;
            label1.Font = new("inter", 12, FontStyle.Bold | FontStyle.Italic);
        }
    }
}
