using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class Jugador
    {

        private int _dni;
        private string _nombre;
        private int _partidosJugados;
       // private float _promedioGoles;
        private int _totalGoles;

        public int PartidosJugados
        {
            get => _partidosJugados;
        }
        /*public float PromedioGoles
        {
            get => _promedioGoles;
        }*/
        public int GolesTotales
        {
            get => _totalGoles;
        }
        public string Nombre
        {
            get => _nombre;

            set
            {
                _nombre = value;
            }
        }
        public string Dni
        {
            get => _dni.ToString();

            set
            {
                int.TryParse(value, out _dni);
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
        {
            _dni = dni;
            _nombre = nombre;
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
            sb.AppendLine($"Nombre : {Nombre}");
            sb.AppendLine($"Dni : {Dni}");
            sb.AppendLine($"Partidos Jugados : {PartidosJugados}");
            sb.AppendLine($"Goles : {GolesTotales}");
            sb.AppendLine($"Promedio De Gol : {PromedioGoles:0.00}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {

            if (ReferenceEquals(j1, j2)) return true;
            if(j1 is null || j2 is null) return false;

            return j1._dni == j2._dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);        
        }
    }
}
