using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCRUD.Crud2
{
    public partial class AltaBajaModificacion : Form
    {
        public AltaBajaModificacion()
        {
            InitializeComponent();
        }
        public AltaBajaModificacion(string tituloFormulario, string texto, string textoBtn)
            : this()
        {
            txtObjeto.Text = texto;
            btnConfirmar.Text = textoBtn;
            this.Text = tituloFormulario;
        }

        public string Objeto
        {
            get => txtObjeto.Text;
        }



        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateAndAction(e);
        }
        private void ValidateAndAction(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (!string.IsNullOrEmpty(txtObjeto.Text))
                    FormReturn(DialogResult.OK);
                else
                    EmptyMessage();
            }

            if (e.KeyChar == (char)27)
                FormReturn(DialogResult.Cancel);

        }

        private void FormReturn(DialogResult res)
        {
            this.DialogResult = res;
            this.Close();
        }

        private void EmptyMessage()
        {
            MessageBox.Show("Texto Vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtObjeto.Text))
            {
                FormReturn(DialogResult.OK);
            }
            else EmptyMessage();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormReturn(DialogResult.Cancel);
        }

        private void AltaBajaModificacion_Load(object sender, EventArgs e)
        {
            
        }
    }
}
