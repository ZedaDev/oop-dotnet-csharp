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
            Competencia<AutoF1> carrera = new(11, 22, ECompetencia.F1);

            //Act

            Assert.IsNotNull(carrera.Vehiculos);
            //Assert
        }

        /*Realizar un test unitario que controle que la excepción CompetenciaNoDisponible se lance
         * al querer cargar un AutoF1 en una competencia del tipo MotoCross.
        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void AlCargarUnAutoF1EnUnaCompetenciaDelTipoMotoCross_ValidarQueLanceExcepcion_DeberiaLanzarCompetenciaNoDisponibleExcepcion()
        {
            //Arrange
            Competencia<MotoCross> carrera = new(11, 22, ECompetencia.MotocCross);
            MotoCross a8 = new (8, "Audi", 250);

            //Act
            bool ok = carrera + a8;


            
        }*/
        [TestMethod]
        public void AlCargarUnNuevoCorredorNuevo_ValidarQueSeAgregueEnLaLista_DeberiaRetornarTrue()
        {
            //Arrange
            Competencia<MotoCross> carrera = new(11, 22, ECompetencia.MotocCross);
            MotoCross a8 = new (8, "Audi", 250);

            //Act
            bool ok = carrera + a8;
            bool ok3 = carrera + a8;

            Competencia<AutoF1> carrera1 = new(11, 22, ECompetencia.F1);
            AutoF1 a9 = new (8, "Audi");

            //Act
            bool ok1 = carrera1 + a9;
            bool ok2 = carrera1 + a9;
         

            Assert.IsTrue(ok);
            Assert.IsTrue(ok1);
            Assert.IsFalse(ok2);
            Assert.IsFalse(ok3);
            
        }

        /*Comprobar que al cargar un nuevo vehículo en la competencia este figure en la lista.
         * Utilizar el operador + y el ==.
*/

        [TestMethod]
        public void AlCargarUnNuevoVehiculoALaCompetencia_SiEstaEnLaLista_DeberiaLanzarCompetenciaNoDispoNibleException()
        {
            //Arrange
            Competencia<AutoF1> carrera = new(11, 22, ECompetencia.F1);
            AutoF1 a8 = new(8, "Audi");
            //Act
            bool ok = carrera + a8;

                ok = carrera == a8;

            Assert.IsTrue(ok);
             
        }

        /*Comprobar que al quitar un vehículo existente en la competencia
         * este ya no figure en la lista.
        Utilizar el operador - y el !=.*/

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void AlQuitarUnVehiculoDeLaCompetencia_Validar_DeberiaRetornarTrueAlEliminarlo()
        {
            //Arrange
            Competencia<AutoF1> carrera = new(11, 22, ECompetencia.F1);
            AutoF1 a8 = new(8, "Audi");
            //Act
            carrera.Vehiculos.Add(a8);

            bool ok1 = carrera - a8;
            bool ok = carrera != a8;
            bool ok2 = carrera == a8;

            Assert.IsTrue(ok1);
            Assert.IsTrue(ok);
            Assert.IsFalse(ok2);

        }
    }
}
