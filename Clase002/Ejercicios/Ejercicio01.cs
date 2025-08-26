using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase002.Ejercicios
{
   
    public class Ejercicio01
    {
        #region CONSIGNA DEL EJERCICIO
        /*Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

        bool Validar(int valor, int min, int max)

        valor: dato a validar.
        min: mínimo valor incluido.
        max: máximo valor incluido.
        Pedir al usuario que ingrese 10 números enteros.
        Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

        Terminado el ingreso :
        mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.*/
        #endregion
        public static void ejecutar()
        {
            Console.Title = "Validar Rango";
            int min = -100;
            int max = 100;
            int valor = 0;
            int valorMin = 0;
            int valorMax = 0;
            float promedio = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese Un Numero : ");
                while (!int.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine("ERROR, debe ingresar un dato numerico");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine($"Ingrese Un Numero Entre {min} y {max} : ");
                }
                if (Validador.Validar(valor, min, max))
                {
                    if(i == 0)
                    {
                        valorMin = valor;
                        valorMax = valor;
                    }
                    else
                    {
                        if (valor < valorMin) valorMin = valor;
                        if (valor > valorMax) valorMax = valor;
                    }
                    promedio += valor;
                }
                else
                {
                    Console.WriteLine("Numero Fuera De Rango, Vuelva a Ingresar El Numero");
                    Console.ReadKey();
                    Console.Clear();
                    i--;
                }
            }
            promedio = promedio / 5;
            Console.WriteLine($"Valor Minimo : {valorMin}\nValor Maximo : {valorMax}\nPromedio Total : {promedio}");
            Console.ReadKey();

        }
    }
    
}
