using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase002.Ejercicios
{
    public static class Conversor
    {
        /// <summary>
        /// Convierte Numero Decimal a Binario
        /// </summary>
        /// <param name="numeroEntero">Numero A Convertir</param>
        /// <returns>Si el numero es mayor a 0 retorna el numero binario, si no, retorna 0</returns>
        public static string ConvertirDecimalABinario(int numeroEntero) {
            int resto;
            string binary = (numeroEntero <= 0) ? "0" : "";
            while (numeroEntero > 0)
            {
                resto = numeroEntero % 2;
                binary = resto + binary;//concatena al final,0+"", luego 0+ 0"", luego 1+ 00"". res : 100
                numeroEntero /= 2;
            }
            #region SOLUCION
             /*El binario es el resto de cada division, luego cada division el resultado
             se divide por 2 hasta que de 0. Ej: 4 % 2 = 0, numero/= 2 = 2,
             siguiente iteracion : 2 % 2 = 0  2/= 2 = 1.
             1 % 2 = 1, 1/=2 = 0 (al ser un int, saca la parte decimal dejando solo el entero)
             termina el while el cociente dio 0.
             numero binario de 4 : 100, por que el binario se lee al reves: 0,0,1 = 100
             cada numero divivdo por un un numero mayor, da 0*/
            
            #endregion

            return binary;
        }

        /// <summary>
        /// Convierte Un Numero Binario a Decimal
        /// </summary>
        /// <param name="numeroEntero">Numero a Convertir</param>
        /// <returns>Si el Numero es Mayor a 0 Retorna El Decima, Si no, Retorna 0</returns>
        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int exponente = 0;
            int resultado = 0;
            while (numeroEntero > 0)
            {
                int digito = numeroEntero % 10;// saco el digito, 1011 % 10 = 1
                resultado += digito * (int)Math.Pow(2,exponente); //1* 2 a al exponente(0), y lo casteo a un int, pow devuelve un double.
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
    }
}
