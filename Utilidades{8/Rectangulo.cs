using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public class Rectangulo : Figura
    {
        protected float _base;
        protected float _altura;
        public Rectangulo(float longitudBase, float longitudAltura)
        {
            _base = longitudBase;
            _altura = longitudAltura;
        }

        public override double CalcularPerimetro()
        {
            return (_base + _altura) * 2;
        }
        public override double CalcularSuperficie()
        {
            return _base * _altura;
        }
        public override string Dibujando()
        {
            return "Dibujando forma... Rectangulo";
        }
    }
}
