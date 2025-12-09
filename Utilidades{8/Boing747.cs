using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public class Boing747 : Volador
    {

        private int _flyHours;

        public Boing747()
        {
            _flyHours = 0;
        }

        public string Volar()
        {
            _flyHours += 13;
            return "Estoy volando como un avión";
        }
    }
}
