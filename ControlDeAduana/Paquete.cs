using System.Text;

namespace ControlDeAduana
{
    public abstract class Paquete : IAduana
    {
        private string _codigoSeguimiento;
        protected decimal _costoEnvio;
        private string _destino;
        private string _origen;
        private double _pesoKg;

        public abstract bool TienePrioridad { get;}

        public decimal Impuestos
        {
            get
            {
               return _costoEnvio * 0.35m;
            }
        }
            

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            _codigoSeguimiento = codigoSeguimiento;
            _costoEnvio = costoEnvio;
            _destino = destino;
            _origen = origen;
            _pesoKg = pesoKg;
            
        }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Codigo De Seguimiento : {_codigoSeguimiento}");
            sb.AppendLine($"Costo De Envio : {_costoEnvio}");
            sb.AppendLine($"Destino : {_destino}");
            sb.AppendLine($"Origen : {_origen}");
            sb.AppendLine($"Peso Kg : {_pesoKg}");

            return sb.ToString();
        }

        public virtual decimal AplicarImpuestos()
        {
            return _costoEnvio + Impuestos;
        }
    }
}
