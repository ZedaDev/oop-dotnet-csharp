using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IFutbolistaRepository : IRepository<Futbolista>
    {
        public List<Futbolista> ObtenerLista(int userId, Futbolista value);

        public bool Insertar(Futbolista deportista, int userId);

        public bool Eliminar(Futbolista value, int userId);
    }
}
