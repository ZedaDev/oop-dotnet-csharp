using Clase11Exepciones.Ejercicio1;

namespace Clase11Exepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

                OtraClase otraClase = new ();
            try
            {
                otraClase.MetodoInstancia();
            }
            catch (MiExcepcion ex)
            {
                Exception iException = ex.InnerException;

                    Console.WriteLine($"{ex.Message}");
                while (iException is not null)
                {
                    Console.WriteLine($"{iException.Message}");
                    iException = iException.InnerException;
                }

            }
            finally
            {
                
            }
        }
    }
}
