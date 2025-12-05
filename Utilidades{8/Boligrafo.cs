using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public class Boligrafo : IAcciones
    {

        private ConsoleColor _colorTinta;
        private float _tinta;

        public Boligrafo(ConsoleColor colorTinta, int tinta)
        {
            _colorTinta = colorTinta;
            _tinta = tinta;
        }

        public ConsoleColor Color { get => _colorTinta; set => _colorTinta = value; }
        public float UnidadesDeEscritura { get => _tinta; set => _tinta = value; }

        public EscrituraWrapper Escribir(string texto)
        {
            /*Cada caracter del texto gastara 0.3 de tinta*/
            float tintaUsada = texto.Length * 0.3f;
            UnidadesDeEscritura -= tintaUsada;

            EscrituraWrapper eWrapper = new(Color, texto);

            return eWrapper;
        }

        public bool Recargar(int unidades)
        {
            UnidadesDeEscritura += unidades;

            return UnidadesDeEscritura > 0 ? true : false;
        }

        private string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{this.GetType().ToString()}");
            sb.AppendLine($"Color De Tinta : {Color}");
            sb.AppendLine($"Unidades De Tinta : {UnidadesDeEscritura}");

            return sb.ToString();
        }
        public override string ToString()
        {
            return Mostrar();
        }
    }
}
