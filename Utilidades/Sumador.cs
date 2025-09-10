using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class Sumador
    {
        private int _cantidadSumas;

        //public Sumador(int cantidadSumas = 0) => _cantidadSumas += cantidadSumas;
        public Sumador(int cantidadSumas)
        {
            _cantidadSumas = cantidadSumas;
        }
        public Sumador() 
            :this(0) {  }

        public long Sumar(long numero, long numero2)
        {
             IncrementarSuma();
            return numero + numero2;
        }
        public string Sumar(string numero, string numero2)
        {
                IncrementarSuma();
              return $"{numero}{numero2}";
        } 

         public static explicit operator int(Sumador s) => s._cantidadSumas;

        public static bool operator |(Sumador s1, Sumador s2) => s1._cantidadSumas == s2._cantidadSumas;

        public static long operator +(Sumador s1, Sumador s2) => s1._cantidadSumas + s2._cantidadSumas;


        private void IncrementarSuma()
        {
            ++_cantidadSumas;   
        }
    }
}
