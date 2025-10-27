using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9Herencia.Clases
{

    /* cantidadRuedas : short, cantidadPuertas : short,
     * color : Colores, cantidadMarchas : short,
     * cantidadPasajeros : int.*/
    public class Automovil : VehiculoTerrestre
    {
        protected short _cantidadMarchas;
        protected int _cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros)
              : base(cantidadRuedas, cantidadPuertas, color)
        {
            _cantidadMarchas = cantidadMarchas;
            _cantidadPasajeros = cantidadPasajeros; 
        }

        public string MostrarAutomovil()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Auto - Cantidad Pasajeros :  {_cantidadPasajeros}");
            sb.AppendLine($"Cantidad De Marchas: {_cantidadMarchas}");
            sb.AppendLine($"{base.Mostrar()}");

            return sb.ToString();
        }
    }
}
