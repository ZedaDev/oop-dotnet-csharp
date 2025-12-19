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
        private string _fullName;
        private string _apodo;
        private string _edad;
        private string _fechaDebut;
        private EDeporte _Edeporte;
        private ELadoHabil _phHabil;
        private string _altura;
        private string _pais;
        private string _fechaDeRegistro;
        private string _usuario;
        private List<Estadisticas> _estadisticas;

        #region Contructores

        [JsonConstructor]
        public Deportista()
        {
            _estadisticas = new();
           
        }

        
        public Deportista(string fullName, string edad, string apodo, string fechaDebut, EDeporte deporte, ELadoHabil phHabil, string altura,string pais, string fechaDeRegistro, string user)
            : this(fechaDebut, deporte, pais, user)
        {
            _edad = edad;
            _fullName = fullName;
            _altura = altura; 
            _phHabil = phHabil;
            _apodo = apodo;
            _fechaDeRegistro = fechaDeRegistro;
            _estadisticas = new();
        }
        private Deportista(string fechaDebut, EDeporte deporte, string pais, string user)
            : this()
        {
            _fechaDebut = fechaDebut;
            _Edeporte = deporte;
            _pais = pais;
            _usuario = user;
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
        
        public string FechaDeRegistro
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
        public string FechaDebut
        {
            get => _fechaDebut;
            set
            {
                
                _fechaDebut = value;
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
            return this == ((Deportista)obj);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(FullName, GetType());
        }

        #endregion

        
        protected virtual string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Nombre Completo : {FullName}");
            sb.AppendLine($"Edad : {Edad}");
            sb.AppendLine($"Debut Deportivo : {FechaDebut}");
            sb.AppendLine($"Deporte : {_Edeporte.ToString()}");

            int golesTotales = 0;
            int asistencias = 0;
            int tiroLibre = 0;
            int Penal = 0;
            int TRoja = 0;
            int TAmarilla = 0;
            int TPartidos = 0;
            int TMinutos = 0;
            StringBuilder res = new();

            foreach (var value in Estadisticas)
            {
                if(value is EFutbolista e)
                {
                    golesTotales += int.Parse(e.Goles);
                    asistencias += int.Parse(e.Asistencias);
                    tiroLibre += int.Parse(e.GolesTiroLibre);
                    Penal += int.Parse(e.GolesPenal);
                    TRoja += (e.TarjetaRoja) == true ? 1 : 0;
                    TAmarilla += int.Parse(e.TarjetaAmarilla);
                    TPartidos += 1;
                    TMinutos += int.Parse(e.MinutosJugados);
                    res.AppendLine($"{e.Resultado}");

                }
            }
            sb.AppendLine($"{golesTotales}");
            sb.AppendLine($"{asistencias}");
            sb.AppendLine($"{tiroLibre}");
            sb.AppendLine($"{Penal}");
            sb.AppendLine($"{TRoja}");
            sb.AppendLine($"{TAmarilla}");
            sb.AppendLine($"{TPartidos}");
            sb.AppendLine($"{TMinutos}");
            sb.AppendLine($"{res}");
           
           
                 return sb.ToString();
        }


          
    }
}
