using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public class Moto : Vehiculo
    {
        protected int _cilindrada;
        public Moto(int cilindrada, string patente, byte cantRuedas, EMarcas marca)
                  : base(patente, cantRuedas, marca)
        {
            _cilindrada = cilindrada;
        }
        public string MostrarMoto()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{EVehiculos.Moto.ToString()} - Cilindrada : {_cilindrada}");
            sb.AppendLine($"{base.Mostrar()}");

            return sb.ToString();
        }
    }
}
