using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase002.Ejercicios
{

    #region CONSIGNA DEL EJERCICIO
    /*
    Realizar un programa que sume números enteros hasta que el usuario lo determine
    por medio de un mensaje "¿Desea continuar? (S/N)".

    Crear la clase Validador y el método estático ValidarRespuesta,
    que validará el ingreso de respuestas.

    El método devolverá un valor de tipo booleano,
    TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
    */
    #endregion
    internal class Ejercicio02
    {

        public static void ejecutar()
        {
            Console.Title = "Ejercicio 2 - Desea Continuar? S/N";

            Console.WriteLine("Ingrese Numeros e Indique Si Desea Seguir Agregando, Luego Se Sumaran Los Numeros Ingresados");
            int suma = 0;
            do
            {
                Console.Clear();
               int numero = 0;
               Console.WriteLine("Ingrese Un Numero");
                if (int.TryParse(Console.ReadLine(), out numero)) suma += numero;
                else
                {
                    Console.WriteLine("Error, Solo Se Permiten Datos Numericos");
                    Console.ReadKey(); Console.Clear();
                }
                
            } while (Validador.ValidarRespuesta());
            Console.WriteLine($"La suma de los numeros ingresados es : {suma}");
        }
    }
}
