using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Provincial : Llamada
    {
        protected EFranja _franjaHoraria;

        public Provincial(Llamada llamada, EFranja franjaHoraria)
            : this(llamada.Duracion, llamada.NroOrigen, llamada.NroDestino, franjaHoraria)
        {
        }
        public Provincial(float duracion, string origen, string destino, EFranja franjaHoraria)
            : base(duracion, destino, origen)
        {
            _franjaHoraria = franjaHoraria;
        }

        public float CostoLlamada
        {
            get => CalcularCosto();
        }
        private float CalcularCosto()
        {
            if (_franjaHoraria is EFranja.Franja_1)
                return 0.99f * base.Duracion;

            if (_franjaHoraria is EFranja.Franja_2)
                return 1.25f * base.Duracion;

            
                return 0.66f * base.Duracion;
        }
        public string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Llamada Local");
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"Franja Horaria :  {_franjaHoraria.ToString()}");

            return sb.ToString();
        }
    }
}
