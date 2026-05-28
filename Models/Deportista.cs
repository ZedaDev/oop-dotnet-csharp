using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Entities
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(Futbolista), "Futbolista")]
    public abstract class Deportista : IDeportista
    {
        int _id;
        private string _fullName;
        private string _apodo;
        private string _edad;
        private DateTime _fechaDebut;
        private EDeporte _Edeporte;
        private ELadoHabil _phHabil;
        private string _altura;
        private string _pais;
        private DateTime _fechaDeRegistro;
        private string _usuario;
        private string _comentario;
        private List<Estadisticas> _estadisticas;

        #region Contructores

        [JsonConstructor]
        public Deportista()
        {
            _estadisticas = new();
           
        }

        
        public Deportista(string fullName, string edad, string apodo, DateTime fechaDebut, EDeporte deporte, ELadoHabil phHabil, string altura,string pais, DateTime fechaDeRegistro, string user, string comentario)
            : this(fechaDebut, deporte, pais, user, comentario)
        {
            _edad = edad;
            _fullName = fullName;
            _altura = altura; 
            _phHabil = phHabil;
            _apodo = apodo;
            _fechaDeRegistro = fechaDeRegistro;
            _estadisticas = new();
        }
        private Deportista(DateTime fechaDebut, EDeporte deporte, string pais, string user, string comentario)
            : this()
        {
            _fechaDebut = fechaDebut;
            _Edeporte = deporte;
            _pais = pais;
            _usuario = user;
            _comentario = comentario;
        }

        #endregion

        #region Properties

        
        public List<Estadisticas> Estadisticas
        {
            get => _estadisticas;
            set
            {
                if(value is not null)
                    _estadisticas.AddRange(value);
            }
        }
        public Estadisticas AgregarEstadistica
        { 


            set
            {
                if (value is not null && !(_estadisticas.Contains(value)))
                    _estadisticas.Add(value);
                else
                    throw new Exception("Estadistica NULL o Ya existe en la lista.");
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
        public string Usuario
        { 
            get => _usuario;
            set
            {
                _usuario = value;
            }
        }
        
        public DateTime FechaDeRegistro
        {
            get => _fechaDeRegistro;
            set => _fechaDeRegistro = value;

        }
        public string Apodo
        { 
            get => _apodo;
            set
            {
                _apodo = value;
            }
        }
        public string Edad
        {
            get => _edad;
            set
            {
                _edad = value;
            }
        }
        public string Nacionalidad
        {
            get => _pais;
            set
            {
                _pais = value;
            }
        }
        public DateTime FechaDebut
        {
            get => _fechaDebut;
            set
            {
                
                _fechaDebut = value;
            }
        }
        public string Comentario
        {
            get => _comentario;
            set
            {
                
                _comentario = value;
            }
        }

        [JsonConverter(typeof(JsonStringEnumConverter<EDeporte>))]
        public EDeporte Deporte
        {
            get => _Edeporte;
            set
            {
                _Edeporte = value;
            }
        }
        [JsonConverter(typeof(JsonStringEnumConverter<ELadoHabil>))]
        public ELadoHabil PhHabil 
        { 
            get => _phHabil;
            set => _phHabil = value;
        }
        public string Altura 
        { 
            get => _altura;
            set => _altura = value;
        }
        public int Id 
        { 
            get => _id;
            set => _id = value;
        }
      

        public abstract T CalcularStats<T>() where T : new();
        public abstract string AllStatsData();
        #endregion

        #region Sobrecargas

        ///
        public static bool operator +(List<Deportista> list, Deportista d1)
        {
            if (!list.Contains(d1))
            {
                list.Add(d1);
                 return true;
            }

            return false;
        }
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
            return (obj is null) ? false : this == ((Deportista)obj);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(FullName, GetType());
        }

        #endregion


        protected virtual string Mostrar()
        {
            StringBuilder sb = new();
             float carrerYears = FechaDebut.Year - DateTime.Now.Year;
            if (FechaDebut.Month > DateTime.Now.Month || (FechaDebut.Month == DateTime.Now.Month && FechaDebut.Day > DateTime.Now.Day))
            {

                carrerYears -= 1;
            }

            if(carrerYears < 1)
            {
                int meses =  DateTime.Now.Month - FechaDebut.Month;

                if(meses < 0)
                {
                    meses += 12;
                }
                sb.AppendLine($"Tiempo De Carrera Jugados : {meses} Meses");
            }else
                sb.AppendLine($"Años De Carrera Jugados : {carrerYears}");


            sb.AppendLine($"{FullName}");
            sb.AppendLine($"Debut Deportivo : {FechaDebut.ToShortDateString()}");
            sb.AppendLine($"Edad : {Edad}");
            sb.AppendLine($"Deporte : {_Edeporte.ToString()}\n");
           
                 return sb.ToString();
        }

       
    }
}
