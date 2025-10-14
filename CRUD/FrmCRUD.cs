using Entidades;
using System.Data;
using System.Text;
using WinFormCRUD;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text.Json;
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
                if (p != null)
                    lstVisor.Items.Add(p.Mostrar());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //TODO Agregar : btnAgregar Click, abre el formulario, valida dialog result y, que Prodcuto no sea NULL, de ser asi agrega el nuevo producto al Atributo Lista y, actualiza el visor.
            FrmProducto frmProducto = new FrmProducto();
            DialogResult result = frmProducto.ShowDialog();
            if (Validate(result, frmProducto._producto))
            {
                _Productos.Add(frmProducto._producto);
                lstVisor.Items.Add(frmProducto._producto.Mostrar());
                //ActualizarVisor();
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
                    //lstVisor.Items. = p._producto.Mostrar();

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
            DialogResult result = p.ShowDialog();

            return Validate(result, p._producto);
        }


        private bool Validate(DialogResult result, Producto p)
        {
            return (result == DialogResult.OK && p is not null);
        }

        private void FrmCRUD_Load(object sender, EventArgs e)
        {

            if (File.Exists(@"./crud.xml"))
            {
                //Importante para leer el archivo es XmlTextREADER para escribir es XmlTextWRITER.
                using (XmlTextReader text = new(@"./crud.xml"))
                {
                    XmlSerializer s = new XmlSerializer(typeof(List<Producto>));
                    _Productos = (List<Producto>)s.Deserialize(text);
                }

                using (StreamReader Read = new(@"./crud.json"))
                {
                    //Leo todo el archivo de texto
                    string objJson = Read.ReadToEnd();

                    //Deserializo el json a una List<Productos>, me devuelve un tipo object y lo casteo
                    _Productos = (List<Producto>)JsonSerializer.Deserialize(objJson, typeof(List<Producto>));

                }
               
            }
        }

        private void FrmCRUD_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Creo el archivo de texto nuevo .xml    CREO EL ARCHIVO
            using (XmlTextWriter writer = new XmlTextWriter(@"./crud.xml", Encoding.UTF8))
            {
                //Creo el objeto para guardar el dato en el archivo.xml  CREO EL OBJETO A GUARDAR
                XmlSerializer s = new XmlSerializer(typeof(List<Producto>));

                //Guardo el objeto en el archivo de texto.xml   GUARDO EL OBJETO EN EL ARCHIVO
                s.Serialize(writer, _Productos);
            }


            JsonSerializerOptions json = new JsonSerializerOptions();
            json.WriteIndented = true;

            string objJson = JsonSerializer.Serialize(_Productos, json);

            using (StreamWriter writer = new StreamWriter(@"./crud.json"))
            {
                writer.WriteLine(objJson);
            }


        }


        private void ToolTipJson_Click(object sender, EventArgs e)
        {
            if (_Productos is not null)
                ActualizarVisor();
        }
    }
}

