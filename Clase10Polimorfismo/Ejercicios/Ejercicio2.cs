using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades_8;

namespace Clase10Polimorfismo.Ejercicios
{
    internal class Ejercicio2
    {
        public void Ejecutar()
        {
            List<Figura> figuras = new();
            figuras.Add(new Rectangulo(3,5));
            figuras.Add(new Cuadrado(3));
            figuras.Add(new Circulo(5));
            int i = 1;
            StringBuilder sb = new();
            foreach (Figura value in figuras)
            {
                sb.AppendLine($"=============== FIGURA {i:D2} ==================");
                sb.AppendLine($"{value.GetType().Name}");
                sb.AppendLine($"{value.Dibujando()}");
                sb.AppendLine($"Superficie : {value.CalcularSuperficie():F2}");
                sb.AppendLine($"Perimetro :  {value.CalcularPerimetro():F2}");
                sb.AppendLine("============================================");
                i++;
            }
            Console.WriteLine($"{sb.ToString()}");
        }
    }
}
