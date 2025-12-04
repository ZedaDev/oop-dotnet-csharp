using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string _nombreClase;
        private string _nombreMetodo;
        public CompetenciaNoDisponibleException(string message, string clase, string metodo)
              : this(message, clase, metodo, null)
        {

        }

        public CompetenciaNoDisponibleException(string message, string clase, string metodo, Exception innerException)
            : base(message, innerException)
        {
            _nombreClase = clase;
            _nombreMetodo = metodo;
        }


        public string NombreClase
        {
            get => _nombreClase;
            set => _nombreClase = value;
        }
        public string NombreMetodo
        {
            get => _nombreMetodo;
            set => _nombreMetodo = value;
        }

        private string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine("=========================================================================:INIC_EXCEPTION");

            sb.AppendLine($"Excepción en el método {NombreMetodo} de la clase {NombreClase}:");
            sb.AppendLine($"'{this.Message}'");
                 Exception inner = this.InnerException;
          
                while(inner is not null)
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
