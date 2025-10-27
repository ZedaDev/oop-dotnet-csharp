using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9Herencia.Clases
{
    /*Crear la clase VehiculoTerrestre y abstraer la información necesaria de las clases anteriores
     * . Luego generar una relación de herencia entre ellas, según corresponda.
VehiculoTerrestre tendrá un constructor que recibirá todos sus atributos.
    Modificar las clases que heredan de ésta para que lo reutilicen.*/
    public class VehiculoTerrestre
    {
        protected short _cantidadRuedas;
        protected short _cantidadPuertas;
        protected Colores _color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            _cantidadRuedas = cantidadRuedas;
            _cantidadPuertas = cantidadPuertas;
            _color = color;
        }

        public string Mostrar()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Cantidad De Ruedas : {_cantidadRuedas}");
            sb.AppendLine($"Cantidad De Puertas : {_cantidadPuertas}");
            sb.AppendLine($"Color : {_color}");

            return sb.ToString();
        }
    }
}
