using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengerMarvel
{
    public class Avenger : Personaje
    {
        private EEquipamiento _equipamiento;

        public Avenger(string name, List<EHabilidades> habilidades, EEquipamiento equipamiento)
                   : base(name, habilidades)       
        {
            _equipamiento = equipamiento;
        }
        public string Nombre
        {
            get
            {
                return $"Mi nombre es {base._name} y si no puedo proteger la tierra, la vengaré";
            }
        }


        public string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{base.Mostrar()}\n");
            sb.AppendLine($"Nombre : {Nombre}");
            sb.AppendLine($"Equipamiento :\n {_equipamiento.ToString()}");
            return sb.ToString();
        }
    }
}
