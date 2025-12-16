using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsC14.E2
{
    public class Recibo : Documento
    {
        public Recibo(int numero) 
            : base(numero)
        {
        }
        public Recibo()
            : base(0)
        {
        }
    }
}
