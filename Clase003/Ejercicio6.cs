using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase003
{
    internal class Ejercicio6
    {

        public void ejecutar()
        {
            Console.Title = "Estadisticas Conductores";
            Console.WriteLine("cargue tres conductores, luego se le mostrara Los dias con mas kms");

            Conductor[] conductores = new Conductor[3];
            int j = 0;
            do
            {
                Console.WriteLine("Nombre : ");
                string? nombre = Console.ReadLine();
                while (!Validador.ValidarString(nombre))
                {
                    Console.WriteLine("Incorrecto Reingrese Nombre");
                    nombre = Console.ReadLine();
                }
                Conductor conductor = new Conductor(nombre);

                Console.WriteLine($"Kms Por Dia De La Semana {nombre} : ");

                ProgramaConductor.CargarKmsPorDia(conductor.GetKmsDays());
                conductores[j++] = conductor; 

            }while(j<3);

            Console.WriteLine(ProgramaConductor.DriverStats(conductores));
            Console.WriteLine(ProgramaConductor.MaxKmdPorDia(conductores, 1)); 
            Console.WriteLine(ProgramaConductor.MaxKmdPorDia(conductores, 3));
           
        }
    }
}
