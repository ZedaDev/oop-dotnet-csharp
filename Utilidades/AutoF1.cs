using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades_8;

namespace Utilidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        /*private short _cantidadCombustible;
        private bool _enCompetencia;
        private short _numero;
        private string _escuderia;
        private short _vueltasRestantes;*/
        private short _caballosDeFuerza;

        public AutoF1(short numero, string escuderia)
            : base(numero, escuderia)
        {

        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            : this(numero, escuderia)
        {
            _caballosDeFuerza = caballosDeFuerza;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Auto - Caballos De Fuerza : {_caballosDeFuerza}");
            sb.AppendLine($"{base.MostrarDatos()}");

                return sb.ToString();
        }

        public static bool operator ==(AutoF1 ferrari, AutoF1 McLaren)
        {
            if (ReferenceEquals(ferrari, McLaren)) return true; //Validacion si son el mismo objeto.
            if (ferrari is null || McLaren is null) return false;//Validacion si es NULL;

            return (ferrari.Escuderia == McLaren.Escuderia)
                && (ferrari.Numero == McLaren.Numero) && ferrari._caballosDeFuerza == McLaren._caballosDeFuerza;
        }
        public static bool operator !=(AutoF1 ferrari, AutoF1 McLaren)
        {
             return !(ferrari == McLaren);
        }

        public static void ModificarAuto(AutoF1 ferrari, short vueltas)
        {
            ferrari.EnCompetencia = true;
            ferrari.VueltasRestantes = vueltas;
            Random random = new(); 
            ferrari.CantidaCombustible = (short)random.Next(1, 101);
        }

    }
}
