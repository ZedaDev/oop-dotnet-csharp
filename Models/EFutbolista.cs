using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class EFutbolista : Estadisticas
    {
        private bool _titular;
        private string _goles;
        private string _asistencias;
        private string _minutosJugados;
        private string _tarjetaAmarilla;
        private bool _tarjetaRoja;


        public EFutbolista()
            : base()
        { }

       
        public EFutbolista(bool titular, string goles, string asistencias,string tA, bool tR, string minutosJ, string res, string fe, string riv, string comp, string estadio, string comentario, string usuario)
          : this(goles, asistencias, tA, tR, res, fe, riv, comp, estadio, comentario, usuario)
        {
            _titular = titular;
            _minutosJugados = minutosJ;
        }
        private EFutbolista(string goles, string asistencias,string tA, bool tR, string res, string fe, string riv, string comp, string estadio, string comentario, string usuario)
          : this(tA, tR, res, fe, riv, comp, estadio, comentario, usuario)
        {
            _goles = goles;
            _asistencias = asistencias;
        }
        private EFutbolista(string tA, bool tR, string res, string fe, string riv, string comp, string estadio, string comentario, string usuario)
          : base(res, fe, riv, estadio, comp, comentario, usuario)
        {
            _tarjetaAmarilla = tA;
            _tarjetaRoja = tR;
        }

        private string? GolesTiroLibre
        {
            get;
            set;
        }
        private string? GolesPenal
        {
            get;
            set;
        }
        public bool Titular { get => _titular; set => _titular = value; }
        public string Goles { get => _goles; set => _goles = value; }
        public string Asistencias { get => _asistencias; set => _asistencias = value; }
        public string MinutosJugados { get => _minutosJugados; set => _minutosJugados = value; }
        public string TarjetaAmarilla { get => _tarjetaAmarilla; set => _tarjetaAmarilla = value; }
        public bool TarjetaRoja { get => _tarjetaRoja; set => _tarjetaRoja = value; }
    }
}
