using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(EFutbolista), "Futbol")]
    public abstract class Estadisticas : IEstadistica
    {
        private string _deportista;
        private string _resultado;
        private string _fecha;
        private string _rival;
        private string _competicion;
        private string _estadio;
        private string _comentario;
        private string _fechaDeRegistro;
        private string _usuario;

     
        public Estadisticas()
        {
        }

        public Estadisticas(string resultado, string fecha, string rival, string estadio, string competicion, string comentario, string usuario,string fechaRegistro, string user)
                : this(estadio, competicion, comentario, user)
        {
            _resultado = resultado;
            _fecha = fecha;
            _rival = rival;
            _fechaDeRegistro = fechaRegistro;
            _deportista = usuario;

        }
        private Estadisticas(string estadio, string competicion, string comentario, string user)
        {
            _estadio = estadio;
            _comentario = comentario;
            _competicion = competicion;
            _usuario = user;
        }

        #region Properties
        public string Resultado 
        {
            get => _resultado;
            set => _resultado = value;
        }
        public string Deportista 
        {
            get => _deportista;
            set => _deportista = value;
        }

       
        public string Usuario 
        {
            get => _usuario;
            set
            {
                _usuario = value;
            }
        }
        public string Fecha 
        {
            
            get => _fecha;
            set => _fecha = value;
        }
        public string Rival 
        {
            
            get => _rival;
            set => _rival = value;
        }
        public string Competicion 
        {
            get => _competicion;
            set => _competicion = value;
        }
        public string Estadio 
        { 
            get => _estadio;
            set => _estadio = value;
        }
        public string Comentario 
        { 
            get => _comentario;
            set => _comentario = value;
        }
        public string FechaDeRegistro 
        { 
            get => _fechaDeRegistro;
            set => _fechaDeRegistro = value;
        }
        

        #endregion

        #region Sobrecargas


        public static bool operator ==(Estadisticas e, Estadisticas e1)
        {
            if (ReferenceEquals(e, e1)) return true;

            if (e is null || e1 is null) return false;

            return e.Fecha == e1.Fecha && e.Deportista == e1.Deportista && e.GetType() == e1.GetType();
        }
        public static bool operator ==(Estadisticas e, Deportista e1)
        {

            if (e is null || e1 is null) return false;

            return e.Deportista == e1.FullName;
        }
        public static bool operator !=(Estadisticas e, Deportista e1)
        {
            return !(e == e1);
        }
        public static bool operator !=(Estadisticas d, Estadisticas d1)
        {
            return !(d == d1);
        }


        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                return false;
            }

            return this == ((Estadisticas)obj);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(_fecha,Deportista);
        }
        #endregion
    }
}
