using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public abstract class Llamada
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

        public abstract float CostoLlamada { get; }
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
        /*El operador == comparará dos llamadas y retornará true si las llamadas son del mismo tipo
         * (utilizar el método Equals, sobrescrito en las clases derivadas)
         * y los números de destino y origen son iguales en ambas llamadas.*/

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if (ReferenceEquals(l1, l2)) return true;

            if (l1 is null || l2 is null) return false;

            return l1.NroDestino == l2.NroDestino && l1.NroOrigen == l1.NroOrigen;
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || obj.GetType() != typeof(Llamada)) return false;

            return (this == (Llamada)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(NroDestino, NroOrigen);
        }
        protected virtual string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Duracion De La Llamada :  {Duracion}");
            sb.AppendLine($"Numero De Origen :  {NroOrigen}");
            sb.AppendLine($"Numero De Destino :  {NroDestino}");
            return sb.ToString();
        }
    }
}
