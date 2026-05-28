
namespace Entities
{
    internal static class RepositoryFactory
    {
        private static readonly Dictionary<Type, object> _repositories = new Dictionary<Type, object>();

        static RepositoryFactory()
        {
            // Registra repositorios para diferentes tipos
            _repositories[typeof(Futbolista)] = new FutbolistaRepository();
            //_repositories[typeof(Boxeador)] = new BoxeadorRepository();
            // Agrega más repositorios aquí según sea necesario
        }

        // Devuelve el repositorio correspondiente para el tipo T
        internal static IRepository<T> CreateRepository<T>() where T : Deportista, new()
        {
            var type = typeof(T);

            if (_repositories.ContainsKey(type))
            {
                return _repositories[type] as IRepository<T>;
            }

            throw new Exception($"Repositorio no encontrado para el tipo {type}");
        }
    }
    }