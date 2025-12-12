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
            PaquetePesado pPesado = new PaquetePesado("", 100, "", "", 0);
            bool ok = false;
            //Act
            decimal impuestos = _paquetePesado.AplicarImpuestos();

            if (impuestos == 100+35+25)
                ok = true;
            //Assert

            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaAfip()
        {
            //Arrange
            IAfip pPesado = new PaquetePesado("", 100, "", "", 0);
            bool ok = false;
            //Act
            decimal impuestos = pPesado.Impuestos;

            if (impuestos == 25)
                ok = true;
            //Assert

            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            //Arrange
            PaquetePesado pPesado = new("", 100, "", "", 0);
            bool ok = false;
            //Act
            decimal impuestos = _paquetePesado.Impuestos;

            if (impuestos == 35)
                ok = true;
            //Assert

            Assert.IsTrue(ok);
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
