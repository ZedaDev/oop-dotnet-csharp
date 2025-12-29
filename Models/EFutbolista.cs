using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class EFutbolista : Estadisticas, IEstadisticaFutbolista
    {
        private bool _titular;
        private string _goles;
        private string _asistencias;
        private string _minutosJugados;
        private int _tarjetaAmarilla;
        private bool _tarjetaRoja;
        private string _golesTiroLibre;
        private string _golesPenal;


        public EFutbolista()
            : base()
        { }

       
        public EFutbolista(bool titular, string goles, string asistencias,int tA, bool tR, string minutosJ, string res, DateTime fe, string riv, string comp, string estadio, string comentario, string usuario, DateTime fechaRegistro, string user)
          : this(goles, asistencias, tA, tR, res, fe, riv, comp, estadio, comentario, usuario, fechaRegistro, user)
        {
            _titular = titular;
            _minutosJugados = minutosJ;
            _golesTiroLibre = "0";
            _golesPenal = "0";
        }
        private EFutbolista(string goles, string asistencias,int tA, bool tR, string res, DateTime fe, string riv, string comp, string estadio, string comentario, string usuario, DateTime fechaRegistro, string user)
          : this(tA, tR, res, fe, riv, comp, estadio, comentario, usuario, fechaRegistro, user)
        {
            _goles = goles;
            _asistencias = asistencias;
        }
        private EFutbolista(int tA, bool tR, string res, DateTime fe, string riv, string comp, string estadio, string comentario, string usuario, DateTime fechaRegistro, string user)
          : base(res, fe, riv, estadio, comp, comentario, usuario, fechaRegistro, user)
        {
            _tarjetaAmarilla = tA;
            _tarjetaRoja = tR;
            /*Resultado = res;
            FechaDeRegistro = fe;
            Rival = riv;
            Estadio = estadio;
            Competicion = comp;
            Comentario = comentario;
            Usuario = usuario;
            FechaDeRegistro = fechaRegistro;
            Usuario = user;*/
        }

        public string GolesTiroLibre
        {
            get
            {
                return _golesTiroLibre;
            }
            set
            {
                _golesTiroLibre = value;
            }

        }
        public string GolesPenal
        {
            get
            {
                return _golesPenal;
            }
            set
            {
                _golesPenal = value;
            }
        }
        public bool Titular { get => _titular; set => _titular = value; }
        public string Goles { get => _goles; set => _goles = value; }
        public string Asistencias { get => _asistencias; set => _asistencias = value; }
        public string MinutosJugados { get => _minutosJugados; set => _minutosJugados = value; }
        public int TarjetaAmarilla { get => _tarjetaAmarilla; set => _tarjetaAmarilla = value; }
        public bool TarjetaRoja { get => _tarjetaRoja; set => _tarjetaRoja = value; }

    }
}
