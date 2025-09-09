using System;
using System.Collections.Generic;
using System.Linq;
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

        private void IncrementarSuma()
        {
            ++_cantidadSumas;   
        }
    }
}
