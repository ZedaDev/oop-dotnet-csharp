using GenericsC14.E2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Clase14Generics
{
    public class Ejercicio2
    {
        public void Ejecutar()
        {
            Documento recibo1 = new Recibo();
            Documento factura1 = new Factura(11);

            Contabilidad<Documento, Recibo> registro = new();

            registro = registro + recibo1;
            registro  = registro + factura1;

            foreach(var value in registro.Egresos)
            {
                Console.WriteLine($"{value._numero} Egreso");
            }

            foreach(var value in registro.Ingresos)
            {
                Console.WriteLine($"{value._numero} - Ingreso");
            }
        }
    }
}
