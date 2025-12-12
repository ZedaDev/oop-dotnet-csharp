using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase12UnitTest
{

    [TestClass]
    public class ParadEnBoxesTest
    {

        /*Crear un test unitario que valide que la lista de vehículos de la competencia
         * esté instanciada al crear un nuevo objeto.*/
        [TestMethod]
        public void AlCrearUnObjetoCompetencia_ValidarQueLaListaVehiculosEsteInstanciada_DeberiaRetornarTrue()
        {
            //Arrange
            Competencia carrera = new(11, 22, ECompetencia.F1);

            //Act

            Assert.IsNotNull(carrera.Vehiculos);
            //Assert
        }

        /*Realizar un test unitario que controle que la excepción CompetenciaNoDisponible se lance
         * al querer cargar un AutoF1 en una competencia del tipo MotoCross.*/
        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void AlCargarUnAutoF1EnUnaCompetenciaDelTipoMotoCross_ValidarQueLanceExcepcion_DeberiaLanzarCompetenciaNoDisponibleExcepcion()
        {
            //Arrange
            Competencia carrera = new(11, 22, ECompetencia.MotocCross);
            AutoF1 a8 = new(8, "Audi");
            //Act
            bool ok = carrera + a8;
            
        }

    }
}
