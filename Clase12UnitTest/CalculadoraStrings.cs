using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12UnitTest
{
    public static class CalculadoraStrings
    {


        public static int add(string numbers)
        {

                  if(string.IsNullOrEmpty(numbers.Trim()))
                        return 0;

                  else if(numbers.Contains(','))
                  {
                    string[] numeros = numbers.Split(',');
                        try
                        {
                            if (numeros.Length > 0)
                            {
                                return int.Parse(numeros[0]) + int.Parse(numeros[1]);
                            }
                            else
                                return int.Parse(numeros[0]);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("No se pudo convertir STRING a INT");
                        }
                  }

            int resultado = int.Parse(numbers);
            if (resultado < 0)
                throw new NegativoNoPermitidoException();

            return resultado;
        }
       /* public static int add(params string[] numbers)
        {

                  if(string.IsNullOrEmpty(numbers.Trim()))
                        return 0;
                  else if(numbers.Contains(','))
                  {
                    string[] numeros = numbers.Split(',');
                        try
                        {
                            if (numeros.Length > 0)
                            {
                                return int.Parse(numeros[0]) + int.Parse(numeros[1]);
                            }
                            else
                                return int.Parse(numeros[0]);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("No se pudo convertir STRING a INT");
                        }
                  }

            return int.Parse(numbers) == 0 ? 0 : int.Parse(numbers);
        }*/
    }
}
