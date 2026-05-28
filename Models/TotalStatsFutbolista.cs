using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TotalStatsFutbolista : ITotalStatsFutbolista
    {


        public TotalStatsFutbolista()
        {
            GolesTotales = 0;
            MinutosTotales = 0;
            AsistenciasTotales = 0;
            TitularTotales = 0;
            MvpTotal = 0;
            PartidosJugados = 0;
            PartidosGanados = 0;
            PartidosEmpatados = 0;
            PartidosPerdidos = 0;
            TiempoDeCarrera = 0;
            GolesTotalesPenal = 0;
            GolesTotalesTiroLibre = 0;
            TarjetaRojaTotal = 0;
            TarjetaAmarillaTotal = 0;
            HatTricks = 0;
        }
        public int GolesTotales
        {
            get;
            set;
        }
        public string PartidoDebut
        {
            get;
            set;
        }
        public float MinutosTotales
        {
            get;
            set;
        }
        public int AsistenciasTotales
        {
            get;
            set;
        }
        public int TitularTotales
        {
            get;
            set;
        }
        public int MvpTotal
        {
            get;
            set;
        }
        public int PartidosJugados
        {
            get;
            set;
        }
        public int PartidosGanados
        {
            get;
            set;
        }
        public int PartidosEmpatados
        {
            get;
            set;
        }
        public int PartidosPerdidos
        {
            get;
            set;
        }
        public float TiempoDeCarrera
        {
            get;
            set;
        }
        public int GolesTotalesPenal
        {
            get;
            set;
        }
        public int GolesTotalesTiroLibre
        {
            get;
            set;
        }
        public int TarjetaRojaTotal
        {
            get;
            set;
        }
        public int TarjetaAmarillaTotal
        {
            get;
            set;
        }
        public int HatTricks
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Mostrar();
        }
        private string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Partidos Jugados : {PartidosJugados}");
            sb.AppendLine($"Partidos Ganados : {PartidosGanados}");
            sb.AppendLine($"Partidos Empatados : {PartidosEmpatados}");
            sb.AppendLine($"Partidos Perdidos : {PartidosPerdidos}");
            sb.AppendLine($"Goles  : {GolesTotales}");
            sb.AppendLine($"Asistencias  : {AsistenciasTotales}");
            sb.AppendLine($"Goles Tiro Libre : {GolesTotalesTiroLibre}");
            sb.AppendLine($"Goles Penal : {GolesTotalesPenal}");
            sb.AppendLine($"Tarjeta/s Roja : {TarjetaRojaTotal}");
            sb.AppendLine($"Tarjeta/s Amarillas : {TarjetaAmarillaTotal}");
            sb.AppendLine($"Minutos Totales : {MinutosTotales}");
            sb.AppendLine($"Tiempo De Carrera : {TiempoDeCarrera}");
            sb.AppendLine($"Hat-Tricks : {HatTricks}");
            sb.AppendLine($"Total Mvp : {MvpTotal}");
            sb.AppendLine($"Total Titular : {TitularTotales}");
            sb.AppendLine($"Debut : {PartidoDebut}");

            return sb.ToString();
        }


    }
}
