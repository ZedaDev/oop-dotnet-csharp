using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class AutoF1
    {
        private short _cantidadCombustible;
        private bool _enCompetencia;
        private short _numero;
        private string _escuderia;
        private short _vueltasRestantes;

        private AutoF1()
        {
            _enCompetencia = false;
            _cantidadCombustible = 0;
            _vueltasRestantes = 0;

        }
        public AutoF1(short numero, string escuderia)
            : this()
        {
            _numero = numero;
            _escuderia = escuderia;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Corredor Numero : {_numero}");
            sb.AppendLine($"Escuderia : {_escuderia}");
            sb.AppendLine($"En Competencia? {_enCompetencia}");
            sb.AppendLine($"Vueltas Restantes : {_vueltasRestantes}");
            sb.AppendLine($"Cantidad De Combustible : {_cantidadCombustible}");

                return sb.ToString();
        }

        public static bool operator ==(AutoF1 ferrari, AutoF1 McLaren)
        {
            if (ReferenceEquals(ferrari, McLaren)) return true; //Validacion si son el mismo objeto.
            if (ferrari is null || McLaren is null) return false;//Validacion si es NULL;

            return (ferrari._escuderia == McLaren._escuderia)  && (ferrari._numero == McLaren._numero);
        }
        public static bool operator !=(AutoF1 ferrari, AutoF1 McLaren)
        {
             return !(ferrari == McLaren);
        }

        public static void ModificarAuto(AutoF1 ferrari, short vueltas)
        {
            ferrari._enCompetencia = true;
            ferrari._vueltasRestantes = vueltas;
            Random random = new(); 
            ferrari._cantidadCombustible = (short)random.Next(1, 101);
        }

    }
}
