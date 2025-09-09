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

            Sumador sumador = new Sumador();

            Console.WriteLine($"Resultado : {sumador.Sumar(90, 92)}  Concatenacion : {sumador.Sumar("90", "92")}");
        }
    }
}
