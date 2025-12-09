using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public static class TorreDeControl
    {
        private static List<Volador> _voladores;
        /*VuelenTodos Este método será el encargado de recorrer la lista de voladores y hacerlos volar.

AgregarVolador Este método será el encargado de agregar un volador a la lista de voladores.*/

        static TorreDeControl()
        {
            _voladores = new();
        }
        public static string VuelenTodos()
        {
                StringBuilder sb = new();
            if(_voladores.Count > 0)
            {
                foreach (var value in _voladores)
                {
                    sb.AppendLine($"{value.Volar()}");
                }
            }

            return sb.ToString();
        }

        public static bool AgregarVolador(Volador value)
        {
            if(value is not null)
            {
                _voladores.Add(value);
                return true;
            }

            return false;
        }
    }
}
