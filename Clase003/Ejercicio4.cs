using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;
namespace Clase003
{
    internal class Ejercicio4
    {

        public void ejecutar()
        {
            Console.Title = "Ejercicio 4 - Boligrafo(Pintar,Recargar)";
            Boligrafo boligrafo = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafo1 = new Boligrafo(50, ConsoleColor.Red);

            do
            {
               
                Console.WriteLine($"Tinta actual : {boligrafo1.GetTinta()}");
                Console.WriteLine("Indique cuanto quiere pintar : ");
                int pintar = Validador.PedirYValidarNumeroEntero();
                string dibujo;
                if (boligrafo1.Pintar(pintar, out dibujo))
                {
                    Console.ForegroundColor = boligrafo1.GetColor();
                    Console.WriteLine(dibujo);
                    Console.ResetColor();
                }
               Console.WriteLine("Si Desea continuar, se le recargara la tinta la maximo(100)");
                if (!Validador.ValidarRespuesta()) break;
                else boligrafo1.Recargar();
            } while (true);

        }
    }
}
