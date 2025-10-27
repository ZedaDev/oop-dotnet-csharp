using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9Herencia.Clases
{

    /*cantidadRuedas: short,
     * cantidadPuertas : short,
     * color : Colores,
     * cantidadMarchas : short,
     * pesoCarga : int.*/
    public class Camion : VehiculoTerrestre
    {

        protected short _cantidadMarchas;
        protected int _pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga)
              : base(cantidadRuedas,cantidadPuertas,color)
        {
            _cantidadMarchas = cantidadMarchas;
            _pesoCarga = pesoCarga;
        }

        public string MostrarCamion()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Camion - Peso De Carga : {_pesoCarga}");
            sb.AppendLine($"Cantidad De Marchas:  {_cantidadMarchas}");
            sb.AppendLine($"{base.Mostrar()}");

            return sb.ToString();
        }
    }
}
