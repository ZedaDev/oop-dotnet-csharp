using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades_8;

namespace Clase13Interfaces
{
    public class Ejercicio1
    {
        public void Ejecutar()
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

        /*Creo un dos objetos, tipo Lapiz y, Boligrafo */
            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(ConsoleColor.Green, 20);

        /*Creo el objeto para escribir, casteando Lapiz a [Interface]
         para poder acceder al metodo declarado explicitamente*/
            EscrituraWrapper wrapperLapiz = ((IAcciones)miLapiz).Escribir("Hola Soy un lapiz");
            Console.ForegroundColor = wrapperLapiz._color;
            Console.WriteLine(wrapperLapiz._texto);

            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz.ToString());

            /*Creo el objeto para escribir, al definir los metodos de la [Interface]
             de manera implicita en Boligrafo, no hace falta hacer el casteo
            los reconoce como del objeto*/
            EscrituraWrapper wrapperBoligrafo = miBoligrafo.Escribir("Hola soy un boligrafo");
            Console.ForegroundColor = wrapperBoligrafo._color;
            Console.WriteLine(wrapperBoligrafo._texto);

            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo.ToString());

            Console.ReadKey();
        }
    }
}
