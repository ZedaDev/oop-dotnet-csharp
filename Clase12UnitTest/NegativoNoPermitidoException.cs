using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12UnitTest
{
    public class NegativoNoPermitidoException : Exception
    {
        public NegativoNoPermitidoException() 
            :this("Negative Number")
        {
        }

        public NegativoNoPermitidoException(string? message) 
            : this(message, null)
        {
        }

        public NegativoNoPermitidoException(string? message, Exception? innerException)
            : base(message, innerException)
        {
        }
    }
}
