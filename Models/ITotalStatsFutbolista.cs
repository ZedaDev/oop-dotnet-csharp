using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface ITotalStatsFutbolista : IMostrar
    {

        public int GolesTotales
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
        public float MinutosTotales
        {
            get;
            set;
        }


       // public void CargarTotalStats(List<EFutbolista> stats, DateTime fechaDebut);

    }


}
