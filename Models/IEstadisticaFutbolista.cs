using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IEstadisticaFutbolista : IEstadistica
    {
        bool Titular { get; set; }
        string Goles { get; set; }
        string Asistencias { get; set; }
        string MinutosJugados { get; set; }
        string TarjetaAmarilla { get; set; }
        bool TarjetaRoja { get; set; }
        string GolesTiroLibre { get; set; }
        string GolesPenal { get; set; }
    }
}
