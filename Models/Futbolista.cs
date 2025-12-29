using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Futbolista : Deportista, IFutbolista
    {
        private string _posicion;
        private string _clubActual;

        public Futbolista()
        {
        }
        
        public Futbolista(string fullName, string edad,string apodo, EDeporte deporte, DateTime fechaDebut, string posicion, string clubActual, ELadoHabil phHabil, string altura,string pais, DateTime fechaDeRegistro, string user, string comentario)
            : this(posicion, fullName, edad, apodo, deporte, fechaDebut, phHabil, altura, pais, fechaDeRegistro, user, comentario)
        {
            _clubActual = clubActual;
        }
       
        private Futbolista(string posicion, string fullName, string edad, string apodo, EDeporte deporte, DateTime fechaDebut, ELadoHabil phHabil, string altura, string pais, DateTime fechaDeRegistro,string user, string comentario)
                : this(fullName, edad, apodo, deporte, fechaDebut, phHabil, altura, pais, fechaDeRegistro, user, comentario)
        {
            _posicion = posicion;
        }
        private Futbolista(string fullName, string edad, string apodo, EDeporte deporte, DateTime fechaDebut, ELadoHabil phHabil, string altura, string pais, DateTime fechaDeRegistro,string user, string comentario)
             : base(fullName, edad, apodo, fechaDebut ,deporte, phHabil, altura, pais, fechaDeRegistro, user, comentario)
        {
        }
        public string Posicion 
        {
            get => _posicion;
            set
            {
                _posicion = value;
            }
        }

        public string ClubActual 
        {
            get => _clubActual;
            set
            {
                _clubActual = value;
            }
        }

        public override string CalcularsTATS()
        {
            StringBuilder sb = new();
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
                if (value is IEstadisticaFutbolista e)
                {
                    golesTotales += int.Parse(e.Goles);
                    asistencias += int.Parse(e.Asistencias);
                    tiroLibre += int.Parse(e.GolesTiroLibre);
                    Penal += int.Parse(e.GolesPenal);
                    TRoja += (e.TarjetaRoja) == true ? 1 : 0;
                    TAmarilla += e.TarjetaAmarilla;
                    TPartidos += 1;
                    TMinutos += int.Parse(e.MinutosJugados);
                    res.AppendLine($"{e.Resultado} - {e.Fecha.ToShortDateString()}");
                   
                }
            }
            sb.AppendLine($"Partidos Jugados :{TPartidos}");
            sb.AppendLine($"Goles  : {golesTotales}");
            sb.AppendLine($"Asistencias  : {asistencias}");
            sb.AppendLine($"Goles Tiro Libre : {tiroLibre}");
            sb.AppendLine($"Goles Penal : {Penal}");
            sb.AppendLine($"Tarjeta/s Roja : {TRoja}");
            sb.AppendLine($"Tarjeta/s Amarillas : {TAmarilla}");
            sb.AppendLine($"Minutos Totales : {TMinutos}");
            sb.AppendLine($"Todos Los Partidos :\n");
            sb.AppendLine($"{res}");


            return sb.ToString();

        }

       
        /*public override void OrdenarListaMayorMenor<T>(List<T> lista)
        {
            throw new NotImplementedException();
        }

        public override void OrdenarListaMenorMayor<T>(List<T> lista)
        {
            throw new NotImplementedException();
        }

        public override int IComparison(int d, int d1)
        {
            if (d > d1)
                return -1;
            else if (d < d1)
                return 1;
            else
                return 0;
        }*/

    }
}
