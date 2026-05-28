namespace Clase17DelegadosELambda
{
        public delegate void DSaludar();
        public delegate void DSaludarConMSegundos(int number);
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //DSaludar  delegadoSaludar = new DSaludar(Saludar); 
            DSaludar  delegadoSaludar = Saludar;
            DSaludarConMSegundos delegadoSaludarMSegundos = SaludarConMSegundos;

            Temporizador.Esperar(new Random().Next(1000, 1500), delegadoSaludarMSegundos);


            Func<int, int, string> SumaRetornoString = Sumar;
            Func<int, int, string> SumaRetornoString1 = (n, n1) => (n + n1).ToString();
            string res = SumaRetornoString(11, 5);
            string res1 = SumaRetornoString1(11, 5);
            Console.WriteLine($"Resultado Delegado Sumar : {res}");

            //le envio el comportamiento al delegado y dentro del metodo solo le paso los numeros
            //y el delegado ya sabe que comportamiento tener
            //seria sumar 11 + 5 y convertir el resultado a string = "16";
           string sum = CuentaMatematica(11,5, (n,n2) =>(n+n2).ToString());
            Console.WriteLine($"Resultado Delegado Sumar : {sum}");

           string sum1 = CuentaMatematica(11,5, (n,n2) =>(n*n2).ToString());
            Console.WriteLine($"Resultado Delegado Multiplicar : {sum1}");

           string sum2 = CuentaMatematica(11,5, (n,n2) =>(n/n2).ToString());
            Console.WriteLine($"Resultado Delegado Dividir : {sum2}");

           string sum3 = CuentaMatematica(11,5, (n,n2) =>(n-n2).ToString());
            Console.WriteLine($"Resultado Delegado Restar : {sum3}");

            //Con un mismo delegado definimos los parametros de entrada y,
            //en cada llamada cambiamos su comportamiento segun dispongamos.

            List<int> numeros = new List<int>{ 8,2, 9, 11, 5 };
            numeros.Sort((n,n2) => n2.CompareTo(n));

            //parametro de entrada => Sentencia - Buscar(int n, int n2){ n.CompareTo(n2) }
            foreach (int value in numeros)
            {
                Console.WriteLine($"[{value}]");
            }


            Action<string> saludar = nombre =>
            {
                string saludo = $"¡Hola {nombre}!";
                Console.WriteLine(saludo);
            };
            saludar("Don");

            Func<string, string> PrintFrase = frase => $"{frase}";
            Console.WriteLine($"{PrintFrase("Frase Metodo Func")}"); 



            Func<string, string, bool> log2 = (name, lastName) => name == "pepe";
            log2("don", "pepe");

            Func<string, string, bool> log = Comprobar;
            log("aaa", "aa");

            Func<string, string, bool> log1 = Comprobar1(3);
            //comprobar devuelve una referencia ala funcion lambda interna del metodo.
            log1("aaa", "aa");
            //log1 al tener la referencia a la funcion lambda, simplemente la ejecuto pasandole los parametros
            //y alli uso la logica finalmente de la funcion lambda que se creo en el metodo comprobar.
            //manteniendo el scope de intentos guardado por la programacion CloSure
            //lo que hace es recordar el valor de la variable interna de la funcion lambda.

            Console.WriteLine($"Usuario Existe : {log1}");
            //bool ok = Log("a", "aaa", (s, s2) => Comprobar(s, s2));
            //Nuevamente defino el comportamiento en la llamada
            //en este caso un func que retorna un bool, entonces en el comportamiento
            //llamo al metodo comprobar pasandole los argumentos, y retorna un bool.
            //ese bool lo capturo con el delegado y lo retorna. 
            //Esto es ideal para acoplar logica de busqueda o filtro en base de datos
            //Donde comprobar comprobaria que el usuario exista segun su nick y pw retornando true o false.
        }


        public static bool Comprobar(string name, string LastName)
        {
            if (name == "aaa")
                return true;
            else 
                return false;
        }
        public static Func<string, string, bool> Comprobar1(int cantidad)
        {
            int intentos = 0;
            return (name, LastName) =>
            {
              if(intentos < cantidad)
                {
                    if (name == "aaa")//ComprobarUserBDD(name, lastname);
                        return true;
                    else
                        intentos++;
                }

                    return false;
            };


           /*Func<string, string, bool> log1 = Comprobar1(3);*/
            //comprobar devuelve una referencia a la funcion lambda interna del metodo.

            /*log1("aaa", "aa");*/
            //log1 al tener la referencia a la funcion lambda, simplemente la ejecuto pasandole los parametros
            //y alli uso la logica finalmente de la funcion lambda que se creo en el metodo comprobar.
            //manteniendo el scope de intentos guardado por la programacion CloSure
            //lo que hace es recordar el valor de la variable interna de la funcion lambda.
        }
        public static Func<string, string, bool> Log1(string name, string LastName)
        {
            return (n, l) => Comprobar(name, LastName);
        }
        public static bool Log(string name, string LastName, Func<string, string, bool> EstaLogueado)
        {
            return EstaLogueado(name, LastName);
        }
        public static string CuentaMatematica(int n, int n2,Func<int, int, string> sumarYRetorno)
        {
            return sumarYRetorno(n, n2);
        }
        public static string Sumar(int n, int n2)
        {
            return (n + n2).ToString();
        }
        public static void Saludar()
        {
            Console.WriteLine("Hola Mundo Saludar");
        }
        public static void SaludarConMSegundos(int mSegundos)
        {
            Console.WriteLine($"Hola Mundo Saludar Time : {mSegundos}");
        }
    }
}
