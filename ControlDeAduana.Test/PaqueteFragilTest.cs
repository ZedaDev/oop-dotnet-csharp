namespace ControlDeAduana.Test
{

    
    [TestClass]
    public sealed class PaqueteFragilTest
    {
        [TestMethod]
        public void AplicarIMpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAduana()
        {
            //Arrange
            PaqueteFragil pFragil = new("", 100, "", "", 0);
            bool ok = false;
            //Act
            decimal impuestos = pFragil.AplicarImpuestos();
            if (impuestos == 65)
                ok = true;
            //Assert

            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            //Arrange
            PaqueteFragil pFragil = new("", 100, "", "", 0);
            bool ok = false;
            //Act
            decimal impuestos = pFragil.Impuestos;
            if (impuestos == 35)
                ok = true;
            //Assert

            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            //Arrange
            PaqueteFragil pFragil = new("", 0,"", "", 0);

            //Act
            bool res = pFragil.TienePrioridad;

            //Assert

            Assert.IsTrue(res);
        }

    }
}
