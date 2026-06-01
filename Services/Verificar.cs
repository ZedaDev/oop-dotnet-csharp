using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Verificar
    {

        public Predicate<T> VerificarExistente<T>(int cantidad, Predicate<T> comprobar) where T : new()
        {
            int intentos = 0;
            return entidad =>
            {
                if (intentos < cantidad)
                {
                    if (comprobar(entidad))  // Llamada al método que se pasa como delegado
                        return true;
                    else
                        intentos++;
                }
                return false;
            };
        }

    }
}
