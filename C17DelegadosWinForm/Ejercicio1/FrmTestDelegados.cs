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
    public partial class FrmTestDelegados : Form
    {

        //recibo un action delegado que requiere un string de argumento.
        private Predicate<string> actualizarTxtNombre;
        public FrmTestDelegados(Predicate<string> actualizarNombreDelegado)
        {
            this.actualizarTxtNombre = actualizarNombreDelegado;
            InitializeComponent();
        }

        private void FrmTestDelegados_Load(object sender, EventArgs e)
        {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           if(actualizarTxtNombre.Invoke(txtNombre.Text))
            {
                MessageBox.Show("Exito");
            }else
                MessageBox.Show("Error name!");

        }
    }
}
