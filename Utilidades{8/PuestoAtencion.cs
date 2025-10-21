using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Utilidades_8
{
    internal class PuestoAtencion
    {
        private static int _ActualNumber;
        private Puesto _puesto;

        public PuestoAtencion(Puesto puesto)
            : this()
        {
            _puesto = puesto;
        }
        private PuestoAtencion()
        {
            _ActualNumber = 0;
        }

        public static int ActualNumber
        {
            get { return ++_ActualNumber; }
        }


        public bool Atender(Cliente cli)
        {
            Thread.Sleep(1100);
            return true;
        }

    }
}
