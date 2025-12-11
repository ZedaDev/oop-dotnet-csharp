using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase11Exepciones;
using Clase11Exepciones.Ejercicio1;
namespace Clase12UnitTest
{
    [TestClass]
    public class LanzaryAtraparTest
    {

        /*Realizar un test unitario para cada método y/o constructor.
         * Cada test deberá validar que el método lance la excepción que le corresponde.*/

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void LLamarAlConstructorSinParametros_ValidarQueLanceExcepcion_DeberiaLanzarDivideByZeroException()
        {
            MiClase myClass = new();
            
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void LLamarAlConstructorConParametros_ValidarQueLanceExcepcion_DeberiaLanzarUnaExcepcion()
        {
            MiClase myClass = new("Rada Rada Rada RadaBombastic");
            
        }
        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void AlLlamarAlMetodoInstancia_ValidarQueLanceExcepcion_DeberiaLanzarMiExcepcion()
        {
            OtraClase otherClass = new();
            otherClass.MetodoInstancia();
            
        }
    }
}
