using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class VehiculoDeCarrera
    {
        private short _cantidaCombustible;
        private bool _enCompetencia;
        private string _escuderia;
        private short _numero;
        private short _vueltasRestantes;

        public short CantidaCombustible { get => _cantidaCombustible; set => _cantidaCombustible = value; }
        public bool EnCompetencia { get => _enCompetencia; set => _enCompetencia = value; }
        public string Escuderia { get => _escuderia; set => _escuderia = value; }
        public short Numero { get => _numero; set => _numero = value; }
        public short VueltasRestantes { get => _vueltasRestantes; set => _vueltasRestantes = value; }

        public VehiculoDeCarrera(short number, string escuderia)
        {
            _escuderia = escuderia;
            _numero = number;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Corredor Numero : {Numero}");
            sb.AppendLine($"Escuderia : {Escuderia}");
            sb.AppendLine($"En Competencia? {EnCompetencia}");
            sb.AppendLine($"Vueltas Restantes : {VueltasRestantes}");
            sb.AppendLine($"Cantidad De Combustible : {CantidaCombustible}");

            return sb.ToString();
        }
    }
}
