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
        private float _promedioGoles;
        private int _totalGoles;


        private Jugador()
        {
            _promedioGoles = 0;
        }
        public Jugador(int dni, string nombre)
           : this()
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

        public float GetPromedioGoles()
        {
            if(_partidosJugados > 0)
                _promedioGoles = (float)_totalGoles / _partidosJugados;

            return _promedioGoles;
        } 

        public string MostrarDatos()
        {
            StringBuilder sb = new();
            GetPromedioGoles();
            sb.AppendLine($"Nombre : {_nombre}");
            sb.AppendLine($"Dni : {_dni}");
            sb.AppendLine($"Partidos Jugados : {_partidosJugados}");
            sb.AppendLine($"Goles : {_totalGoles}");
            sb.AppendLine($"Promedio De Gol : {this.GetPromedioGoles():0.00}");

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
