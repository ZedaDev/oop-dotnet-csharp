using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase6Colecciones
{
    public class Ejercicio5
    {
        public void Ejecutar()
        {
            Console.Title = "Enciendan Motores";

            Console.WriteLine("Bienvenido a la Carrera");

            Competencia carrera = new (11, 22, ECompetencia.F1);
            AutoF1 a = new(11, "Ferrari");
            AutoF1 a1 = new(11, "Ferrari");
            AutoF1 a2 = new(10, "McLaren");
            AutoF1 a4 = new(9, "Mercedez");
            AutoF1 a5 = new(8, "Red Bull");
            Console.WriteLine(a == a1 ? "Auto 1 es igual al Auto 2" : "No Son Iguales");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine( carrera + a ? $"Corredor Agregado a la Carrera : \n{a.MostrarDatos()}" : "Corredor no agregado");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine( carrera + a1 ? $"Corredor Agregado a la Carrera : \n{a1.MostrarDatos()}" : "Corredor no agregado");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine( carrera + a2 ? $"Corredor Agregado a la Carrera : \n{a2.MostrarDatos()}" : "Corredor no agregado");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine( carrera + a4 ? $"Corredor Agregado a la Carrera : \n{a4.MostrarDatos()}" : "Corredor no agregado");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine( carrera + a5 ? $"Corredor Agregado a la Carrera : \n{a5.MostrarDatos()}" : "Corredor no agregado");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");


            Console.WriteLine($"Auto 1 En Competencia? {carrera == a}");
            Console.WriteLine($"Auto En Competencia? {carrera == a1}");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"{carrera.MostrarCorredores()}");
            
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(carrera - a4 ? $"Corredor Quitado {carrera.MostrarCorredores()}" : $"Corredor a4 sigue en competencia");

           
            
        }
    }
}
