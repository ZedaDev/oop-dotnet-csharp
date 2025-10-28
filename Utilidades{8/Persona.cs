using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public  class Persona
    {
        private long _dni;
        private string _name;

        public Persona(long dni, string name)
        {
            _dni = dni;
            _name = name;
        }
        public Persona(string name)
        {
            _name = name;
        }

        public long Dni 
        { 
            get => _dni;

            set
            {

                //Logica de validacion
                _dni = value;
            }
        }
        public string Name 
        { 
            get => _name; 

            set
            {
                //Logica de validacion
                _name = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Nombre : {Name}");
            sb.AppendLine($"Dni : {Dni}");
                return sb.ToString();
        }
    }
}
