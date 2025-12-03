using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CentralitaException : Exception
    {
        private string _nombreClase;
        private string _nombreMetodo;

        public CentralitaException(string message, string clase, string metodo) 
            : this(message, clase, metodo, null)
        {

        }

        public CentralitaException(string message, string clase, string metodo, Exception innerException) 
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
    }
}
