using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;
namespace Clase5WinForms
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }



        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            int edad = (int)numericEdad.Value;
            string genero = (rBMale.Checked) ? "Masculino" : rBFemale.Checked ? "Femenino" : "Otro";
            string pais = listBoxPais.Text;
            int cantidad = CheckcboxValidate();
            string[] cursos = CheckcboxValidate(cantidad);

            Ingresante persona = new(cursos, direccion, edad, genero, nombre, pais);
            string mensaje = persona.mostrar();
            MessageBox.Show(mensaje,"Datos",MessageBoxButtons.OK);
            this.Show();
        }

        private int CheckcboxValidate()
        {
            int i = 0;
            foreach (Control ctrl in groupBCursos.Controls)
            {
                if (ctrl is CheckBox checkbox && checkbox.Checked)
                {
                    i++;
                }
            }
            return i;
        }
        private string[] CheckcboxValidate(int cantidad)
        {

            string[] cursos = new string[cantidad];
            int j = 0;
               foreach(Control ctrl in groupBCursos.Controls)
            {
                if(ctrl is CheckBox checkbox && checkbox.Checked)
                {
                    cursos[j++] = ctrl.Text; 
                }
            }
            return cursos;
        }
    }
}
