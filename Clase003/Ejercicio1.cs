using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase003
{
    public class Ejercicio1
    {

        public void Ejecutar()
        {
            Console.Title = "Cuenta Bancaria";

            Console.WriteLine($"Bienvenido, Cree Su Cuenta Para Continuar");
            Console.WriteLine("Nombre : ");string? nombre = Console.ReadLine();
            Console.WriteLine("Indique Saldo : ");
            decimal saldo = Validador.PedirYValidarNumeroEntero();
            Cuenta MiCuenta = new Cuenta(nombre, saldo);
            do
            {
                Console.WriteLine($"Seleccione opcion\n1. Mostrar Cuenta\n2.Retirar\n3. Depositar\n");
                int opcion = Validador.PedirYValidarNumeroEntero();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(MiCuenta.Mostrar());
                        break;
                    case 2:
                        MiCuenta.Retirar(SaldoIngresarRetirar("Ingrese Saldo a Retirar: "));
                        break;
                    case 3:
                        MiCuenta.IngresarSaldo(SaldoIngresarRetirar("Ingrese Saldo a Depositar"));
                        break;
                }


                Console.WriteLine($"TITULAR : {MiCuenta.GetTitular()}\n SALDO :  {MiCuenta.GetSaldo()}");
            } while (Validador.ValidarRespuesta());
            
        }

        private decimal SaldoIngresarRetirar(string mensaje)
        {
            Console.Clear();
            Console.WriteLine(mensaje);
            decimal retirar = Validador.PedirYValidarNumeroEntero();
            return retirar;
        }
    }
}
