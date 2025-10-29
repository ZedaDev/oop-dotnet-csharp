using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            _duracion = duracion;
            _nroDestino = nroDestino;
            _nroOrigen = nroOrigen;
        }

        public float Duracion 
        { 
            get => _duracion;
        }
        public string NroDestino 
        { 
            get => _nroDestino;
        }
        public string NroOrigen 
        { 
            get => _nroOrigen;
        }

        public int OrdenarPorDuracion(Llamada a, Llamada a1)
        {
            if (a.Duracion == a1.Duracion) return 0;

            if (a.Duracion > a1.Duracion) return 1;

            return -1;
        }

        public string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Duracion De La Llamada :  {Duracion}");
            sb.AppendLine($"Numero De Origen :  {NroOrigen}");
            sb.AppendLine($"Numero De Destino :  {NroDestino}");
            return sb.ToString();
        }
    }
}
