using System.Text;

namespace GenericsC14.E1
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> _equipos;
        public string _nombre;

        public Torneo(string nombre)
        {
            _equipos = new();
            _nombre = nombre;
        }

        public string JugarPartido
        {
            get
            {
                Random random = new();
                int equipo1 = random.Next(0, _equipos.Count);
                int equipo2 = random.Next(0, _equipos.Count);
                while (equipo1 == equipo2)
                {
                    equipo2 = random.Next(0, _equipos.Count);
                }

               
                string resultadoPartido = CalcularPartido(_equipos[equipo1], _equipos[equipo2]);
                return resultadoPartido;
            }
        }
        public static bool operator ==(Torneo<T> t, T equipo)
        {

            foreach (T value in t._equipos)
            {
                if (value == equipo)
                    return true;
            }

            return false;
        }
        public static bool operator !=(Torneo<T> t, T equipo)
        {
            return !(t == equipo);
        }
        public static bool operator +(Torneo<T> t, T equipo)
        {
            if(t is not null && equipo is not null)
            {
                if(t != equipo)
                {
                    t._equipos.Add(equipo);
                    return true;
                }
            }

            return false;
        }
        public string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"[DATOS DEL TORNEO {_nombre}]");
            foreach (T value in _equipos)
            {
                sb.AppendLine($"{value.Ficha()}");
            }

            return sb.ToString();
        }

        private string CalcularPartido(T e1, T e2)
        {
            Random random = new();
            int equipo1 = random.Next(0, 5);
            int equipo2 = random.Next(0, 5);

            return $"{e1._nombre} {equipo1} – {e2._nombre} {equipo2}";
        }
    }
}
