using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class NumeroBinario
    {
        /*Único atributo numero de tipo string.
Único constructor privado (recibe un parámetro de tipo string).*/

        private string _numero;

        public NumeroBinario(string numero) 
        {
            _numero = numero;
        }


        /// <summary>
        /// Convierte Un Numero Binario a Decimal
        /// </summary>
        /// <param name="numeroEntero">Numero a Convertir</param>
        /// <returns>Si el Numero es Mayor a 0 Retorna El Decima, Si no, Retorna 0</returns>
        public  double ConvertirBinarioADecimal(double numeroEntero)
        {
            int exponente = 0;
            double resultado = 0;
            while (numeroEntero > 0)
            {
                double digito = numeroEntero % 10;// saco el digito, 1011 % 10 = 1
                resultado += digito * (int)Math.Pow(2, exponente); //1* 2 a al exponente(0), y lo casteo a un int, pow devuelve un double.
                numeroEntero /= 10;//divido el numero por 10, 1011 / 10 = 101;
                exponente++;
            }
            #region SOLUCION
            /*segunda vuelta: digito = 101 % 10 = 1 (10x10=100, resto 1),
             resultado(+= 1 * 2 al exponente(1,++ de la vuelta anterior) = (1*2x1) = 2
            numeroEntero /= 10; (101 /10) = 10;

            cada numero elevado a 0 da 1, cada numero divido un numero mayor da 0
            cada numero resto un un numero mayor da el mismo numero(1%10 = 1).
             */
            #endregion

            return resultado;
        }
         public double ConvertirBinarioADecimal(string numeroEntero)
        {
            int exponente = 0;
            double resultado = 0;
            for(int i = numeroEntero.Length-1; i>=0;i--)
            {
                if (numeroEntero[i] == '1')
                {
                    resultado += Math.Pow(2, exponente);
                }
                exponente++;
            }
            return resultado;
        }

        //Sobrecargas

        /**NumeroBinario:

            string + (NumeroBinario, NumeroDecimal)
            string - (NumeroBinario, NumeroDecimal)
            bool == (NumeroBinario, NumeroDecimal)
            bool != (NumeroBinario, NumeroDecimal)*/
        public static implicit operator NumeroBinario(string numero) => new NumeroBinario(numero);

        public static explicit operator string(NumeroBinario numero) => numero._numero; //Funciona como getter explicito.

        public static bool operator ==(NumeroBinario nB, NumeroDecimal nD)
        {
            return (nB.ConvertirBinarioADecimal(nB._numero)) == ((double)nD);
        }
        public static bool operator !=(NumeroBinario nB, NumeroDecimal nD)
        {
            return !(nB == nD);
        }

        public static string operator +(NumeroBinario nB, NumeroDecimal nD)
        {
            return NumeroDecimal.ConvertirDecimalABinario(nD + nB);
        }
        public static string operator -(NumeroBinario nB, NumeroDecimal nD)
        {
            return NumeroDecimal.ConvertirDecimalABinario(nD - nB);
        }
    }
}
