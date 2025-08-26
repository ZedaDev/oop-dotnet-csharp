using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase002.Ejercicios
{
    /*Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:

  public double CalcularAreaCuadrado(double longitudLado) {}

  public double CalcularAreaTriangulo(double base, double altura) {}

  public double CalcularAreaCirculo(double radio) {}

 El ingreso de los datos como la visualización se deberán realizar desde el método Main().
*/
    internal class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return (longitudLado  * longitudLado);
        }

        public static double CalcularAreaTriangulo(double baseArea, double altura)
        {
            return (baseArea * altura) / 2;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            return (Math.PI * Math.Pow(radio, 2));
        }

    }
}
