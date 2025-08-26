using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase002.Ejercicios
{
    internal class Ejercicio3
    {
       public static void ejecutar()
        {
            Console.Title = "Conversor De Numeros";
            Console.WriteLine("Ingrese Un Numero decimal y sera convertido a binario, luego ingrese un numero binario y sera convertido a decimal");
            int numero = Validador.PedirYValidarNumeroEntero();
            string numBinario = Conversor.ConvertirDecimalABinario(numero);

            int numero1 = Validador.PedirYValidarNumeroEntero();
            int numDecimal = Conversor.ConvertirBinarioADecimal(numero1);
            Console.WriteLine($@"
                Numero Decimal Ingresado : {numero}, Conversion a Binario : {numBinario}

                Numero Binario Ingresado : {numero1}, Conversion a Decimal : {numDecimal}");
        }
    } 
}
