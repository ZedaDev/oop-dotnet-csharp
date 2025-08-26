using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Utilidades;

namespace Clase002.Ejercicios
{
    internal class Ejercicio5
    {
        /*Crear una aplicación de consola que permita al usuario ingresar un número entero.

        Desarrollar un método estático que reciba un número y 
        devuelva la tabla de multiplicación de ese número en formato string.

        Se deberá utilizar la clase StringBuilder combinada con strings interpolados
        para armar el resultado.

        Mostrar en la consola el resultado.

        Por ejemplo, si se ingresa el número 2 la salida deberá ser:*/
        public static void ejecutar()
        {
            Console.Title = "Aprendete Las Tablas";
            do
            {
                Console.WriteLine($"A Continuacion ingrese un numero y vera su tabla de multiplicar");
                int numero = Validador.PedirYValidarNumeroEntero();
                Console.WriteLine(MuestraResultado(numero));
            } while (Validador.ValidarRespuesta());

        }

        /// <summary>
        /// Mediante StringBuilder, muestra la tabla de multiplicar uno bajo el otro
        /// </summary>
        /// <param name="numero">Numero a Multiplicar</param>
        ///  <returns>Retorna el resultado de la multiplicacion en formato string</returns>
        private static string MuestraResultado(int numero)
        {
            Console.WriteLine($"Tabla De Multiplicar Del {numero}");
            StringBuilder resultado = new StringBuilder();
            for (int i = 0; i < 11; i++)
            {
                int res = numero * i;
                resultado.Append($"{numero} x {i} = {res}").AppendLine();
            }
                string? respuesta = resultado.ToString();
            return respuesta;
        }
    }
}
