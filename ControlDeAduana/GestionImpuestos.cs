using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAduana
{
    public class GestionImpuestos
    {
        private List<IAduana> _impuestosAduana;
        private List<IAfip> _impuestosAfip;

        public GestionImpuestos()
        {
            _impuestosAduana = new();
            _impuestosAfip = new();
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal res = 0;
            foreach (var value in _impuestosAduana)
            {
                res += value.Impuestos;
            }
            return  res;
        }
        public decimal CalcularTotalImpuestosAfip()
        {
            decimal res = 0;
            foreach (IAfip value in _impuestosAfip)
            {
                res += value.Impuestos;
            }
            return res;
        }
        public void GestionarImpuestos()
        {
        }
        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            foreach (Paquete value in paquetes)
            {
                RegistrarImpuestos(value);
            }
        }
        public void RegistrarImpuestos(Paquete paquete)
        {
            _impuestosAduana.Add(paquete);
            if(paquete is PaquetePesado paquetePesado)
            {
                _impuestosAfip.Add(paquetePesado);
            }
        }

    }
}
