using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{

    /*
     Crear una clase Impresora que contenga una lista de imprimibles llamada colaDelmpresion.

Luego crear dos métodos en la clase impresora :

ImprimirTodo Este método será el encargado de recorrer la cola de impresión e imprimirlos .

AgregarImprimible Este método será el encargado de agregar un imprimible a la cola de impresión .
     */
    public class Impresora
    {
        public List<Iimprimible> _colaDeImpresion;

        public string ImprimirTodo()
        {
            StringBuilder sb = new();
            foreach (var value in _colaDeImpresion)
            {
               sb.AppendLine($"{value.Imprimir()}");
            }

            return sb.ToString();
        }

        public void AgregarImprimible(Iimprimible value)
        {
            if(value is not null)
                _colaDeImpresion.Add(value);
        }

    }
}
