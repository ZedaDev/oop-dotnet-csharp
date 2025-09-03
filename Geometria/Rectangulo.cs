using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {

        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());

            float baseArea = Math.Abs(vertice1.GetX() - vertice3.GetX());
            int altura = Math.Abs(vertice1.GetY() - vertice3.GetY());

            this.area = baseArea * altura;
            this.perimetro = (float)2 * (baseArea + altura);
        }

        public float GetArea() => this.area;
        public float GetPerimetro() => this.perimetro;

        public Punto GetVertice1() => this.vertice1;
        public Punto GetVertice2() => this.vertice2;
        public Punto GetVertice3() => this.vertice3;
        public Punto GetVertice4() => this.vertice4;

    }
}
