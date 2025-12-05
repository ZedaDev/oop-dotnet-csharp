using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public class EscrituraWrapper
    {

        public ConsoleColor _color;
        public string _texto;

        public EscrituraWrapper(ConsoleColor color, string texto)
        {
            _color = color;
            _texto = texto;
        }
    }
}
