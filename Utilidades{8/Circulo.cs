using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public sealed class Circulo : Figura
    {
        protected float _radio;

        public Circulo(float radio)
        {
            _radio = radio;
        }
        public override double CalcularPerimetro()
        {
            return Math.PI * _radio * 2;
        }
        public override double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(_radio, 2);
        }
        public override string Dibujando()
        {
            return "Dibujando forma... Circulo";
        }
    }
}
