using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralTelefonica;
using Exceptions;
namespace Clase12UnitTest
{
    [TestClass]
    public class CentralitaTest
    {

        /*Crear un test unitario que valide que la lista de llamadas de la centralita 
         * esté instanciada al crear un nuevo objeto del tipo Centralita.*/
        [TestMethod]

        public void AlCrearUnNuevoObjetoCentralita_ValidarLaInstanciaDeLaListaDeLLamadas_DeberiaRetornarTrue()
        {
            //Arrange
            Centralita obj = new("El Don");
            //ACT

            bool resultado = obj.Llamadas != null;
            //Assert
            Assert.IsTrue(resultado);
        }

        /*Controlar mediante un nuevo método de test unitario que la excepción CentralitaException
         * se lance al intentar cargar una segunda llamada con solamente los mismos datos de origen
         * y destino de una llamada Local ya existente.*/

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void AlCargarCargarLLamadaLocalConMismosDatos_ControlarQueCentralitaExceptionSeaLanzada_DeberiaLanzarCentralitaException()
        {
            //Arrange
            Centralita obj = new("El Don");
            Local ll1 = new("Buenos Aires", 1.50f, "La Plata", 5.80f);
            Local ll2 = new("Buenos Aires", 1.80f, "La Plata", 5.90f);
            //ACT

            obj = obj + ll1;
            obj = obj + ll2;

        }

        /*Dentro de un método de test unitario crear dos llamadas Local y dos Provincial,
         * todos con los mismos datos de origen y destino. Luego comparar cada uno de estos
         * cuatro objetos contra los demás, debiendo ser iguales solamente las instancias
         * de Local y de Provincial entre sí.*/
        [TestMethod]
       
        public void AlCrearDosLlamadasConMismosDatosDeLocalYProvincial_CompararCadaUnaEntreSi_DereberiaRetornarTrueSiSonDelMismoTipoFalseEnCasoContrario()
        {
            //Arrange
            Llamada provincial1 = new Provincial(1.50f, "11445588", "11554488", EFranja.Franja_1);
            Llamada provincial2 = new Provincial(1.80f, "11445588", "11554488", EFranja.Franja_2);

            Llamada local1 = new Local("11445588", 1.50f, "11554488", 5.80f);
            Llamada local2 = new Local("11445588", 1.80f, "11554488", 5.90f);

            //ACT

            bool resultado1 = provincial1 == local1; 
            bool resultado2 = local1 == local2; 
            bool resultado3 = provincial1 == provincial2; 
            bool resultado4 = provincial2 == local2;

            // Assert
          
            Assert.IsTrue(provincial1 == provincial2);  
            Assert.IsTrue(local1 == local2); 
            Assert.IsFalse(provincial1 == local1); 
            Assert.IsFalse(local1 == provincial1); 
            Assert.IsFalse(provincial1 == local2);  
          


        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void AlCargarCargarDosLLamadasProvincialConMismosDatos_ControlarQueCentralitaExceptionSeaLanzada_DeberiaLanzarCentralitaException()
        {
            //Arrange
            Centralita obj = new("El Don");
            Provincial ll1 = new(1.50f, "11445588", "11554488", EFranja.Franja_1);
            Provincial ll2 = new(1.80f, "11445588", "11554488", EFranja.Franja_2);
            //ACT

            obj = obj + ll1;
            obj = obj + ll2;

        }
    }
}
