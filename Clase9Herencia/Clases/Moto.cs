using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9Herencia.Clases
{

    public class Moto : VehiculoTerrestre
    {

        protected short _cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada)
           : base(cantidadRuedas, cantidadPuertas, color)
        {
            _cilindrada = cilindrada;
        }

        public string MostrarMoto()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Moto - Cilindrada : {_cilindrada}");
            sb.AppendLine($"{base.Mostrar()}");

            return sb.ToString();
        }
    }
}
