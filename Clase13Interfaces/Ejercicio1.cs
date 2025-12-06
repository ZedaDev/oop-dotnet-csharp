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


            //Parte 2

            /*Crear dentro del método Main un objeto del tipo CartucheraMultiuso
             * y otro de CartucheraSimple.

Cargar sus listas de elementos.
Llamar a los métodos RecorrerElementos hasta que alguno de ellos retorne false.
Imprimir por pantalla su retorno.*/


            Lapiz l1 = new Lapiz(10);
            Lapiz l2 = new Lapiz(1);
            Lapiz l3 = new Lapiz(0);
            Lapiz l4 = new Lapiz(11);
            Lapiz l5 = new Lapiz(20);
            Boligrafo b1 = new Boligrafo(ConsoleColor.Green, 11);
            Boligrafo b2 = new Boligrafo(ConsoleColor.White, 1);
            Boligrafo b3 = new Boligrafo(ConsoleColor.Red, 0);
            Boligrafo b4 = new Boligrafo(ConsoleColor.Magenta, 2);
            Boligrafo b5 = new Boligrafo(ConsoleColor.Cyan, 5);

            List<Lapiz> lapices = new();
            lapices.Add(l1);
            lapices.Add(l2);
            lapices.Add(l3);
            lapices.Add(l4);
            lapices.Add(l5);

            List<Boligrafo> boligrafos = new();
            boligrafos.Add(b1);
            boligrafos.Add(b2);
            boligrafos.Add(b3);
            boligrafos.Add(b4);
            boligrafos.Add(b5);

            List<IAcciones> elementos = new();
            elementos.AddRange(lapices);
            elementos.AddRange(boligrafos);

            CartucheraMultiuso cMultiUso = new(elementos);
            CartucheraSimple cSimple = new(boligrafos, lapices);

            Console.WriteLine($"{cMultiUso.RecorrerElementos()}");

            Console.WriteLine("+++++++++++++++++++++++++++++++++++\n");

            Console.WriteLine($"{cSimple.RecorrerElementos()}");

        }
    }
}
