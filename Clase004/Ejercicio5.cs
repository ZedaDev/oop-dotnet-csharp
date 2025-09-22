using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase004
{
    public class Ejercicio5
    {
        public void Ejecutar()
        {
            Fahrenheit f = new Fahrenheit(0);      // 32 F = 0 C
            Celcius c = new Celcius(0);             // 0 C = 32 F
            Kelvin k = new Kelvin(0);          // 273.15 K = 0 C

            // 🔁 Conversiones Console.WriteLine("===== CONVERSIONES =====");
            // 🔁 Conversiones
            Console.WriteLine($"F -> C: {((Celcius)f).GetTemperatura()} °C");
            Console.WriteLine($"C -> F: {((Fahrenheit)c).GetTemperatura()} °F");
            Console.WriteLine($"F -> K: {((Kelvin)f).GetTemperatura()} K");
            Console.WriteLine($"K -> F: {((Fahrenheit)k).GetTemperatura()} °F");
            Console.WriteLine($"C -> K: {((Kelvin)c).GetTemperatura()} K");
            Console.WriteLine($"K -> C: {((Celcius)k).GetTemperatura()} °C");

            Console.WriteLine("\n===== Operadores de comparación =====");
            Console.WriteLine($"f == c: {c == f}");
            Console.WriteLine($"c == k: {c == k}");
            Console.WriteLine($"f == k: {f == k}");

            Console.WriteLine("\n===== Operadores aritméticos =====");
            Console.WriteLine($"f - c: {f - c}");
            Console.WriteLine($"c + k: {c + k}");
            Console.WriteLine($"k - f: {k - f}");

            Console.ReadKey();
        }
    }
}
