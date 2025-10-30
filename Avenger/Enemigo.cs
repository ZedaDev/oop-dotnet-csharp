using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengerMarvel
{
    public class Enemigo : Personaje
    {
        private string _objetivo;

        public Enemigo(string name, List<EHabilidades> habilidades, string objetivo)
                  : base(name, habilidades)
        {
            _objetivo = objetivo;
        }
        public string Nombre
        {
            get
            {
                return $"Soy {base._name} y los voy a hacer puré";
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{base.Mostrar()}\n");
            sb.AppendLine($"Nombre : {Nombre}");
            sb.AppendLine($"Objetivo :\n {_objetivo}");
            return sb.ToString();
        }
    }
}
