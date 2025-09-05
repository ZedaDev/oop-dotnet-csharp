namespace Utilidades
{
    public class Validador
    {
        /// <summary>
        /// Valida que el dato numerico ingresado por el usuario este dentro de un rango minimo y maximo.
        /// </summary>
        /// <param name="valor">Numero Que Desea Validar</param>
        /// <param name="min">Valor Minimo Permitido</param>
        /// <param name="max">Valor Maximo Permitido</param>
        /// <returns>Devuelve true si el valor esta dentro del rango, False de lo contrario.</returns>
        public static bool Validar(int valor, int min, int max)
        {
            return (valor >= min && valor <= max);
        }


         /// <summary>
         /// Valida Respuesta Del Usuario
         /// </summary>
         /// <returns>Devuelve true si el usuario ingresa 's', false de lo contrario</returns>
        public static bool ValidarRespuesta()
        {
            string? respuesta = Console.ReadLine()?.Trim().ToLower();
          //string?(Esto puede contener un NULL), ?.metodos(Si no es NULL, asignale los metodos)
                return (respuesta == "s");
        }

        /// <summary>
        /// Pide un numero entero y, lo valida hasta que se ingrese un dato numerico.
        /// </summary>
        /// <returns>Retorna un int</returns>
        public static int PedirYValidarNumeroEntero()
        {
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero)){

                    Console.WriteLine("Error, Solo Se Permiten Datos Numericos!, Vuelva a Ingresar");
                    Console.ReadKey(); Console.Clear();
            }
            return numero;
        } 

        public static bool ValidarString(string valor) => (!string.IsNullOrWhiteSpace(valor.Trim()));
        
    }
}

