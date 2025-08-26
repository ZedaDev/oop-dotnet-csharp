

namespace Clase001
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //Ejercicio1MinimoMaximo();
            //Ejercicio2ErrorAlCubo();
            //Ejercicio3NumPrim();
            //Ejercicio4NumeroPerfecto();
            
            

        }
        static void Ejercicio4NumeroPerfecto()
        {
            /*Consigna
            Un número perfecto es un entero positivo, que es igual a la suma de todos
            los enteros positivos (excluido el mismo) que son divisores del número.

            El primer número perfecto es 6,
            ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

            Escribir una aplicación que encuentre los 4 primeros números perfectos.*/

            int numero = 2;
            int encontrados = 0;
            int suma;
            while (encontrados < 4) ///ciclo para encontrar los primeros 4 numeros perfectos
            {
                suma = 0; ///reinicio la suma en cada iteracion del while
                for (int i = 1; i < numero; i++)
                {
                    if(numero <= 1)
                    {
                        break;
                    }
                    if(numero % i == 0) ///si numero divido i es igual a 0, es un divisor, 
                    {
                        suma += i; /// incremento la suma para sacar la cuenta final
                    }
                }
                if (suma == numero) ///si lasuma de los divisores es igual al numero, es perfecto
                {
                    Console.WriteLine($"Numero perfecto : {numero}");
                    encontrados++;///incremento encontrados, la consigna pide 4 numeros perfectos.
                }
                numero++;///incremento numero para seguir iterando.
            }
            /*Logica final:
             encapsulo un for en un while, el while va iterando el numero
            el for, es el que dictamina si el numero es perfecto
            al salir del for, si la suma de los divisores es igual al numero, es perfecto
            luego incremento el numero para seguir buscando, vuelve a iterar el while y,
            la suma se reinicia a 0 para la nueva suma del nuevo numero iterado.
            */


        }
        static void Ejercicio3NumPrim()
        {
            /*Mostrar por pantalla todos los números primos
             que haya hasta el número que ingrese el usuario por consola.
                Validar que el dato ingresado por el usuario sea un número.

            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
                Si ingresa "salir", cerrar la consola.

            Al finalizar, preguntar al usuario si desea volver a operar.
            Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.

            Importante
            Utilizar sentencias de iteración, selectivas y el operador módulo (%).
             */

            /*                 -----EXPLICACION------
             Un numero primo solo es divisible por dos numeros, por el 1 y por si mismo
            si dividido por otro numero da resto(%) 0 entonces no es primo por que estaria
            siendo divisible por tres numeros.
            Al ingresar un un numero(5), deberia mostrar,  2 y 3.
            ya que hasta el cinco, 1x2=2 , 2x2=2 , y 1x3=3, 3x1=3.
            siempre son los numeros que solo dan como resto(%) 0 al dividirlo por 1 o por si mismo.
            ejemplo: 4(no es primo) es divisible por 1, 1x4=4, por 2, 2x2=4 y por 4, 4x1=4
            ejemplo: 5(si seria primo) es divisible solo por 1 y por si mismo(5)
                1x5=5, 5x1=5.
             */

            Console.Title = "Ejercicio 3 - Numeros Primos";
            Console.WriteLine("A continuacion ingrese un numero, luego se le mostrara los numeros primos existentes hasta el numero ingresado.");
            int numero = 0;
            string? option;
            bool esPrim;
            do
            {
                Console.WriteLine("Ingrese Un Numero");
                if (int.TryParse(Console.ReadLine(), out numero) && numero > 0)
                {
                    for (int iterador = 2; iterador < numero; iterador++)
                    {
                        esPrim = true;
                        for (int j = 2; j < iterador; j++)
                        {
                            if (iterador % j == 0)
                            {
                                esPrim = false;
                                break;
                            }
                        }
                        if (esPrim)
                        {
                            Console.WriteLine($"Numero Primo : {iterador}");
                        }
                    }

                }
                else
                {
                    Console.WriteLine($"ERROR, debe ingresar un dato numerico o un numero mayor a 0");
                }
                Console.WriteLine("Digite \"salir\" para terminar el programa o \"continuar\" para intentar nuevamente");
                option = Console.ReadLine();
                Console.Clear();
                       
            } while (option != "salir");
        }
        static void Ejercicio2ErrorAlCubo()
        {
            /*
             Ingresar un número y mostrar el cuadrado y el cubo del mismo.
                Se debe validar que el número sea mayor que cero, caso contrario,
                mostrar el mensaje: "ERROR. ¡Reingresar número!".
                 Importante :
                    Utilizar el método Pow de la clase Math para calcular las potencias.
             */
            Console.Title = "Ejercicio 2 - Error Al Cubo";
            int numero;
            int numeroAlCuadrado;
            int numeroAlCubo;
            ConsoleKey tecla = ConsoleKey.Enter;
            Console.WriteLine("A Continuacion ingrese un numero, se le indicara la potencia, al Cuadrado y, al Cubo");
            do
            {
                Console.WriteLine("Ingrese un Numero");

                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero <= 0)
                    {
                        Console.WriteLine("ERROR, debe ingresar un numero mayor a 0");
                    }
                    else
                    {
                        numeroAlCuadrado = (int)Math.Pow(numero, 2); ///Math.pow devuelve un double, necesita casteo a un int.
                        numeroAlCubo = (int)Math.Pow(numero, 3);
                        Console.WriteLine($@"
                        Numero Ingresado : {numero}
                        Numero Al Cuadrado : {numeroAlCuadrado}
                        Numero Al Cubo : {numeroAlCubo}"); // Tambien puede usarse : \n o tres writeline 
                    }
                }
                else Console.WriteLine("ERROR, Debe ingresar un dato numerico");

                    Console.WriteLine("PRESIONE ESC SI DESEA SALIR U OTRA TECLA PARA CONTINUAR");
                     tecla = Console.ReadKey(true).Key;
                    Console.Clear();
            }
            while (tecla != ConsoleKey.Escape);
            Console.WriteLine("Finish Program - Error al Cubo");
        }
        static void Ejercicio1MinimoMaximo()
        {
            int numero;
            int max = 0;
            int min = 0;
            int suma = 0;
            int promedio;
            Console.Title = "Ejercicio 1 - Numero Minimo-Maximo";
            Console.WriteLine("A Continuacion ingrese 5 numeros, se le indicara el maximo, el menor y el promedio total..");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese Un Numero : ");
                if (int.TryParse(Console.ReadLine(), out numero)) //parseo la entrada del readline a un int en la variable numero.
                {
                    if (i == 0)
                    {
                        min = numero;
                        max = numero;
                    }
                    else
                    {
                        if (numero < min) min = numero;
                        if (numero > max) max = numero;
                    }
                    suma += numero;
                }
                else
                {
                    Console.WriteLine("ERROR, SOLO PUEDE INGRESAR UN DATO NUMERICO");
                    --i;
                }
            }
            promedio = suma / 5;
            Console.Write($"EL numero Maximo es : {max} \n El numero Minimo es : {min} \n Promedio Total : {promedio:0}\n");
        }
    }
}