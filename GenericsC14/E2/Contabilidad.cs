using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsC14.E2
{
    public class Contabilidad<T,U> 
         where T : Documento
         where U : Documento, new()
    {
        private List<T> _egresos;
        private List<U> _ingresos;

        public Contabilidad()
        {
            _egresos = new();
            _ingresos = new();
        }

        public List<T> Egresos { get => _egresos;}
        public List<U> Ingresos { get => _ingresos;}

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T egreso)
        {
            if(egreso is not null && c is not null)
            {
                c._egresos.Add(egreso);
            }

            return c;
        }
        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, U ingreso)
        {
            if (ingreso is not null && c is not null)
            {
                c._ingresos.Add(ingreso);
            }

            return c;
        }
    }
}
