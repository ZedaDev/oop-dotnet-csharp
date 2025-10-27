using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades_8;

namespace Clase9Herencia.Clases
{
    public class Jugador : Persona
    {


        private int _partidosJugados;
        private int _totalGoles;

        public int PartidosJugados
        {
            get => _partidosJugados;

            set
            {
                _partidosJugados = value;
            }
        }

        public int GolesTotales
        {
            get => _totalGoles;

            set
            {
                _totalGoles = value;
            }
        }

        public float PromedioGoles
        {
            get
            {
                if (_partidosJugados > 0)
                    return (float)_totalGoles / _partidosJugados;

                else
                    return 0;
            }
        }
        /*private Jugador()
        {
            _promedioGoles = 0;
        }*/
        public Jugador(int dni, string nombre)
            : base(dni, nombre)
        {
        }

        public Jugador(int dni, string nombre, int totalGoles, int partidosJugados)
            : this(dni, nombre)
        {
            _totalGoles = totalGoles;
            _partidosJugados = partidosJugados;
        }


        public string MostrarDatos()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{base.MostrarDatos()}");
            sb.AppendLine($"Partidos Jugados : {PartidosJugados}");
            sb.AppendLine($"Goles : {GolesTotales}");
            sb.AppendLine($"Promedio De Gol : {PromedioGoles:0.00}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {

            if (ReferenceEquals(j1, j2)) return true;
            if (j1 is null || j2 is null) return false;

            return j1.Dni == j2.Dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
