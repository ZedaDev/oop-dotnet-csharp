using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short _cilindrada;

        public short Cilindrada {
           
            get => _cilindrada;
            set
            {
                _cilindrada = value;
            }
        }

        public MotoCross(short number, string escuderia)
            : base(number, escuderia)
        {

        }
        public MotoCross(short number, string escuderia, short cilindrada)
                 : this(number, escuderia)        
        {
            _cilindrada = cilindrada;
        }

        public static bool operator ==(MotoCross m, MotoCross m1)
        {
            if (ReferenceEquals(m, m1)) return true;

            if (m is null || m1 is null) return false;

            return m.Cilindrada == m1.Cilindrada;
        }
        public static bool operator !=(MotoCross m, MotoCross m1)
        {
            return !(m == m1);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Moto Cilindrada : {Cilindrada}");
            sb.AppendLine($"{base.MostrarDatos()}");


            return sb.ToString();
        }
    }
}
