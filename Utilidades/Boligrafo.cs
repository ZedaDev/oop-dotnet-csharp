using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class Boligrafo
    {
       private const int CANTIDADMAXIMA = 100;
       private ConsoleColor color;
       private int tinta; 
        
        public Boligrafo(int tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public int GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(int tinta)
        {
            int tintaActual = this.tinta;
            if (tinta < 0) tintaActual -= tinta;
            else tintaActual += tinta;

            if (tintaActual >= 0 && tintaActual <= CANTIDADMAXIMA) this.tinta = tintaActual;
        }

        public void Recargar()
        {
            this.tinta = CANTIDADMAXIMA;
        }

        public bool Pintar(int gasto, out string dibujo)
        {
                dibujo = "";
            bool ok = true;
            if (GetTinta() >= gasto)
            {
                dibujo = new string('*', gasto);
                SetTinta(-gasto);
            }
            else if (tinta > 0)
            {
                dibujo = new string('*', GetTinta());
                SetTinta(-GetTinta());
            }
            else ok = false;

                return ok;
        }
    }
}
