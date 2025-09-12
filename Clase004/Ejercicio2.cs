using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;
namespace Clase004
{
    internal class Ejercicio2
    {
       public void Ejecutar()
        {
            Console.Title = "Cotizador";
            Console.WriteLine("Cuentas De Banco En Pesos, Dolares o Euros");

            Pesos cP = new Pesos(11000);
            Console.WriteLine($".Cuenta De Pesos\nMonto : {cP.GetAmount()}");

            Dolar cD = new Dolar(5000);
            Console.WriteLine($".Cuenta De Dolares\nMonto : {cD.GetAmount()}");

            Euro cE = new Euro(5000);
            Console.WriteLine($".Cuenta De Euros\nMonto : {cE.GetAmount()}");

            Console.WriteLine($"-Cuenta De Pesos a Euros\nMonto en Euros : {((Euro)cP).GetAmount():F2}");

            Console.WriteLine($"-Cuenta De Pesos a Dolares\nMonto en Dolares : {((Dolar)cP).GetAmount():F2}");

            Console.WriteLine($"-Cuenta De Dolares a Euros\nMonto en Euros : {((Euro)cD).GetAmount():F2}");

            Console.WriteLine($".-Euros Menos Pesos : {(cE - cP).GetAmount():f2}");

            Console.WriteLine($".-Euros Menos Dolares : {((Euro)cD).GetAmount():f2}");

            Console.WriteLine($".-Dolares Menos Pesos : {(cD - cP).GetAmount():f2}");

            Console.WriteLine($".-Dolares Mas Euros : {(cD + cE).GetAmount():f2}");

        }
    }
}
