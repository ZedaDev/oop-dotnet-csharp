using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Clase5WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            // Validar que no estén vacíos
            if (string.IsNullOrEmpty(this.textBox1.Text) || string.IsNullOrEmpty(this.textBox2.Text))
            {
                MessageBox.Show("Debe ingresar Nombre y/o Apellido", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                    Saludar saludo = new("¡Hola, Windows Forms!", $"Soy {this.textBox1.Text} {this.textBox2.Text}");
                //this.Hide(); //Oculta el anterior formulario
                saludo.ShowDialog(); //Muestra el nuevo formulario, sin poder ir al anterior.
                this.Show(); //al cerrarse el formulario, vuelve a mostrar el oculto del Hide().

            }

            /*DialogResult result = MessageBox.Show("¡Hola, Windows Forms!", "Saludos!");

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("YES APRETADO");
            }
            else MessageBox.Show("NO APRETADO");*/
        }
    }
}
