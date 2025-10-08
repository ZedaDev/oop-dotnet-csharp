using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Utilidades
{
    public class Competencia
    {
        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private List<AutoF1> _autos;

        private Competencia()
        {
            _autos = new List<AutoF1>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas)
            : this()
        {
            _cantidadCompetidores = cantidadCompetidores;
            _cantidadVueltas = cantidadVueltas;
        }


        public static bool operator +(Competencia carrera, AutoF1 corredor)
        {
            bool i = true;
            if (carrera._autos.Count < carrera._cantidadCompetidores)
            {
                foreach (AutoF1 value in carrera._autos)
                {
                    if (value == corredor) i = false;
                }

                if (i)
                {
                    AutoF1.ModificarAuto(corredor, carrera._cantidadVueltas);
                    carrera._autos.Add(corredor);
                    carrera._cantidadCompetidores += 1;
                }

            }
            else i = false;
            return i;
        }
        public static bool operator -(Competencia carrera, AutoF1 corredor)
        {
            bool i = false;
                for (int c = 0; c < carrera._autos.Count ; c++)
                {
                    if (carrera._autos[c] == corredor)
                    {
                          carrera._autos.RemoveAt(c);
                                    i = true;
                            break;
                    }
                }
            return i;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool i = false;

            foreach (AutoF1 value in c._autos)
            {
                if (value == a) i = true;
            }
            return i;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }


        public string MostrarCorredores()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Corredores : ");
            int i = 0;
            foreach (AutoF1 corredor in _autos)
            {
                sb.AppendLine($"{corredor.MostrarDatos()}");
                i++;
            }
            sb.AppendLine($"Total : {i}");
            return sb.ToString();
        }
    }
}
