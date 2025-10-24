using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public class Auto : Vehiculo
    {

        protected int _CantidadAsientos;

        public Auto(int cantidadAsientos, string patente, byte cantRuedas, EMarcas marca)
            : base(patente, cantRuedas, marca)
        {
            _CantidadAsientos = cantidadAsientos;
        }


        public string MostrarAuto()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{EVehiculos.Auto.ToString()} - Asientos : {_CantidadAsientos}");
            sb.AppendLine($"{base.Mostrar()}");

            return sb.ToString();
        }
    }
}
