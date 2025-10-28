using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades_8;

namespace Clase9Herencia.Ejercicios
{
    public class EjercicioPreParcial
    {
        public void Ejecutar()
        {

            Console.Title = "Lavadero Heredado";

               float priceCar = (float)EVehiculos.Auto;
               float priceMotorBike = (float)EVehiculos.Moto;
               float priceCamion = (float)EVehiculos.Camion;
               Lavadero l = new Lavadero(priceCar, priceMotorBike, priceCamion);
               Vehiculo v =  new Auto(4, "AVZ 011", 4, EMarcas.Fiat);
               Vehiculo v1 = new Auto(2, "001", 4, EMarcas.Ford);
               Vehiculo v2 = new Moto(200, "002", 2, EMarcas.Honda);
               Vehiculo v3 = new Camion(1500, "003", 6, EMarcas.Ford);
               if(l + v)
               {
                   Console.WriteLine("Vehiculo 1 Agregado");
               }
               if(!(l + v))
               {
                   Console.WriteLine("\nVehiculo 1 YA EXISTE EN EL LAVADERO\n");
               }
               if(l + v1)
               {
                   Console.WriteLine("Vehiculo 2 Agregado");
               }

               if (l - v1)
               {
                   Console.WriteLine("Vehiculo 2 REMOVE");
               }


               if (l + v2)
               {
                   Console.WriteLine("Vehiculo 3 Agregado");
               }
               if(l + v3)
               {
                   Console.WriteLine("Vehiculo 4 Agregado");
               }else Console.WriteLine("ERROR CAMION");

               Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");

               Console.WriteLine($"\nVEHICULOS EN EL LAVADERO {l.Vehiculos.Count} :\n{l.Detalle}");

               Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");

               Console.WriteLine($"\nGANANCIAS TOTALES : \n{l.MostrarTotalFacturado()}");
            Console.WriteLine("++++++++++++++++++++++++");

            l.Vehiculos.Sort(l.OrdenarVehiculosPorMarca);
            Console.WriteLine($"{l.Detalle}"); 

            Console.WriteLine("++++++++++++++++++++++++");
            l.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
            Console.WriteLine($"{l.Detalle}"); 
        }
    }
}
