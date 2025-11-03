using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public sealed class Cuadrado : Rectangulo
    {

        public Cuadrado(float longitudLado) 
            :  base(longitudLado, longitudLado)
        { }
        public override double CalcularSuperficie()
        {
            return 0.0d;
        }
        public override string Dibujando()
        {
            return "Dibujando forma...Cuadrado";
        }
    }
}
