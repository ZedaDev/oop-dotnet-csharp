using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class NumeroDecimal
    {

        private double _numero;

        public NumeroDecimal(double numero)
        {
            this._numero = numero;
        }


        public static string ConvertirDecimalABinario(double numeroEntero1)
        {
            int resto;
            int numeroEntero = (int)numeroEntero1;///Aqui yacia el problema, era double, 22.0 .
            string binary = string.Empty;
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
            if (binary == string.Empty) binary = "0 o Numero Negativo";
            return binary;
        }


        /*string + (NumeroBinario, NumeroDecimal)
string - (NumeroBinario, NumeroDecimal)
bool == (NumeroBinario, NumeroDecimal)
bool != (NumeroBinario, NumeroDecimal)*/


        //Sobrecargas
       public static implicit operator NumeroDecimal(double numero) => new NumeroDecimal(numero);

       public static explicit operator Double(NumeroDecimal numero) => numero._numero;

        public static bool operator ==(NumeroDecimal nD, NumeroBinario nB)
        {
            return nB == nD;
        }
        public static bool operator !=(NumeroDecimal nD, NumeroBinario nB)
        {
            return !(nB == nD);
        }

        public static Double operator +(NumeroDecimal nD, NumeroBinario nB)
        {
            return nD._numero + (nB.ConvertirBinarioADecimal((string)nB));
            //return nB.ConvertirBinarioADecimal(nB + nD);
        }
        public static Double operator -(NumeroDecimal nD, NumeroBinario nB)
        {
           return nD._numero - (nB.ConvertirBinarioADecimal((string)nB));
            //return nB.ConvertirBinarioADecimal(nB - nD);
        }
    }
}
