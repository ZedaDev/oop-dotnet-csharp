
namespace Clase6Colecciones
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region EJERCICIO 1 - NUMEROS LOCOS
            /* Console.Title = "Numeros Locos";
            Console.WriteLine("Veinte Numeros De Forma Aleatoria, Positivos y Negativos Cargados");

            int[] array1 = new int[20];
            NL.CargarNumeros(array1, 20);
            Console.WriteLine($"Coleccion Original : {NL.MostrarArray(array1)}");

            Array.Sort(array1, CriteryFunction);
            Console.WriteLine($"Positivos Ordenados : {NL.MostrarArray(array1)}");

            Array.Sort(array1, CriteryFunction1);
            Console.WriteLine($"Negativos Ordenados : {NL.MostrarArray(array1)}");*/
            #endregion

            #region EJERCICIO 2 NUMEROS LOCOS PARTE 2

            /*Console.WriteLine("ARRAY, LISTA, PILA CARGANDO..");

            int[] numerosA = new int[20];
            List<int> numerosL = new List<int>();
            Stack<int> numerosS = new Stack<int>();
            NL.CargarNumeros(numerosA, 20); 
            NL.CargarNumeros(numerosL, 20);
            NL.CargarNumeros(numerosS, 20);

            Console.WriteLine($"ARRAY ORIGINAL : \n{NL.MostrarArray(numerosA)}");
            Array.Sort(numerosA, CriteryFunction);
            Console.WriteLine($"Positivos Ordenados : \n{NL.MostrarArray(numerosA)}");

            Array.Sort(numerosA, CriteryFunction1);
            Console.WriteLine($"Negativos Ordenados : \n{NL.MostrarArray(numerosA)}");

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine($"List ORIGINAL:   \n{NL.MostrarLista(numerosL)} ");
            numerosL.Sort(CriteryFunction);
            Console.WriteLine($"Positivos Ordenados : \n{NL.MostrarLista(numerosL)}");

            numerosL.Sort(CriteryFunction1);
            Console.WriteLine($"Negativos Ordenados : \n{NL.MostrarLista(numerosL)}");

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine($"Stack ORIGINAL:  \n{NL.MostrarStack(numerosS)} ");

            List<int> ints = numerosS.ToList();
            ints.Sort(CriteryFunction);
            Console.WriteLine($"Positivos Ordenados : \n{NL.MostrarLista(ints)}");

            ints.Sort(CriteryFunction1);
            Console.WriteLine($"Negativos Ordenados : \n{NL.MostrarLista(ints)}");*/
            #endregion

            Ejercicio4 ejercicio4 = new Ejercicio4();
            ejercicio4.Ejecutar();


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
