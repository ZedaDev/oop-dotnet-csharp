using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public class CartucheraMultiuso
    {
        private List<IAcciones> _lista;

        public CartucheraMultiuso(List<IAcciones> lista)
        {
            _lista = lista;
        }

        /*Se deberá recorrer la lista y gastará 1 unidades de cada elemento.
Cuando sea necesario, recargará antes de salir del método (cargar 20 unidades).
Retornará true si se pudo gastar exactamente 1 unidad de todos los elementos.*/


        public bool RecorrerElementos()
        {

            foreach (var item in _lista)
            {
                try
                {
                    if (item.UnidadesDeEscritura < 1)
                        item.Recargar(20);

                    if (item.UnidadesDeEscritura >= 1)
                    {
                        EscrituraWrapper eWrapper = item.Escribir("1");
                        Console.ForegroundColor = eWrapper._color;
                        Console.WriteLine($"{eWrapper._texto}");
                    }
                    else
                        return false;

                }
                catch (Exception e)
                {
                    Console.WriteLine($"EXCEPTION :{e.Message} {e.InnerException?.Message}");
                    return false;
                }
            }
                return true;
        }

    }
}
