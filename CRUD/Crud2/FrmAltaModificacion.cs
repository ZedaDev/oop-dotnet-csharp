using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormCRUD.Crud2
{
    public partial class FrmAltaModificacion : Form
    {

        private List<string> _supermercado;
        public FrmAltaModificacion()
        {
            InitializeComponent();
            _supermercado = new List<string>();
        }

        #region Load Dates And SetTools

            private void FrmAltaModificacion_Load(object sender, EventArgs e)
            {
               string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Lista Super");
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            //LoadJsonDatesArchive(Path.Combine(path, "lista.json"));
            LoadXmlDatesArchive(path, Path.Combine(path, "lista.xml"));

                if (_supermercado is not null)
                    ActualizarVisor();

                SetToolTips();
            }


            private void LoadXmlDatesArchive(string path, string archivo)
            { 

               if(File.Exists(archivo))
               {

                   using (XmlTextReader text = new (archivo))
                   {
                       XmlSerializer s = new XmlSerializer(typeof(List<string>));
                         _supermercado = (List<string>) s.Deserialize(text);
                   }
               }
            }

            private void LoadJsonDatesArchive(string archivo)
            {
                if (File.Exists(archivo))
                {
                    using (StreamReader text = new(archivo))
                    {
                        string textArchive = text.ReadToEnd();

                        _supermercado = (List<string>)JsonSerializer.Deserialize(textArchive, typeof(List<string>));
                    }
                }
            }
            private void SetToolTips()
            {
                toolTip1.SetToolTip(btnAgregar, "Agregar Objeto");
                toolTip1.SetToolTip(btnEliminar, "Eliminar Objeto");
                toolTip1.SetToolTip(btnModificar, "Modificar Objeto");
            }

        #endregion
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string text = OpenModalForm("Agregar Objeto", String.Empty, "Agregar");
            if (text != string.Empty)
            {
                _supermercado.Add(text);
                ActualizarVisor();
            }
            btnAgregar.Focus();
        }
        private string OpenModalForm(string titulo, string texto, string textoBtn)
        {

            AltaBajaModificacion frmABM = new(titulo, texto, textoBtn);
            DialogResult result = frmABM.ShowDialog();
            if (result == DialogResult.OK)
            {
                return frmABM.Objeto;
            }
            else 
                return string.Empty;
        }

        private bool SelectItemList(int indexSelected)
        {
            if (indexSelected < 0)
            {
                MessageBox.Show("Debe Seleccionar un elemento", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (SelectItemList(lstObjetos.SelectedIndex))
            {
                string? text = lstObjetos.SelectedItem?.ToString();
                string txtModal = OpenModalForm("Modificar Objeto", text, "Modificar");
                if (txtModal != string.Empty)
                {
                    _supermercado[lstObjetos.SelectedIndex] = txtModal;
                    ActualizarVisor();
                }
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (SelectItemList(lstObjetos.SelectedIndex))
            {
                int i = lstObjetos.SelectedIndex;
                if (i >= 0)
                {
                    _supermercado.RemoveAt(i);
                    ActualizarVisor();
                }
            }
        }


        private void ActualizarVisor()
        {
            lstObjetos.Items.Clear();
            foreach (string p in _supermercado)
            {
                if (!string.IsNullOrEmpty(p))
                    lstObjetos.Items.Add(p);
            }

        }

        #region Serialize And Closing
            private void FrmAltaModificacion_FormClosing(object sender, FormClosingEventArgs e)
            {

                if(_supermercado is not null)
                {
                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Lista Super");
                    DeserializeClose(Path.Combine(path, "lista.xml"), 1);//0=json 1=xml / .change
                }
            }

            private void DeserializeClose(string path, int i)
            {
                if (i!=1)
                {
               
                    JsonSerializerOptions json = new();
                    json.WriteIndented = true;

                    //
                    string text = JsonSerializer.Serialize(_supermercado, json);

                    File.WriteAllText(path, text);

                }
                else
                {
                    using (XmlTextWriter archive = new(path, Encoding.UTF8))
                    {
                        //objeto para poder escribir en el archivo con el tipo de dato.
                        XmlSerializer guardar = new(typeof(List<string>));

                        //Donde?(archive) y, Que Guardo?(lista de strings).
                        guardar.Serialize(archive, _supermercado);
                    }
                }
            }
        #endregion

    }
}
