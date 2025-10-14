using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace WinFormCRUD
{
    public partial class FrmProducto : Form
    {
        public Producto _producto;
        public FrmProducto()
        {
            InitializeComponent();
        }
        public FrmProducto(Producto prod)
            : this()
        {
            _producto = prod;
            txtName.Text = prod._nombre;
            txtPrice.Text = prod._precio.ToString();
            txtCode.Text = prod._codigo.ToString();
            txtCode.Enabled = false;
        }
        public FrmProducto(Producto prod, bool f)
            : this(prod)
        {
            txtName.Enabled = f;
            txtPrice.Enabled = f;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrice.Text, out double price) && int.TryParse(txtCode.Text, out int code) && !string.IsNullOrWhiteSpace(txtName.Text))
                _producto = new Producto(code, txtName.Text.Trim(), price);

            if (_producto != null)
                CloseFormAndCaptureDialog(DialogResult.OK);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CloseFormAndCaptureDialog(DialogResult.Cancel);
        }

        private void CloseFormAndCaptureDialog(DialogResult result)
        {
            this.DialogResult = result;
            this.Close();
        }

        private void FrmProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
    
        }
    }
}
