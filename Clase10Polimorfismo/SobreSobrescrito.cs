using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10Polimorfismo
{
    public class SobreSobrescrito : Sobrescrito
    {

        public SobreSobrescrito() : base()
        {
        }

        protected override string MiAtributo
        {
            get
            {
                return base._miAtributo;
            }
        }
        public override string MiMetodo()
        {
            return MiAtributo;
        }
    }
}
