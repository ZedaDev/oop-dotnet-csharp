using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase004
{
    public class Ejercicio3
    {
        public void Ejecutar()
        {
            Console.Title = "Conversor Binario Recargado";

            NumeroBinario nB = "1011";
            NumeroDecimal nD = 11;

            Console.WriteLine($"Numero Binario = {(string)nB}");
            Console.WriteLine($"Numero Decimal = {(Double)nD}");

            // Comparación (==)
            Console.WriteLine($"¿Son iguales? (binario == decimal) : {nB == nD}"); 
            Console.WriteLine($"¿Son diferentes? (binario != decimal) : {nB != nD}");
            
            // Suma binario + decimal (retorna string binario)
            Console.WriteLine($"Suma binario + decimal = {nB + nD}"); 

            // Suma decimal + binario (retorna double)
            Console.WriteLine($"Suma decimal + binario = {nD + nB}");  

            // Resta decimal - binario (retorna double)
            Console.WriteLine($"Resta decimal - binario = {nD - nB}"); 

            // Resta binario - decimal (retorna string binario)
            Console.WriteLine($"Resta binario - decimal = {nB - nD}"); 




            Console.ReadKey();
        }
    }
}

