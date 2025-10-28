using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Llamada
    {
        private float duracion;
        private string nroDestino;
        private string nroOrigen;

        protected float Duracion 
        { 
            get => duracion;
        }
        protected string NroDestino 
        { 
            get => nroDestino;
        }
        protected string NroOrigen 
        { 
            get => nroOrigen;
        }
    }
}
