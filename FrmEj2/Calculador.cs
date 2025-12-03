using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmEj2
{
    /*Crear una clase estática llamada Calculador con un metodo estático Calcular
     * que recibe dos enteros y retorna su división tener en cuenta
     * que las división por cero lanza una excepción, controlarla.*/
    public static class Calculador
    {

        static Calculador()
        {

        }

        public static int Calcular(int number1, int number2)
        {
            int res = 0;
            try
            {
                res = number1 / number2;
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show(e.Message, "No se puede dividir por 0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Console.WriteLine($"{e.Message} - No se puede dividir por 0");
            }

            return res;
        }

    }
}
