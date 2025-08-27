using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase002.Ejercicios
{
    internal class Ejercicio9
    {
        public static void ejecutar()
        {
            /*El factorial de un número es una operación que consiste en multiplicar un numero “n” 
             * por todos los números enteros positivos que estén debajo de él, por ejemplo el factorial
             * de 3 es el resultado de multiplicar 3 por 2 por 1.

            En una aplicación de consola, desarrollar un método estático
            que calcule el factorial de un número dado.*/
            Console.Title = "Numero Factorial";
            Console.WriteLine("Ingrese Un Numero y, Se le mostrara el factorial");
            int numero = Validador.PedirYValidarNumeroEntero();
            Console.WriteLine($"Factorial de {numero} = {CalcularFactorial(numero):F2} ");
        }

        /// <summary>
        /// Calcula el factorial de un numero entero
        /// </summary>
        /// <param name="numero">Numero a Calcular</param>
        /// <returns>Retorna un int, el factorial del Numero enviado por argumento</returns>
        private static int CalcularFactorial(int numero)
        {
               return numero = (numero == 0) ? 1 : numero * CalcularFactorial(numero -1);
        }
    }
}
