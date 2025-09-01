using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase003
{
    internal class Ejercicio3
    {
        public void ejecutar()
        {
            Console.Title = "Ejercicio 3 - Estudiante Notas";
            StringBuilder datosAlumnos = new StringBuilder();
            do
            {
                Console.WriteLine("Ingrese Nombre Del Estudiante : ");
                string? nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Apellido Del Estudiante : ");
                string? apellido = Console.ReadLine();
                Console.WriteLine("Ingrese Legajo Del Estudiante : ");
                string? legajo = Console.ReadLine();
                Estudiante alumno = new Estudiante(apellido, nombre, legajo);

                Console.WriteLine("Alumno Cargado Con Exito"); Console.WriteLine("Ingrese Notas");
                Console.WriteLine("Primer Parcial : ");
                alumno.SetNotaPrimerParcial(Validador.PedirYValidarNumeroEntero());
                Console.WriteLine("Segundo Parcial : ");
                alumno.SetNotaSegundoParcial(Validador.PedirYValidarNumeroEntero());
                datosAlumnos.AppendLine(alumno.Mostrar());

            } while (Validador.ValidarRespuesta());

            Console.WriteLine(datosAlumnos);
        }

  

    }
}
