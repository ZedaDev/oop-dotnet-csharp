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

        public Estadisticas()
        {

        }
        protected Estadisticas(string resultado, string fecha, string rival, string estadio, string competicion, string comentario)
        {
            _resultado = resultado;
            _fecha = fecha;
            _rival = rival;
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
        /*public override string ToString()
        {
            return this.Mostrar();
        }*/

        public override bool Equals(object? obj)
        {
            return this == ((Estadisticas)obj);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(_fecha, GetType());
        }
        #endregion
    }
}
