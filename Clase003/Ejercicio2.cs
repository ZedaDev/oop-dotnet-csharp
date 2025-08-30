using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase003
{
    internal class Ejercicio2
    {
        public void ejecutar()
        {
            Console.Title = "Mayor De Edad";

            Console.WriteLine("Ingrese Datos de las personas y, se le indicara quien es mayor de edad");
                   StringBuilder personas = new StringBuilder();
                  for(int i = 0; i < 3; i++)
                   {
                        Persona persona = CrearPersona();
                        personas.AppendLine($"{persona.MostrarPersona()}\n {persona.EsMayorEdad().ToString()}\n");
                   }
            Console.WriteLine(personas.ToString());
        }

        
        private Persona CrearPersona()
        {
            
            Console.WriteLine("Ingrese Su Nombre, Dni y, Fecha De Nacimiento");
            Console.WriteLine("Dni : ");
            int dni = Validador.PedirYValidarNumeroEntero();
            Console.WriteLine("Año De Nacimiento : ");
            int año = Validador.PedirYValidarNumeroEntero();
            Console.WriteLine("Mes De Nacimiento (En Numero) : ");
            int mes = Validador.PedirYValidarNumeroEntero();
            Console.WriteLine("Dia De Nacimiento (En Numero) : ");
            int dia = Validador.PedirYValidarNumeroEntero();
            Console.WriteLine("Nombre : ");
            string nombre = Console.ReadLine();
            DateTime fechaNac = new DateTime(año, mes, dia);
            Persona persona = new Persona(nombre, fechaNac, dni);

            Console.WriteLine($"Persona Cargada Con Exito");
            Console.WriteLine("Continue Ingresando Personas");
            Console.ReadKey(); Console.Clear();
            return persona;
        }
    }
}
