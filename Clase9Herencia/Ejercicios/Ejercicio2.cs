using Clase9Herencia.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades_8;
using Utilidades;

//Using para evitar ambinguedades entre clases y librerias.
using Persona = Utilidades_8.Persona;
using Jugador = Clase9Herencia.Clases.Jugador;

namespace Clase9Herencia.Ejercicios
{
    public class Ejercicio2
    {

        public void Ejecutar()
        {
            Console.Title = "Herencia Deportiva";

            Persona player = new Jugador(11, "Don Adriano", 11, 8);
            DateTime dato = new(1918, 9, 18);
            Persona dT = new DirectorTecnico("Angel Labruna", dato);
            Persona dT1 = new DirectorTecnico("Angel Labruna", dato);

            if(((DirectorTecnico)dT) == ((DirectorTecnico)dT1))
            {
                Console.WriteLine("DTS SON IGUALES");
            }

            Team team = new(11, "River Plate", (DirectorTecnico)dT);

            if(team + ((Jugador)player))
            {
                Console.WriteLine($"JUGADOR AGREGADO : {((Jugador)player).MostrarDatos()}");
                Console.WriteLine($"Director Tecnico : {dT.MostrarDatos()}\nFecha Nac. : {((DirectorTecnico)dT).FechaNacimiento} ");
            }
        }
    }
}
