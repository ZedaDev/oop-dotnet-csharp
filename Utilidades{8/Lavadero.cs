using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    internal class Lavadero
    {
        protected List<Vehiculo> _vehiculos;
        protected float _priceAuto;
        protected float _priceMoto;
        protected float _priceCamion;

        public string Detalle
        {
            get
            {
                StringBuilder sb = new();

                sb.AppendLine($"Lista De Vehiculos y Precios : \n");
                sb.AppendLine($"{this.Vehiculos}");
                sb.AppendLine($"\nPrecio Auto : {_priceAuto}");
                sb.AppendLine($"Precio Camion : {_priceCamion}");
                sb.AppendLine($"Precio Moto : {_priceMoto}");

                return sb.ToString();
            }
        }
        public string Vehiculos
        {
            get
            {
                if(_vehiculos.Count > 0)
                {
                    StringBuilder sb = new();
                    foreach (Vehiculo v in _vehiculos)
                    {
                        sb.AppendLine($"{v.Mostrar()}");
                    }
                     return sb.ToString();
                }
                return string.Empty;
            }
        }
        private Lavadero()
        {
            _vehiculos = new();
        }
        public Lavadero(float priceAuto, float priceMoto, float priceCamion)
            : this()
        {
            _priceAuto = priceAuto;
            _priceMoto = priceMoto;
            _priceCamion = priceCamion;
        }
    }
}
