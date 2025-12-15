using GenericsC14;

namespace Clase14Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Torneo<EquipoFutbol> torneoFutbol = new("Torneo De Futbol");
            Torneo<EquipoBasquet> torneoBasquet = new("Torneo De Basquet");

            EquipoFutbol e1 = new("EQUIPO1Futbol", DateTime.Now);
            EquipoFutbol e2 = new("EQUIPOFutbol", DateTime.Now);
            EquipoFutbol e3 = new("EQUIPO3Futbol", DateTime.Now);

            EquipoBasquet e_1 = new("EQUIPO1Basquet", DateTime.Now);
            EquipoBasquet e_2 = new("EQUIPO2Basquet", DateTime.Now);
            EquipoBasquet e_3 = new("EQUIPO3Basquet", DateTime.Now);

           _ = torneoBasquet + e_1;
            _ = torneoBasquet + e_2;
            _ = torneoBasquet + e_3;

           _ =  torneoFutbol+ e1;
            _ = torneoFutbol + e2;
            _ = torneoFutbol + e3;

            Console.WriteLine($"{torneoFutbol.Mostrar()}");
            Console.WriteLine($"{torneoBasquet.Mostrar()}");

            Console.WriteLine($"{torneoFutbol.JugarPartido}");
            Console.WriteLine($"{torneoFutbol.JugarPartido}");
            Console.WriteLine($"{torneoFutbol.JugarPartido}");

            Console.WriteLine($"{torneoBasquet.JugarPartido}");
            Console.WriteLine($"{torneoBasquet.JugarPartido}");
            Console.WriteLine($"{torneoBasquet.JugarPartido}");

        }
    }
}
