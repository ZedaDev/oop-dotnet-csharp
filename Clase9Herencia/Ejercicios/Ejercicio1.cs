using Clase9Herencia.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Clase9Herencia.Ejercicios
{
    public class Ejercicio1
    {
        public void Ejecutar()
        {
            Console.Title = "Viajar Es Un Placer";

            VehiculoTerrestre v = new Moto(2, 0, Colores.Rojo, 250);
            VehiculoTerrestre v2 = new Automovil(4,2,Colores.Blanco, 6, 4);
            VehiculoTerrestre v1 = new Camion(8,2,Colores.Blanco, 6, 3500);

            Console.WriteLine($"{((Camion)v1).MostrarCamion()}"); 
            Console.WriteLine($"{((Automovil)v2).MostrarAutomovil()}"); 
            Console.WriteLine($"{((Moto)v).MostrarMoto()}"); 
        }
    }
}
