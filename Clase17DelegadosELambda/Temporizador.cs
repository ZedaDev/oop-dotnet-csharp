using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17DelegadosELambda
{
    public class Temporizador
    {
       public  static void Esperar(int mSegundos, DSaludar delegado)
        {
            Thread.Sleep(mSegundos);
            delegado();
        }
       public  static void Esperar(int mSegundos, DSaludarConMSegundos delegado)
        {
            Thread.Sleep(mSegundos);
            delegado.Invoke(mSegundos);
        }


    }
}
