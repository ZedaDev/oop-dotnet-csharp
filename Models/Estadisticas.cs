using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class Estadisticas
    {
        private string _resultado;
        private string _fecha;
        private string _rival;
        private string _competicion;
        private string _estadio;
        private string _comentario;
        private string _fechaDeRegistro;

        public Estadisticas()
        {
            _fechaDeRegistro = DateTime.Now.Date.ToString("dd-MM-yyyy");
        }
        public Estadisticas(string resultado, string fecha, string rival, string estadio, string competicion, string comentario)
                : this(estadio, competicion, comentario)
        {
            _resultado = resultado;
            _fecha = fecha;
            _rival = rival;

        }
        private Estadisticas(string estadio, string competicion, string comentario)
            : this()
        {
            _estadio = estadio;
            _comentario = comentario;
        }

        #region Properties
        public string Resultado 
        {
            get => _resultado;
            set => _resultado = value;
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

        #endregion

        #region Sobrecargas


        public static bool operator ==(Estadisticas e, Estadisticas e1)
        {
            if (ReferenceEquals(e, e1)) return true;

            if (e is null || e1 is null) return false;

            return e.Fecha == e1.Fecha && e.GetType() == e1.GetType();
        }
        public static bool operator !=(Estadisticas d, Estadisticas d1)
        {
            return !(d == d1);
        }
        public static bool operator +(Deportista value, Estadisticas d1)
        {
            bool ok = true;
            if (value.Estadisticas.Contains(d1))
                ok = false;
            else
                value.AgregarEstadistica = d1;

                return ok;
        }
        /*public override string ToString()
        {
            return this.Mostrar();
        }*/

        public override bool Equals(object? obj)
        {
            bool ok = false;

            if (obj is Estadisticas)
                ok = this == ((Estadisticas)obj);

            return ok;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(_fecha, GetType());
        }
        #endregion
    }
}
