using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11Exepciones.Ejercicio1
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion()
            : this("Mensaje Predeterminado")
        {

        }

        public MiExcepcion(string? message) 
            : this(message, null)
        {

        }

        public MiExcepcion(string? message, Exception? innerException) 
            : base(message, innerException)
        {

        }

    }
}
