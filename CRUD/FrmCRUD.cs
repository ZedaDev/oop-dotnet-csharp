using Entidades;
using WinFormCRUD;

namespace CRUD
{


    public partial class FrmCRUD : Form
    {

        private List<Producto> _Productos;
        public FrmCRUD()
        {
            InitializeComponent();
            _Productos = new List<Producto>();
        }

        private void ActualizarVisor()
        {
            lstVisor.Items.Clear();
            foreach (Producto p in _Productos)
            {
                if(p != null)
                lstVisor.Items.Add(p.Mostrar());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //TODO Agregar : btnAgregar Click, abre el formulario, valida dialog result y, que Prodcuto no sea NULL, de ser asi agrega el nuevo producto al Atributo Lista y, actualiza el visor.
            FrmProducto frmProducto = new FrmProducto();
            DialogResult result = frmProducto.ShowDialog();
            if(Validate(result, frmProducto._producto))
            {
                _Productos.Add(frmProducto._producto);
                ActualizarVisor();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //TODO Modificar : btnModificar Click, captura el indice seleccionado por esl usuario, abre el formulario, valida dialog resulta, Producto y, luego reemplaza el mismo indice seleccionado por el nuevo objeto Producto, luego actualiza el visor.
            int i = lstVisor.SelectedIndex;
            if (i >= 0)
            {
                FrmProducto p = new(_Productos[i]);
                DialogResult result = p.ShowDialog();
                if (Validate(result, p._producto))
                {
                    _Productos[i] = p._producto;
                       ActualizarVisor();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //TODO Eliminar: btnEliminar Click, Captura el indice, abre el formulario, valida dialog result y, luego Elimina del Atributo Lista el producto en el indice Seleccionado, luego actualiza el visor.
            int i = lstVisor.SelectedIndex;
            if (i >= 0)
            {
                if (CaptureResultAndValidateProduct(i))
                {
                    _Productos.RemoveAt(i);
                    ActualizarVisor();
                }

            }
        }
        private bool CaptureResultAndValidateProduct(int i)
        {
            FrmProducto p = new(_Productos[i], false);
            DialogResult result  = p.ShowDialog();

            return Validate(result, p._producto);
        }


        private bool Validate(DialogResult result, Producto p)
        {
            return (result == DialogResult.OK && p is not null);
        }

    }
}
