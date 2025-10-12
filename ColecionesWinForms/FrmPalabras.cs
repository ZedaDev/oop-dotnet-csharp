using System.Text;

namespace ColecionesWinForms
{
    public partial class FrmPalabras : Form
    {
        private Dictionary<string, int> _palabras;
        private List<string> _palabrasList;
        public FrmPalabras()
        {
            InitializeComponent();
            _palabras = new Dictionary<string, int>();
            _palabrasList = new List<string>();
        }

       private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtb.Text.Trim()))
            {
                //cuento las palabras y lleno el atributo diccionario de la clase.
                ContarPalabras(rtb.Text.Trim());

                MessageBox.Show(Mostrar(),"TOP 3", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtb.Clear(); rtb.Focus();
            }
        }

        private void ContarPalabras(string texto)
        {
            char[] separador = { ' ', ',', '.', ';', '\t', ':'};

            _palabras.Clear();
            _palabrasList.Clear();

            _palabrasList.AddRange(texto.Split(separador, StringSplitOptions.RemoveEmptyEntries));
            //Split separa los strings segun el array separador de char, y remuevo las entradas vacias.
            //split retorna un array de string, AddRange los guarda string a string en la lista de strings.

            HashSet<string> words = new()//coleccion de unico tipo de Dato, no admite repetidos.
            { "el", "la", "por", "su", "es", "las", "los", "un", "a", "de", "del", "en", "y", "con", "una" };


            foreach (string value in _palabrasList)
            {
                if (!words.Contains(value) && value != " ")
                {
                    if(!_palabras.ContainsKey(value))
                        _palabras.Add(value, 1);
                    else
                        _palabras[value] += 1;
                }
               
            }
        }

        private string Mostrar()
        {
            StringBuilder sb = new();
            int i = 0;
            string eliminar = " ";

            while (i<3)
            {
                foreach(KeyValuePair<string, int> element in _palabras)
                {
                    if(_palabras.Values.Max() == element.Value)
                    {
                        eliminar = element.Key;//tKey del Dictionary de tipo string.
                        sb.AppendLine($"{eliminar} {element.Value}");
                        break;
                    }
                }

                    if (_palabras.Remove(eliminar)) i += 1;
                /*if (string.IsNullOrWhiteSpace(eliminar))
                {
                }*/

            }

            return sb.ToString();
        }
    }
}
