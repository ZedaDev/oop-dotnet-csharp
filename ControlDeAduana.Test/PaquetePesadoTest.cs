using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAduana.Test
{
    [TestClass]
    public class PaquetePesadoTest
    {
        private PaquetePesado _paquetePesado;

        [TestInitialize]
        public void TestInitialize()
        {

            _paquetePesado = new PaquetePesado("", 100, "", "", 0); 
            
        }

        [TestMethod]
        public void AplicarIMpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
            //Arrange
            int valorEsperado = 100 + 35 + 25;
            bool ok = false;

            //Act
            decimal impuestos = _paquetePesado.AplicarImpuestos();

            //Assert
            Assert.AreEqual(valorEsperado, impuestos);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaAfip()
        {
            //Arrange
            IAfip pPesado = new PaquetePesado("", 100, "", "", 0);
            int valorEsperado = 25;
            bool ok = false;

            //Act
            decimal impuestos = pPesado.Impuestos;

            //Assert

            Assert.AreEqual(valorEsperado, impuestos);
        }
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            //Arrange
            int valorEsperado = 25;
            bool ok = false;

            //Act
            decimal impuestos = _paquetePesado.Impuestos;

            //Assert

            Assert.AreEqual(valorEsperado, impuestos);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {

            //Act
            bool res = _paquetePesado.TienePrioridad;

            //Assert

            Assert.IsFalse(res);
        }
    }
}
