using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeAduana;
namespace ControlDeAduana.Test
{
    [TestClass]
    public class GestionImpuestosTest
    {


        /*Implementar la prueba unitaria
         * CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana 
         * de la clase GestionImpuestosTest. Deberá verificar que el método
         * CalcularTotalImpuestosAduana retorne la suma de los impuestos de aduana.
         * Realizar la prueba con al menos un paquete de cada tipo.*/
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana() 
        {
            int expected = 70;
            GestionImpuestos gImpuestos = new();
            Paquete p_Fragil = new PaqueteFragil("111", 100, "", "", 5);
            Paquete p_Pesado = new PaquetePesado("111", 100, "", "", 5);

            gImpuestos.RegistrarImpuestos(p_Fragil);
            gImpuestos.RegistrarImpuestos(p_Pesado);

            Assert.AreEqual(expected, gImpuestos.CalcularTotalImpuestosAduana()); 

        }
        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip() 
        {
            int expected = 25;
            GestionImpuestos gImpuestos = new();
            Paquete p_Fragil = new PaqueteFragil("111", 100, "", "", 5);
            Paquete p_Pesado = new PaquetePesado("111", 100, "", "", 5);

            gImpuestos.RegistrarImpuestos(p_Fragil);
            gImpuestos.RegistrarImpuestos(p_Pesado);
           

            Assert.AreEqual(expected, gImpuestos.CalcularTotalImpuestosAfip()); 

        }


    }
}
