using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class Cuenta
    {
        public string titular;
        public decimal cantidadDinero;

        public Cuenta(string titular, decimal cantidadDinero)
        {
            this.titular = titular;
            this.cantidadDinero = cantidadDinero;
        }
       
        /// <summary>
        /// Devuelve el Nombre del Titular de la Cuenta
        /// </summary>
        /// <returns>Retorna el Nombre del TItular, formato String</returns>
        public string GetTitular() {
            return titular;
        }

        /// <summary>
        /// Devuelve el Saldo Actual De La Cuenta
        /// </summary>
        /// <returns>Retorna el Saldo Actual de La Cuenta, Formato Decimal</returns>
        public decimal GetSaldo()
        {
            return cantidadDinero;
        }

        /// <summary>
        /// Muestra el Titular y, el Saldo De la Cuenta
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            return $"Titular : {titular}\n Saldo : {cantidadDinero}";
        }

        /// <summary>
        /// Ingresa Saldo a la Cuenta
        /// </summary>
        /// <param name="saldo">Saldo a ingresar en la Cuenta</param>
        public void IngresarSaldo(decimal saldo)
        {
            if(saldo > 0)
            {
                this.cantidadDinero += saldo;
                Console.WriteLine($"Ingreso Exitoso\n Saldo Actual : {cantidadDinero:F2}");
            }
        }

          /// <summary>
          /// Retira Saldo de la Cuenta, La cuenta puede quedar en saldo negativo
          /// </summary>
          /// <param name="monto">Numero Total a Retirar</param>
        public void Retirar(decimal monto)
        {
            this.cantidadDinero -= monto;
            if (cantidadDinero < 0) Console.WriteLine($"Su cuenta quedo en negativo : {cantidadDinero:F2}");
            else Console.WriteLine($"Retiro exitoso\n Saldo Actual :{cantidadDinero:F2}");
        }

    }
}
