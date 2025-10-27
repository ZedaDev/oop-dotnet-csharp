using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9Herencia.Clases
{
    public class Team       
    {

        private short _cantidadDeJugadores;
        private List<Jugador> _jugadores;
        private string _nombre;

        public Team(short cantidadDeJugadores, string nombre)
            : this()
        {
            _cantidadDeJugadores = cantidadDeJugadores;
            _nombre = nombre;
        }
        private Team()
        {
            _jugadores = new List<Jugador>();
        }

        public void MostrarTeam()
        {

            foreach (Jugador player in _jugadores)
            {
                Console.WriteLine($"{player.MostrarDatos()}");
            }
        }
        public static bool operator +(Team e, Jugador j)
        {
            bool r = true;
            if (e._jugadores.Count() < e._cantidadDeJugadores)
            {
                foreach (Jugador value in e._jugadores)
                {
                    if (value == j)
                    {
                        r = false;
                        break;
                    }
                }

                if (r)
                {
                    e._jugadores.Add(j);
                }
            }

            return r;
        }

    }
}
