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
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "SerializeXml");
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            if ( File.Exists(path = Path.Combine(path, "Datos.xml")) )
            {
                //Importante para leer el archivo es XmlTextREADER para escribir es XmlTextWRITER.
                using (XmlTextReader text = new(path))
                {
                    XmlSerializer s = new XmlSerializer(typeof(List<Producto>));
                    _Productos = (List<Producto>)s.Deserialize(text);
                }
            } 

                string pathJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "SerializeJson");
            if (!Directory.Exists(pathJson))
                Directory.CreateDirectory(pathJson);

            if (File.Exists(pathJson = Path.Combine(pathJson,"Datos.json")))
            {
                using (StreamReader Read = new(pathJson))
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
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = Path.Combine(path,"SerializeXml", "Datos.xml");
            //Creo el archivo Xml para escribir en el, le paso el nombre por parametro
            using (XmlTextWriter archivo = new(path, Encoding.UTF8))
            {
                //creo el objeto xml para guardar, le paso el tipo de dato a serializar.
                    XmlSerializer guardar = new(typeof(List<Producto>));

               //Con el objeto xml para guadar,le paso por parametro el archivo donde escirbir
               //y el tipo de dato a escribir.
                    guardar.Serialize(archivo, _Productos);
            }

            string pathJson = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            pathJson = Path.Combine(pathJson, "SerializeJson", "Datos.json");

            JsonSerializerOptions json = new JsonSerializerOptions();
            json.WriteIndented = true;

            string objJson = JsonSerializer.Serialize(_Productos, json);

            File.WriteAllText(pathJson, objJson);
        }

        private void ToolTipJson_Click(object sender, EventArgs e)
        {
            if (_Productos is not null)
                ActualizarVisor();
        }
    }
}

