using System.Numerics;
using System.Text;

namespace AvengerMarvel
{
    public class Personaje
    {
        private List<EHabilidades> _listaHabilidades;
        protected string _name;

        private Personaje()
        {
            _listaHabilidades = new();
        }
        public Personaje(string name, List<EHabilidades> habilidades)
            : this()
        {
            _name = name;
            _listaHabilidades = habilidades;
        }
        private string ListaHabilidades 
        {
            get 
            {
                StringBuilder sb = new();
                 sb.AppendLine($"Habilidades :\n");
                foreach (EHabilidades value in _listaHabilidades)
                {
                    sb.AppendLine($"{value.ToString()}");
                }
                return sb.ToString();
            } 
        }


        public static bool operator ==(List<Personaje> personajes, Personaje p)
        {
            foreach (Personaje value in personajes)
            {
                if(value.GetType() == p.GetType() && value._name == p._name )
                {
                        return true;
                }
            }

             return false;
        }

        public static List<Personaje> operator +(List<Personaje> personajes, Personaje p)
        {
            if(personajes != p)
            {
                personajes.Add(p);
            }

            return personajes;
        }
        /*d. La sobrecarga operador + agregará un personaje a la lista de personajes
         * que se pasa por parámetro, siempre y cuando no exista previamente ese personaje
         * en la lista.
        Retornará la lista.*/
        public static bool operator !=(List<Personaje> personajes, Personaje p)
        {
            return !(personajes == p);
        }

        public string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Nombre : {_name}");
            sb.AppendLine($"{ListaHabilidades}");
                return sb.ToString();
        }


    }
}
