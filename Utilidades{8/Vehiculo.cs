using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public class Vehiculo
    {
        protected string _patente;
        protected byte _cantRuedas;
        protected EMarcas _marca;

        #region Properties
        public string Patente
        {
            get => _patente;
        }
        public EMarcas Marca
        {
            get => _marca;
        }



        #endregion

        #region Constructor

        protected Vehiculo(string patente, byte cantRuedas, EMarcas marca)
        {
            _patente = patente;
            _cantRuedas = cantRuedas;
            _marca = marca;
        }
        #endregion

        #region Sobrecargas

        public static bool operator ==(Vehiculo v, Vehiculo v1)
        {
            //Son iguales en memoria?
            if (ReferenceEquals(v, v1)) 
                return true;

            //si no son iguales en memoria, y alguno es null. son distintos.
            if (v is null || v1 is null) 
                return false;

            return (v.Patente == v1.Patente) && (v.Marca == v1.Marca);
        }
        public static bool operator !=(Vehiculo v, Vehiculo v1)
        {
            return !(v == v1);
        }
        #endregion

        #region Methods

        public string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Patente : {Patente}");
            sb.AppendLine($"Marca : {Marca}");

            return sb.ToString();
        }

        #endregion

    }
}
