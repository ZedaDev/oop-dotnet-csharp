namespace Clase6Colecciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Console.Title = "Numeros Locos";
            Console.WriteLine("Veinte Numeros De Forma Aleatoria, Positivos y Negativos Cargados");

            int[] array1 = new int[20];
            NL.CargarNumeros(array1, 20);
            Console.WriteLine($"Coleccion Original : {NL.MostrarArray(array1)}");

            Array.Sort(array1, CriteryFunction);
            Console.WriteLine($"Positivos Ordenados : {NL.MostrarArray(array1)}");

            Array.Sort(array1, CriteryFunction1);
            Console.WriteLine($"Negativos Ordenados : {NL.MostrarArray(array1)}");*/

            Console.WriteLine("ARRAY, LISTA, PILA CARGANDO..");

            int[] numerosA = new int[20];
            List<int> numerosL = new List<int>();
            Stack<int> numerosS = new Stack<int>();
            NL.CargarNumeros(numerosA, 20); 
            NL.CargarNumeros(numerosL, 20);
            NL.CargarNumeros(numerosS, 20);

            Console.WriteLine($"ARRAY ORIGINAL : {NL.MostrarArray(numerosA)}");
            Array.Sort(numerosA, CriteryFunction);
            Console.WriteLine($"Positivos Ordenados : {NL.MostrarArray(numerosA)}");

            Array.Sort(numerosA, CriteryFunction1);
            Console.WriteLine($"Negativos Ordenados : {NL.MostrarArray(numerosA)}");

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine($"List ORIGINAL:   {NL.MostrarLista(numerosL)} ");
            numerosL.Sort(CriteryFunction);
            Console.WriteLine($"Positivos Ordenados : {NL.MostrarLista(numerosL)}");

            numerosL.Sort(CriteryFunction1);
            Console.WriteLine($"Negativos Ordenados : {NL.MostrarLista(numerosL)}");

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine($"Stack ORIGINAL:  {NL.MostrarStack(numerosS)} ");

            List<int> ints = numerosS.ToList();
            ints.Sort(CriteryFunction);
            Console.WriteLine($"Positivos Ordenados : {NL.MostrarLista(ints)}");

            ints.Sort(CriteryFunction1);
            Console.WriteLine($"Negativos Ordenados : {NL.MostrarLista(ints)}");




        }

        public static int CriteryFunction(int num1, int num2)
        {
            return num2 - num1;//Funcion compare, devuelve 1 si es mayor, -1 si es menor, 0 si son iguales.
        }
        public static int CriteryFunction1(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
