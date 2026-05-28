using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C17DelegadosWinForm
{
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
        }


        public bool ActualizarNombre(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }

            lbNombre.Text = name;
                return true;
        }
    }
}
