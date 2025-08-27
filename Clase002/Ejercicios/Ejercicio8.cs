using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase002.Ejercicios
{
    internal class Ejercicio8
    {
        public static void ejecutar()
        {
            /*Crear un método estático que reciba una fecha
             * y calcule el número de días que pasaron desde esa fecha hasta la fecha actual.
             * Tener en cuenta los años bisiestos.

             Pedir por consola la fecha de nacimiento de una persona (día, mes y año)
             y calcule el número de días vividos por esa persona hasta la fecha actual
             utilizando el método desarrollado anteriormente.*/
            Console.Title = "Calcular Tiempo Entre Fechas";

            Console.WriteLine("Ingrese el dia, mes y, año de la fecha\n se le calculara los dias pasados hasta la actualidad");
            int dia = Validador.PedirYValidarNumeroEntero();
            int mes = Validador.PedirYValidarNumeroEntero();
            int año = Validador.PedirYValidarNumeroEntero();
            CalcularFecha(dia, mes, año);
            
        }

        private static void CalcularFecha(int dia, int mes, int año)
        {
            DateTime fecha = new DateTime(año, mes, dia);
            TimeSpan resultado = DateTime.Now - fecha;
            Console.WriteLine($"{dia}/{mes}/{año} al {DateTime.Now}");
            Console.WriteLine($"Dias Que Han Pasado : {resultado.Days}");
            Console.WriteLine($"Horas Que Han Pasado : {resultado.TotalHours:F2}");
            Console.WriteLine($"Minutos Que Han Pasado : {resultado.TotalMinutes:F2}");

        }
    }
}
