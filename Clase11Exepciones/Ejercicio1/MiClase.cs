using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11Exepciones.Ejercicio1
{
    public class MiClase
    {

        public MiClase()
        {
               MiClase.MiMetodoStatico();
            /*try
            {
               MiClase.MiMetodoStatico();
            }
            catch (DivideByZeroException)
            {

                throw;
            }*/
            
        }
        public MiClase(string message)
        {
            try
            {
                MiClase miclase = new();
            }
            catch (DivideByZeroException ex)
            {
                //captura un excepcion especifica, luego creo una nueva, con un mensaje y la inner que seria la exepcion original capturada.
                throw new UnaExcepcion($"Excepcion Capturada {message} y, Relanzada", ex);
            }

        }

        public static void  MiMetodoStatico()
        {
            throw new DivideByZeroException("No se Puede dividir por 0, Mi Metodo Estatico");
        }
    }
}
