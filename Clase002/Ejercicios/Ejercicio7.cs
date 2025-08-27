using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase002.Ejercicios
{
    internal class Ejercicio7
    {
        public static void ejecutar()
        {

            /*
        Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.

        El programa deberá calcular la longitud de la hipotenusa
         aplicando el teorema de pitágoras 

        Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

        Mostrar el resultado en la consola.     */

            Console.Title = "Teorema De Pitagoras";
            Console.WriteLine("A continuacion ingrese la base y la altura del triangulo y, se le indicara la hipotenusa");
            Console.WriteLine("Base : ");
            int bas = Validador.PedirYValidarNumeroEntero();
            Console.WriteLine("Altura : ");
            int alt = Validador.PedirYValidarNumeroEntero();

            Console.WriteLine($"Hipotenusa Del Triangulo : {SacarRaizCuadradaTriangulo(bas, alt):F2}");
        }

        private static double SacarRaizCuadradaTriangulo(int bas, int altura)
        {
            return Math.Sqrt(Math.Pow(bas, 2) + Math.Pow(altura, 2));
        }
    }
}
