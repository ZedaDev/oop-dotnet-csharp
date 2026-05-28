using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IDeportistaRepository : IRepository<Deportista>
    {
        public List<Deportista> ObtenerLista(int userId, Deportista value);

        public bool Insertar(Deportista deportista, int userId);

        public bool Eliminar(Deportista value, int userId);
        public bool Modificar(Deportista value, int userId);

    }


}
