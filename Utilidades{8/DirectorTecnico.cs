using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public class DirectorTecnico : Persona
    {
        private DateTime _FechaNacimiento;

        public DirectorTecnico(string name, DateTime fechaNacimiento)
            : this(name)
        {
            FechaNacimiento = fechaNacimiento;
        }
        private DirectorTecnico(string name)
            : base(name)
        {
        }

        public DateTime FechaNacimiento 
        { 
            get => _FechaNacimiento;
            set => _FechaNacimiento = value; 
        }

        public static bool operator ==(DirectorTecnico t, DirectorTecnico t1)
        {
            if(ReferenceEquals(t, t1)) return true;

            if (t is null || t1 is null) return false;

                return t.Name == t1.Name;
        }
        public static bool operator !=(DirectorTecnico t, DirectorTecnico t1)
        {
                return !(t.Name == t1.Name); 
        }

    }
}
