namespace ControlDeAduana.Test
{

    
    [TestClass]
    public sealed class PaqueteFragilTest
    {
        private PaqueteFragil _paqueteFragil;

        [TestInitialize]
        public void TestInitialize()
        {
            _paqueteFragil = new PaqueteFragil("", 100, "", "", 0);
        }

        [TestMethod]
        public void AplicarIMpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAduana()
        {
            bool ok = false;
            int valorEsperado = 65;
            //Act
            decimal impuestos = _paqueteFragil.AplicarImpuestos();

            //Assert

            Assert.AreEqual(valorEsperado, impuestos);
           
        }
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            int valorEsperado = 35;
            bool ok = false;

            //Act
            decimal impuestos = _paqueteFragil.Impuestos;

            //Assert

            Assert.AreEqual(valorEsperado, impuestos);
        }
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {

            //Act
            bool res = _paqueteFragil.TienePrioridad;

            //Assert

            Assert.IsTrue(res);
        }

    }
}
