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
        DateTime Fecha { get; set; }
        string Rival { get; set; }
        string Competicion { get; set; }
        string Estadio { get; set; }
        string Comentario { get; set; }
        DateTime FechaDeRegistro { get; set; }
        string Usuario { get; set; }
        EResultado Score { get; set; }
        string club { get; set; }
            
        int Id { get; set; }
    }
}
