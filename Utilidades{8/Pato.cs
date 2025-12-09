using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public class Pato : Volador
    {
        private int _energy;

        public Pato()
        {
            _energy = 20;
        }

        public string Volar()
        {
            _energy -= 5;
            return "Estoy volando como un pato ¡ Cuak !";
        }
    }
}
