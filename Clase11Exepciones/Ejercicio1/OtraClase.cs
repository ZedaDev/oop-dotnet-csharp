using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11Exepciones.Ejercicio1
{/*Generar la clase OtraClase con un método de instancia, donde se instancie un objeto MiClase
  * y se capture la excepción anterior. Este método generará una excepción propia llamada MiException
  * y la lanzará.*/
    public class OtraClase
    {

        public OtraClase() 
        {

        }

        public void MetodoInstancia()
        {
            try
            {
                MiClase miclase = new("USER");

            }
            catch (UnaExcepcion ex)
            {

                throw new MiExcepcion("Ocurrio una Excepcion de tipo MiExcepcion aqui en OtraClase", ex);
            }
        }
    }
}
