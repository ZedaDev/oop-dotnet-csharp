using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public class Lavadero
    {
        protected List<Vehiculo> _vehiculos;
        protected float _priceAuto;
        protected float _priceMoto;
        protected float _priceCamion;

        #region Properties

        
        public string Detalle
        {
            get
            {
               StringBuilder sb = new();
                sb.AppendLine($"{ViewVehiclesInfo()}");
                sb.AppendLine($"{ViewPricesAndGain()}");

                 return sb.ToString();
            }
        }
        public List<Vehiculo> Vehiculos
        {
            get
            {
                if (_vehiculos == null) return null;
                else return _vehiculos;
            }
        }
        #endregion

        #region Constructors
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

        #endregion

        #region Sobrecargas

        public static bool operator ==(Lavadero l, Vehiculo v)
        {
            bool result = false;
            if(l._vehiculos.Count > 0)
            {
                foreach (Vehiculo v1 in l.Vehiculos)
                {
                    if(v1 is Camion && v is Camion)
                    {
                        result = ((Camion)v1).Patente == ((Camion)v).Patente;
                    }
                    if(v1 is Auto && v is Auto)
                    {
                        result = ((Auto)v1).Patente == ((Auto)v).Patente;
                    }
                    if(v1 is Moto && v is Moto)
                    {
                        result = ((Moto)v1).Patente == ((Moto)v).Patente;
                    }
                }
            }

            return result;
        }
        public static bool operator !=(Lavadero l, Vehiculo v) => !(l == v);
        
        public static bool operator +(Lavadero l, Vehiculo v)
        {
            bool result = true;
            if (l.Vehiculos.Count > 0)
            {
                foreach (Vehiculo v1 in l.Vehiculos)
                {
                    if (!(result = v1 != v)) break;
                }

            }
                    if(result)
                        l._vehiculos.Add(v);

            return result;
        }
        public static bool operator -(Lavadero l, Vehiculo v)
        {
            bool result = false;
            if(l.Vehiculos.Count > 0)
            {
                foreach (Vehiculo v1 in l.Vehiculos)
                {
                    if(v1 == v)
                    {
                        l.Vehiculos.Remove(v1);
                        result = true;
                    }
                }
            }
            return result;
        }
        #endregion

        #region Methods

        public double MostrarTotalFacturado()
        {
            double total = 0;
            if(Vehiculos.Count > 0)
            {
                foreach (Vehiculo v in Vehiculos)
                {
                    if (v is Camion)
                        total+= MostrarTotalFacturado(EVehiculos.Camion);

                    if (v is Auto)
                        total += MostrarTotalFacturado(EVehiculos.Auto);

                    if (v is Moto)
                        total += MostrarTotalFacturado(EVehiculos.Moto);
                }
            }

            return total;
        }
        public double MostrarTotalFacturado(EVehiculos eVehiculos)
        {
            return (double)eVehiculos;
        }


        private string ViewVehiclesInfo()
        {
            StringBuilder sb = new();
            if (_vehiculos.Count > 0)
            {
                 //sb.AppendLine($"-Lista De Vehiculos :");
                foreach (Vehiculo v in _vehiculos)
                {
                    if (v is Camion)
                    {
                        sb.AppendLine($"{((Camion)v).MostrarCamion()}");
                    }
                    else if (v is Auto)
                    {
                        sb.AppendLine($"{((Auto)v).MostrarAuto()}");
                    }
                    else if (v is Moto)
                    {
                        sb.AppendLine($"{((Moto)v).MostrarMoto()}");
                    }
                }
            }
            else 
                sb.AppendLine("Lista Vacia\n");

            return sb.ToString();
        }

        private string ViewPricesAndGain()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Total Facturado : {MostrarTotalFacturado()}");
            sb.AppendLine($"\nPrecio Auto : {_priceAuto}");
            sb.AppendLine($"Precio Camion : {_priceCamion}");
            sb.AppendLine($"Precio Moto : {_priceMoto}");
            return sb.ToString();
        }
        #endregion
    }
}
