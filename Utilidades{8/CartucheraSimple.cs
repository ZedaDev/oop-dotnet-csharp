using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public class CartucheraSimple
    {
        List<Boligrafo> _boligrafos;
        List<Lapiz> _lapices;

        public CartucheraSimple(List<Boligrafo> boligrafos, List<Lapiz> lapices)
        {
            _boligrafos = boligrafos;
            _lapices = lapices;
        }

        public bool RecorrerElementos()
        {

            foreach (Boligrafo item in _boligrafos)
            { 

                if(item.UnidadesDeEscritura < 1)
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

            foreach (Lapiz item in _lapices)
            {
                try
                {
                    if (((IAcciones)item).UnidadesDeEscritura < 1)
                        item.Recargar(20);

                    if (((IAcciones)item).UnidadesDeEscritura >= 1)
                    {
                        EscrituraWrapper eWrapper = ((IAcciones)item).Escribir("1");
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
