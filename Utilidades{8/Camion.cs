using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public class Camion : Vehiculo
    {

        protected float _tara;

        public Camion(float tara, string patente, byte cantRuedas, EMarcas marca)
           : base(patente, cantRuedas, marca)
        {
            _tara = tara;
        }

        public string MostrarCamion()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{EVehiculos.Camion.ToString()} - Tara : {_tara}");
            sb.AppendLine($"{base.Mostrar()}");

            return sb.ToString();
        }

    }
}
