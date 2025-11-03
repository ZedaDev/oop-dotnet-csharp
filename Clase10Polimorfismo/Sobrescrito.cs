using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10Polimorfismo
{
    public abstract class Sobrescrito
    {
        protected string _miAtributo;

        protected Sobrescrito()
        {
            _miAtributo = "Probar abstractos";
        }

        protected abstract string MiAtributo { get; }

        public abstract string MiMetodo();

        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }
        
        


        public override bool Equals(object? obj)
        {
            return obj is not null && obj.GetType() == GetType();
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
