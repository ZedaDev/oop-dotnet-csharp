using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengerMarvel
{
    public static class Marvel
    {
        private static List<Personaje> _personajes;

        static Marvel()
        {
            Marvel._personajes = new();
        }

        public static Personaje Personaje
        {
            set
            {
                if (_personajes != value)
                   _personajes = _personajes + value;
            }
        }


        public static  string MetodoMostrarInformacion()
        {
            StringBuilder sb = new();
            foreach (Personaje value in _personajes)
            {
                if(value.GetType() == typeof(Avenger))
                {
                    sb.AppendLine("****** AVENGER ******");
                    sb.AppendLine($"{((Avenger)value).Mostrar()}");
                }else if(value.GetType() == typeof(Enemigo))
                {
                    sb.AppendLine("****** ENEMIGO ******");
                    sb.AppendLine($"{((Enemigo)value).Mostrar()}");
                }
            }

            return sb.ToString();
        }
    }
}
