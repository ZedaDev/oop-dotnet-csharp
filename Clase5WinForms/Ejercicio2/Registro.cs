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
            //TODO :  Asigna valores de los controles a variables locales
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            int edad = (int)numericEdad.Value;
            string genero = (rBMale.Checked) ? "Masculino" : rBFemale.Checked ? "Femenino" : "Otro";
            string pais = listBoxPais.Text;
            //Sobrecargas del metodo CheckboxValidate(), para sacar la cantidad de controles tipo checkboxs
            //y pasandole la cantidad por parametro, devuelve el array de string cargado o null.
            int cantidad = CheckcboxValidate();
            string[] cursos = CheckcboxValidate(cantidad);

            //TODO : Instancia el objeto Ingresante y, Lo Muestra con MB.Show().
            Ingresante persona = new(cursos, direccion, edad, genero, nombre, pais);
            string mensaje = persona.mostrar();
            MessageBox.Show(mensaje,"Datos",MessageBoxButtons.OK);
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
