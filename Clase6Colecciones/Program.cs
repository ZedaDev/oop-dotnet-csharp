namespace Clase6Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Numeros Locos";
            Console.WriteLine("Veinte Numeros De Forma Aleatoria, Positivos y Negativos Cargados");

            int[] array1 = new int[20];
            NL.CargarNumeros(array1 ,20);
            Console.WriteLine($"Coleccion Original : {NL.MostrarArray(array1)}");

            Array.Sort(array1, CriteryFunction);
            Console.WriteLine($"Positivos Ordenados : {NL.MostrarArray(array1)}");

            Array.Sort(array1, CriteryFunction1);
            Console.WriteLine($"Negativos Ordenados : {NL.MostrarArray(array1)}");


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
