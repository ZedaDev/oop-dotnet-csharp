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
        public string? Posicion 
        {
            get => _posicion;
            set
            {
                _posicion = value;
            }
        }

        public string? ClubActual 
        {
            get => _clubActual;
            set
            {
                _clubActual = value;
            }
        }


        
        public  T AllStatsDat1<T>() where T : new()
        {
          
            T tSF = this.CalcularStats<T>();
            return tSF;
        }
        public override string AllStatsData()
        {
            return  AllStatsDat1<TotalStatsFutbolista>().ToString();
        }
        public override T CalcularStats<T>()
        {

            T  stats = new();
            if (typeof(T) == typeof(TotalStatsFutbolista)) //Si son el mismo tipo
            {
                var futbolStats = stats as TotalStatsFutbolista; // futbolStat apunta a la misma direccion de memoria que stats
                       
                //stats si no se castea, es null.
                if(futbolStats is not null)
                {

                  foreach (var value in Estadisticas)
                  {

                    if (value is IEstadisticaFutbolista e)
                    {
                    
                        if(int.Parse(e.Goles) >= 3)
                        {
                                futbolStats.HatTricks += 1;
                        }
                        else if(int.Parse(e.Goles) > 0)
                        {
                                futbolStats.GolesTotales += int.Parse(e.Goles);
                        }
                        
                            futbolStats.AsistenciasTotales += int.Parse(e.Asistencias);
                            futbolStats.GolesTotalesTiroLibre += int.Parse(e.GolesTiroLibre);
                            futbolStats.GolesTotalesPenal += int.Parse(e.GolesPenal);
                            futbolStats.TitularTotales += e.Titular == true ? 1 : 0;
                            futbolStats.MvpTotal += e.Mvp == true ? 1 : 0;
                            futbolStats.TarjetaRojaTotal += (e.TarjetaRoja) == true ? 1 : 0;
                            futbolStats.TarjetaAmarillaTotal += e.TarjetaAmarilla;
                            futbolStats.PartidosJugados += 1;
                            futbolStats.MinutosTotales += int.Parse(e.MinutosJugados);
                            if(FechaDebut == e.Fecha)
                            {
                                futbolStats.PartidoDebut = $"[Debut {FechaDebut.ToShortDateString()}]  {value.Resultado}";

                                futbolStats.TiempoDeCarrera = TimeCarrer();
                            }
                        //res.AppendLine($"{e.Resultado} [{e.Fecha.ToShortDateString()}]");
                            if (value.Score is EResultado.victoria)
                            {
                                    futbolStats.PartidosGanados += 1;
                            }
                            else if (value.Score is EResultado.empate)
                            {
                                    futbolStats.PartidosEmpatados += 1;
                            }
                            else
                                    futbolStats.PartidosPerdidos += 1;
                         }
                    }
                }

            }


            return stats;
            
        }

        private float TimeCarrer()
        {
            DateTime fA = DateTime.Now;
            DateTime old = FechaDebut;
          

            // Calcular la diferencia en años completos
            int years = fA.Year - old.Year;

            //if(fA.Month < old.Month || (fA.Month == old.Month && fA.Day < old.Day))
            //{
            //    --years;
            //}
            // Calcular la diferencia de meses sin contar los años completos
            int meses = fA.Month - old.Month;
            // Ajustar si el mes actual es menor que el mes de 'old'
            if (fA.Month < old.Month || (fA.Month == old.Month && fA.Day < old.Day))
            {
                years--;  // Restamos un año
                meses += 12;  // Sumamos 12 meses para ajustar la diferencia
            }

            // Ajustar si el día actual es menor que el de 'old'
            if (fA.Day < old.Day)
            {
                meses--;  // Restamos un mes
            }

            // Ahora calculamos la fracción de mes y los años completos
            float res = years + (float)meses / 10;
            return res;
        }

    }
}
