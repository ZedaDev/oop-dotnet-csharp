using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Clase002.Ejercicios
{

    internal static class Ejercicio4
    {
        public static void ejecutar()
        {
            /*Realizar un programa que permita realizar operaciones matemáticas simples
            (suma, resta, multiplicación y división).

              Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

            Calcular (público): Recibirá tres parámetros, el primer operando,
            el segundo operando y la operación matemática. El método devolverá el resultado
            de la operación.

              Validar (privado): Recibirá como parámetro el segundo operando.
            Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
            Este método devolverá true si el operando es distinto de cero.

              Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar
            (ingresando el caracter +, -, * o /).

             El usuario decidirá cuándo finalizar el programa.*/
                Console.Title = "Calculadora Simple";
            do
            {
                Console.WriteLine("Ingrese dos numeros y Operacion Matematica('+' '-' '*' '/')");
                int numero = Validador.PedirYValidarNumeroEntero();
                int numero2 = Validador.PedirYValidarNumeroEntero();
                Console.WriteLine("Ingrese La Operacion Matematica");
                string? opMat = Console.ReadLine();
                int resultado = Calculadora.Calcular(numero, numero2, opMat);

                if (resultado != 0)Console.WriteLine($"{numero} {opMat} {numero2} = {resultado}");
                else Console.WriteLine("ERROR");
            }while(Validador.ValidarRespuesta());
            

        }

        
    }
}
