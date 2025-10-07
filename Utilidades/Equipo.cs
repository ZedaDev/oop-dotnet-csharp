using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class Equipo
    {

        private short _cantidadDeJugadores;
        private List<Jugador> _jugadores;
        private string _nombre;

        public Equipo(short cantidadDeJugadores, string nombre)
            : this()
        {
            _cantidadDeJugadores = cantidadDeJugadores;
            _nombre = nombre;
        }
        private Equipo()
        {
            _jugadores = new List<Jugador>();
        }


        public static bool operator +(Equipo e, Jugador j)
        {
            bool r = true;
            if ( e._jugadores.Count() < e._cantidadDeJugadores)
            {
                foreach (Jugador value in e._jugadores)
                {
                    if (value == j)
                        r = false;
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
