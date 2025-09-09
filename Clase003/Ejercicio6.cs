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
        #region CONSIGNA
        /*De una empresa de transporte de cargas se quiere guardar el nombre de los conductores
         * y los kilómetros que conducen cada día de la semana.

    Para guardar esta información, la empresa de transporte tendrá un array de conductores.

    De cada conductor se tendrá la siguiente información:

    Nombre del conductor.
    Kilometros recorridos por cada día de la semana. Por ejemplo:
    Día 1: 200
    Día 2: 599
    Día 3: 899
    Día 4: 0 (tiene franco)
    Día 5: 256
    Día 6: 0
    Día 7: 0
    Consigna
    Desarrollar las clases y métodos necesarios. Toda la lógica de negocio deberá estar
        encapsulada en clases y dentro de un proyecto de tipo biblioteca de clases.

    Crear un proyecto de consola y en el método Main cargar 3 conductores
        a la empresa de transportes.

    Luego mostrar:

    El conductor que hizo más km en esa semana.
    El conductor que hizo más km el día 3.
    El conductor que hizo más km el día 5.*/
        #endregion
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
