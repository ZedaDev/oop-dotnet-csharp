using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IEstadistica
    {
        string Deportista { get; set; }
        string Resultado { get; set; }
        string Fecha { get; set; }
        string Rival { get; set; }
        string Competicion { get; set; }
        string Estadio { get; set; }
        string Comentario { get; set; }
        string FechaDeRegistro { get; set; }
        string Usuario { get; set; }
    }
}
