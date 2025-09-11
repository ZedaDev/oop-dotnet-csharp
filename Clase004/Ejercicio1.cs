using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase004
{
    internal class Ejercicio1
    {

        public void Ejecutar()
        {
            Console.Title = "Ejercicio 1 - Sumador";
            Sumador sumador = new Sumador(11);
            Sumador sumador1 = new Sumador(11);

            long cantidadSumas = sumador + sumador1;
                Console.WriteLine($"Cantidad de sumas Ambos Sumadores : {cantidadSumas}\n Mismas Sumas : {sumador | sumador1}");
            //Console.WriteLine($"Resultado : {sumador.Sumar(90, 92)}  Concatenacion : {sumador.Sumar("90", "92")}");
        }
    }
}
