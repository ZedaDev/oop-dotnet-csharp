using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public class BuzzLightyear : Volador
    {
        private int _experience;

        public BuzzLightyear()
        {
            _experience = 0;
        }

        public string Volar()
        {
            _experience += 3;
            return "Al infinito y mas alla";
        }
    }
}
