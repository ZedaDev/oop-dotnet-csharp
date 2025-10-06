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
            if (string.IsNullOrWhiteSpace(rtb.Text))
            {
                //cuento las palabras y lleno el atributo diccionario de la clase.
                ContarPalabras(rtb.Text);

                //MessageBox.Show(Mostrar()); <------ CONTINUED
            }
        }

        private void ContarPalabras(string texto)
        {
            char[] separador = { ' ', ',', '.', ';', '\t', ':' };
            _palabrasList.AddRange(texto.Split(separador, StringSplitOptions.RemoveEmptyEntries));
            //Remuevo los char seleccionados, y remuevo las entradas vacias.
            //split retorna un array de string, AddRange los guarda string a string en la lista de strings.


            foreach (string value in _palabrasList)
            {
                if (!_palabras.ContainsKey(value) && value != " ")
                {
                    _palabras.Add(value, 1);
                }
                else _palabras[value] += 1;
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

                if (string.IsNullOrWhiteSpace(eliminar))
                {
                    if (_palabras.Remove(eliminar)) i += 1;
                }

            }

            return sb.ToString();
        }
    }
}
