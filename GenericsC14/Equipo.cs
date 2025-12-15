using System.Text;

namespace GenericsC14
{
    public abstract class Equipo
    {
        public string _nombre;
        private DateTime _fechaCreacion;

        protected Equipo(string nombre, DateTime fechaCreacion)
        {
            _nombre = nombre;
            _fechaCreacion = fechaCreacion;
        }

        public static bool operator ==(Equipo e, Equipo e1)
        {
            if (ReferenceEquals(e, e1)) return true;

            if (e is null || e1 is null) return false;

            if(e.GetType() == e1.GetType())
            {
                if (e._nombre == e1._nombre && e._fechaCreacion == e._fechaCreacion)
                    return true;
            }

                return false;
        }
        public static bool operator !=(Equipo e, Equipo e1)
        {
            return !(e == e1);
        }

        public string Ficha()
        {
            return $"{_nombre} fundado el {_fechaCreacion.ToString("dd-MM-yyyy")}";
        }


    }
}