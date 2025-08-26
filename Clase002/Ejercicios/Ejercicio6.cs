using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase002.Ejercicios
{
    internal class Ejercicio6
    {

      /*Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:

        public double CalcularAreaCuadrado(double longitudLado) {}

        public double CalcularAreaTriangulo(double base, double altura) {}

        public double CalcularAreaCirculo(double radio) {}

       El ingreso de los datos como la visualización se deberán realizar desde el método Main().
      */
        public static void ejecutar()
        {

            Console.WriteLine("Longitud De Un Lado : ");
           double cuadradoArea = CalculadoraDeArea.CalcularAreaCuadrado(Validador.PedirYValidarNumeroEntero());

            Console.WriteLine("Radio : ");
           double circuloArea = CalculadoraDeArea.CalcularAreaCirculo(Validador.PedirYValidarNumeroEntero());


            Console.WriteLine("Longitud De La Base y Altura : ");
           double trianguloArea = CalculadoraDeArea.CalcularAreaTriangulo(Validador.PedirYValidarNumeroEntero(), Validador.PedirYValidarNumeroEntero());

            Console.Clear();
            Console.WriteLine($@"
Area Del Cuadrado : {cuadradoArea}
Area Del Circulo : {circuloArea:f2}
Area Del Triangulo : {trianguloArea}");
        }
    }
}
