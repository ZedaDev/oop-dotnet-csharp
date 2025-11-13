using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class Deportista
    {
        private string _fullName;
        private string _apodo;
        private int _edad;
        private DateTime _fechaDebut;
        private EDeporte _Edeporte;
        private string _phHabil;
        private string _altura;
        private List<Estadisticas> _stats;

        #region Contructores
        protected Deportista(string fullName, int edad, DateTime fechaDebut, EDeporte deporte, string phHabil, string altura)
            : this(fechaDebut, deporte)
        {
            _edad = edad;
            _fullName = fullName;
            _altura = altura; 
            _phHabil = phHabil;
        }
        private Deportista(DateTime fechaDebut, EDeporte deporte)
            : this()
        {
            _fechaDebut = fechaDebut;
            _Edeporte = deporte;

        }
        private Deportista()
        {
            _stats = new();
        }

        #endregion

        #region Properties
        public List<Estadisticas> Estadisticas
        { 
            get => _stats;
            set
            {
                if(value is not null)
                    _stats = value;
            }
        }
        public Estadisticas AgregarEstadistica
        { 
            set
            {
                if (value is not null && !(_stats.Contains(value)))
                    _stats.Add(value);
            }
        }

        public string FullName
        { 
            get => _fullName;
            set
            {
                _fullName = value;
            }
        }
        public string Apodo
        { 
            get => _apodo;
            set
            {
                _apodo = value;
            }
        }
        public int Edad
        {
            get => _edad;
            set
            {
                _edad = value;
            }
        }
        protected DateTime FechaDebut
        {
            get => _fechaDebut;
            set
            {
                _fechaDebut = value;
            }
        }

        public EDeporte Deporte
        {
            get => _Edeporte;
            set
            {
                _Edeporte = value;
            }
        }

        public string PhHabil 
        { 
            get => _phHabil;
        }
        public string Altura 
        { 
            get => _altura;
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Deportista d, Deportista d1)
        {
            if (ReferenceEquals(d, d1)) return true;

            if (d is null || d1 is null) return false;

            return d.FullName == d1.FullName && d.GetType() == d1.GetType();
        }
        public static bool operator !=(Deportista d, Deportista d1)
        {
            return !(d == d1);
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object? obj)
        {
            return this == ((Deportista)obj);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(FullName, GetType());
        }

        #endregion


        //Agregar Metodo Abstracto.


        protected virtual string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Nombre Completo : {FullName}");
            sb.AppendLine($"Edad : {Edad}");
            sb.AppendLine($"Debut Deportivo : {FechaDebut}");
            sb.AppendLine($"Deporte : {_Edeporte.ToString()}");
                 return sb.ToString();
        }


          
    }
}
