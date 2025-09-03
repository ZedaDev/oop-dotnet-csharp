using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;
namespace Clase003
{
    internal class Ejercicio5
    {
        public void ejecutar()
        {

            Punto pr = new Punto(10, 11);
            Punto pr1 = new Punto(8, 9);
            Rectangulo rectangulo = new Rectangulo(pr, pr1);

            mostrarRectangulo(rectangulo);
        }

        private void mostrarRectangulo(Rectangulo rectangulo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Vértices del rectángulo:");
            sb.AppendLine($"Vértice 1: ({rectangulo.GetVertice1().GetX()}, {rectangulo.GetVertice1().GetY()})");
            sb.AppendLine($"Vértice 2: ({rectangulo.GetVertice2().GetX()}, {rectangulo.GetVertice2().GetY()})");
            sb.AppendLine($"Vértice 3: ({rectangulo.GetVertice3().GetX()}, {rectangulo.GetVertice3().GetY()})");
            sb.AppendLine($"Vértice 4: ({rectangulo.GetVertice4().GetX()}, {rectangulo.GetVertice4().GetY()})");
            sb.AppendLine($"Área: {rectangulo.GetArea()}");
            sb.AppendLine($"Perímetro: {rectangulo.GetPerimetro()}");

            Console.WriteLine(sb.ToString());
        }
    }
}
