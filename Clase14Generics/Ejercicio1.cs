using GenericsC14.E1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14Generics
{
    public class Ejercicio1
    {

        public void Ejecutar()
        {


            //Inicializo los torneos
            Torneo<EquipoFutbol> torneoFutbol = new("Torneo De Futbol");
            Torneo<EquipoBasquet> torneoBasquet = new("Torneo De Basquet");


            //Inicializo los equipos
            EquipoFutbol e1 = new("EQUIPO1Futbol", DateTime.Now);
            EquipoFutbol e2 = new("EQUIPOFutbol", DateTime.Now);
            EquipoFutbol e3 = new("EQUIPO3Futbol", DateTime.Now);

            EquipoBasquet e_1 = new("EQUIPO1Basquet", DateTime.Now);
            EquipoBasquet e_2 = new("EQUIPO2Basquet", DateTime.Now);
            EquipoBasquet e_3 = new("EQUIPO3Basquet", DateTime.Now);


            //agregar equipos a los torneos
            _ = torneoBasquet + e_1;
            _ = torneoBasquet + e_2;
            _ = torneoBasquet + e_3;

            _ = torneoFutbol + e1;
            _ = torneoFutbol + e2;
            _ = torneoFutbol + e3;

            //Mostrar Torneos y, Sus equipos
            Console.WriteLine($"{torneoFutbol.Mostrar()}");
            Console.WriteLine($"{torneoBasquet.Mostrar()}");

            //Simular Partidos
            Console.WriteLine($"{torneoFutbol.JugarPartido}");
            Console.WriteLine($"{torneoFutbol.JugarPartido}");
            Console.WriteLine($"{torneoFutbol.JugarPartido}");

            Console.WriteLine($"{torneoBasquet.JugarPartido}");
            Console.WriteLine($"{torneoBasquet.JugarPartido}");
            Console.WriteLine($"{torneoBasquet.JugarPartido}");
        }
    }
}
