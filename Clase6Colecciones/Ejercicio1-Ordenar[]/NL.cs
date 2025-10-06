using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6Colecciones
{
    internal class NL
    {
       
        public static void CargarNumeros(int[] numeros, int cantidad)
        {
            Random random = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = ConverNumPositiveOrNegative(random, 1, 100);
            }
        }

        //Sobrecarga Para Lists.
        public static void CargarNumeros(List<int> numeros, int cantidad)
        {
            Random random = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                numeros.Add(ConverNumPositiveOrNegative(random, 1, 100));
            }
        }
        public static void CargarNumeros(Stack<int> numeros, int cantidad)
        {
            Random random = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                numeros.Push(ConverNumPositiveOrNegative(random, 1, 100));
            }
        }
        public static int ConverNumPositiveOrNegative(Random random, int desde, int hasta)
        {
            int value = random.Next(desde, hasta);
            int convert = random.Next(0, 5) == 0 ? -1 : 1;
            if (convert == -1)
                value = convert* value;

            return value;
        }


        public static string MostrarArray(int[] array)
        {
            StringBuilder sg = new();

            foreach (int numero in array)
            {
                sg.AppendLine($"{numero}");
            }
                return sg.ToString();
        }
        public static string MostrarLista(List<int> numeros)
        {
            StringBuilder sg = new();

            foreach (int numero in numeros)
            {
                sg.AppendLine($"{numero}");
            }
                return sg.ToString();
        }
        public static string MostrarStack(Stack<int> numeros)
        {
            StringBuilder sg = new();

            foreach (int numero in numeros)
            {
                sg.AppendLine($"{numero}");
            }
                return sg.ToString();
        }
    }
}
