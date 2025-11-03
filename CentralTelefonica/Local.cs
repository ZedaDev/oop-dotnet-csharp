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

        public override float CostoLlamada
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
        /*Sobrescribir el método Mostrar. Será protegido. Reutilizará el código escrito
         * en la clase base y además agregará la propiedad CostoLlamada, utilizando
         * un StringBuilder.*/

       

        protected override string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Llamada Local");
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"Costo :  {this.CostoLlamada}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        public override bool Equals(object? obj)
        {
            if (obj is null || obj.GetType() != typeof(Local)) return false;

                return true;
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
