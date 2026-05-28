namespace Entities
{
    public interface IRepository<T>
    {
        public List<T> ObtenerLista(int userId, T value);
        public bool Insertar(T value,int userId);
        public bool Eliminar(T value, int userId);
        public bool Modificar(T value, int userId);
    }
}