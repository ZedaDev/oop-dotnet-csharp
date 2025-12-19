using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IFutbolista : IDeportista
    {
        string Posicion { get; set; }
        string ClubActual { get; set; }
    }
}
