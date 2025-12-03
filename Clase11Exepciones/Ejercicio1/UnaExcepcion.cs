using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11Exepciones.Ejercicio1
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion()
            : this("Mensaje Predeterminado")
        {

        }

        public UnaExcepcion(string? message) : this(message, null)
        {

        }

        public UnaExcepcion(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
