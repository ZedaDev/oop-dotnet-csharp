using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IDeportista
    {
        string FullName { get; set; }
        string Apodo { get; set; }
        string Edad { get; set; }
        DateTime FechaDebut { get; set; }
        EDeporte Deporte { get; set; }
        ELadoHabil PhHabil { get; set; }
        string Altura { get; set; }
        string Nacionalidad { get; set; }
        DateTime FechaDeRegistro { get; set; }
        string Usuario { get; set; }
        string Comentario { get; set; }
      

        List<Estadisticas> Estadisticas { get; set; }
    }
}
