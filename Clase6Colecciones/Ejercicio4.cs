using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase6Colecciones
{
    public class Ejercicio4
    {
        public void Ejecutar()
        {

            Console.Title = "Estadistica Deportiva";

            Equipo team = new Equipo(11, "River Plate");

            Jugador j = new(11, "Don", 11, 8);
            Jugador j1 = new(11, "DonDon", 11, 5);
            Jugador j2 = new(111, "DonDon", 11, 5);

            if (team + j)
                Console.WriteLine(j.MostrarDatos());

            if (team + j1)
                Console.WriteLine(j1.MostrarDatos());
            else
                Console.WriteLine($"NO SE AGREGO \n{j1.MostrarDatos()}");

            if (team + j2)
                Console.WriteLine(j2.MostrarDatos());


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
