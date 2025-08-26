using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase002.Ejercicios
{
    internal class Calculadora
    {

        /*            Calcular (público): Recibirá tres parámetros, el primer operando,
            el segundo operando y la operación matemática. El método devolverá el resultado
            de la operación.

              Validar (privado): Recibirá como parámetro el segundo operando.
            Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
            Este método devolverá true si el operando es distinto de cero.

              Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar
            (ingresando el caracter +, -, * o /).*/

        /// <summary>
        /// Calculadora Basica, Ingrese dos numeros y, luego la operacion a usar.
        /// </summary>
        /// <param name="operando">Pimer Numero</param>
        /// <param name="operando2">Segundo Numero</param>
        /// <param name="operacionMatematica">Operacion Matematica('+' '-' '*' '/')</param>
        /// <returns>Retorna el Resultado entre ambos numeros segun la operacion elegida. Si eligio la operacion dividir(/) y envio el segundo numero como 0. retornara 0.</returns>
        public static int Calcular(int operando, int operando2, string operacionMatematica)
        {
            int resultado = 0;
            switch (operacionMatematica)
            {
                case "/":
                    if (ValidarDistintoQue0(operando2))
                        resultado = operando / operando2;
                    break;
                case "+":
                    resultado = operando + operando2;
                    break;
                case "-":
                    resultado = operando - operando2;
                    break;
                case "*":
                    resultado = operando * operando2;
                    break;
            }
            return resultado;
        }

        private static bool ValidarDistintoQue0(int operando)
        {
            return (operando != 0);
        }
    }
}
