using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Local : Llamada
    {

        private float _costo;

        public float CostoLlamada
        { 
            get => CalcularCosto(); 
        }

        public Local(Llamada llamada, float costo) 
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }
        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            _costo = costo;
        }
        public string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Llamada Local");
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"Costo :  {this.CostoLlamada}");

            return sb.ToString();
        }

        /*CalcularCosto será privado. Retornará el valor de la llamada a partir
         * de la duración y el costo de la misma.
        La propiedad CostoLlamada retornará el precio,
        que se calculará en el método CalcularCosto.*/

        private float CalcularCosto()
        {
            return _costo * Duracion;
        }
    }
}
