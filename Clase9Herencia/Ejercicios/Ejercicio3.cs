using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase9Herencia.Ejercicios
{
    public class Ejercicio3
    {
        public void Ejecutar()
        {
            Console.Title = "Enciendan Motores";

            Console.WriteLine("Bienvenido a la Carrera");

            Competencia carrera = new(11, 22,ECompetencia.F1);
            AutoF1 a8 = new(8, "Audi");

            /* MotoCross a = new(11, "Honda", 350);
             AutoF1 a1 = new(11, "Ferrari");
             AutoF1 a2 = new(10, "McLaren");
             AutoF1 a4 = new(9, "Mercedez");
             AutoF1 a5 = new(8, "Red Bull");

             carrera[1] = a;
             Console.WriteLine(a1 == a2 ? "Auto 1 es igual al Auto 2" : "No Son Iguales");
             Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
             Console.WriteLine(carrera + a ? $"Corredor Agregado a la Carrera : \n{a.MostrarDatos()}" : "Corredor no agregado");
             Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
             Console.WriteLine(carrera + a1 ? $"Corredor Agregado a la Carrera : \n{a1.MostrarDatos()}" : "Corredor no agregado");
             Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
             Console.WriteLine(carrera + a2 ? $"Corredor Agregado a la Carrera : \n{a2.MostrarDatos()}" : "Corredor no agregado");
             Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
             Console.WriteLine(carrera + a4 ? $"Corredor Agregado a la Carrera : \n{a4.MostrarDatos()}" : "Corredor no agregado");
             Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
             Console.WriteLine(carrera + a5 ? $"Corredor Agregado a la Carrera : \n{a5.MostrarDatos()}" : "Corredor no agregado");
             Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");


             Console.WriteLine($"Auto 1 En Competencia? {carrera == a}");
             Console.WriteLine($"Auto En Competencia? {carrera == a1}");
             Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
             Console.WriteLine($"{carrera.MostrarCorredores()}");

             Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
             Console.WriteLine(carrera - a4 ? $"Corredor Quitado {carrera.MostrarCorredores()}" : $"Corredor a4 sigue en competencia");

             */
            /*EXCERSICE 4 EXCEPCIONES MAIN MODIFICATED*/
            try
            {
                 bool ok = carrera == a8;    

            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine($"{e.ToString()}");
                Exception inner = e.InnerException;

                while (inner is not null)
                {
                    Console.WriteLine($"{e.ToString()}");
                    inner = inner.InnerException;
                }
            }
        }
    }
}
