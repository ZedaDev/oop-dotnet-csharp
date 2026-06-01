using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExceptions
{
    public class BddNotConnect : Exception
    {
        public BddNotConnect()
        {
        }

        public BddNotConnect(string message) 
            : this(message, null)
        {
        }

        public BddNotConnect(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        private string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine("=========================================================================:INIC_EXCEPTION");

            //sb.AppendLine($"Excepción en el método {NombreMetodo} de la clase {NombreClase}:");
            sb.AppendLine($"'{this.Message}'");
            Exception inner = this.InnerException;

            while (inner is not null)
            {
                sb.AppendLine($"\t{inner.Message}");
                inner = inner.InnerException;
            }
            sb.AppendLine("=========================================================================:END_EXCEPTION");

            return sb.ToString();
        }
        public override string ToString()
        {
            return Mostrar();
        }
    }
}

