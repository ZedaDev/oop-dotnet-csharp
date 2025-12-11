namespace Clase12UnitTest
{
    [TestClass]
    public sealed class Test1
    {
        [DataTestMethod]
        [DataRow("0", 0)] // Caso 1: "0" = 0
        [DataRow("1", 1)] // Caso 2: "1" = 1
        [DataRow("1,8", 9)]  // Caso 3: "1,8" -> Sumar 1 + 8 = 9

        public void AlEnviarStringPorParametro_SeEspera_ConvertirElStringANumeroyRetornarLaSuma(string number, int resultado)
        {
            //Arrange (Preparacion)


            //Act
            int res = CalculadoraStrings.add(number);


            //Assert _(asertar el error)

            Assert.AreEqual(resultado, res);
        }

        /*[DataTestMethod]
        [DataRow("0", 0)] // Caso 1: "0" = 0
        [DataRow("3\n2,3", 8)] // Caso 2: "1" = 1
        [DataRow("1\n 1,8", 10)]  // Caso 3: "1,8" -> Sumar 1 + 8 = 9*/


       /* public void AlEnviarStringsPorParametro_SeEspera_ConvertirElArrayStringANumerosyRetornarLaSuma(string[] numbers, int resultado)
        {
            //Arrange (Preparacion)


            //Act
            int res = CalculadoraStrings.add(numbers);


            //Assert _(asertar el error)

            Assert.AreEqual(resultado, res);
        }*/

        [TestMethod]
       [ExpectedException(typeof(NegativoNoPermitidoException))]
        public void AlEnviarNegativoPorParametro_ValidarQueLanceExcepcion_DeberiaLanzarNegativoNoPermitidoException()
        {
            //Arrange (Preparacion)


            //Act
            int res = CalculadoraStrings.add("-80");
        }
    }
}
