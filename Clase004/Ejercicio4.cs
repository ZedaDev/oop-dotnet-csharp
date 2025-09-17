using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase004
{
    public class Ejercicio4
    {
        public void Ejecutar()
        {
            // Creo un estante

            Estante estante = new Estante(4, 1);

            // Creo 4 productos
            Producto p1 = new Producto("881971NOA","Don Beto", 10);
            Producto p2 = new Producto("111QEW","Don Adriano", 11);
            Producto p3 = new Producto("1901ASD","CARP", 14);
            Producto p4 = new Producto("ASD213FAS","RiverPlate",18);

            // Agrego los productos al estante
            if (estante + p1)
                Console.WriteLine($"Se Agrego : {p1.GetMarca()} {(string)p1} {p1.GetPrecio()}");
            else
                Console.WriteLine($"NO Se agregó {p1.GetMarca()} {(string)p1} {p1.GetPrecio()}");

            if (estante + p2)
                Console.WriteLine($"Agregó {p2.GetMarca()} {(string)p2} {p2.GetPrecio()}");
            else
                Console.WriteLine($"NO Se agregó {p2.GetMarca()} {(string)p2} {p2.GetPrecio()}");

            if (estante + p3)
                Console.WriteLine($"Agregó {p3.GetMarca()} {(string)p3} {p3.GetPrecio()}");
            else
                Console.WriteLine($"NO Se agregó {p3.GetMarca()} {(string)p3} {p3.GetPrecio()}");

            if (estante + p4)
                Console.WriteLine($"Agregó {p4.GetMarca()} {(string)p4} {p4.GetPrecio()}");
            else
                Console.WriteLine($"NO Se agregó {p4.GetMarca()} {(string)p4} {p4.GetPrecio()}");


            // Muestro todo el estante
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------->");
            Console.WriteLine(Estante.MostrarEstante(estante));
            Console.WriteLine($"Removiendo {(string)p1}"); estante = estante - p1;
            Console.WriteLine($"\nEstante sin {(string)p1}");
            Console.WriteLine(Estante.MostrarEstante(estante));
            Console.WriteLine($"\nEstante sin {(string)p3}"); estante = estante - p3;
            Console.WriteLine(Estante.MostrarEstante(estante));
            Console.WriteLine($"\nEs Igual{(string)p1} a {(string)p4}? {p1 == p4}"); 
            Console.WriteLine($"\n!Es Igual{(string)p1} a {(string)p4}? {p1 != p4}"); 
            Console.ReadKey();
        }
    }
}
