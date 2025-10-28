using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Utilidades_8;

namespace Utilidades
{
    public class Competencia
    {
        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private List<VehiculoDeCarrera> _autos;
        private ECompetencia _tipoCompetencia;


        public short CantidadCompetidores
        {
            get => _cantidadCompetidores; 
            set => _cantidadCompetidores = value;
        }
        public short CantidadVueltas 
        { 
            get => _cantidadVueltas; 
            set => _cantidadVueltas = value; 
        }

        public VehiculoDeCarrera this[int index]
        {
            get => _autos[index];
            set
            {
                _autos[index] = value;
            }
        }

        public ECompetencia TipoDeCompetencia
        { 
            get => _tipoCompetencia; 
            set 
            {
                _tipoCompetencia = value;
            }
        }

        private Competencia()
        {
            _autos = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas, ECompetencia tipoCompetencia)
            : this()
        {
            _cantidadCompetidores = cantidadCompetidores;
            _cantidadVueltas = cantidadVueltas;
            _tipoCompetencia = tipoCompetencia;
        }


        public static bool operator +(Competencia carrera, VehiculoDeCarrera corredor)
        {
            bool i = true;

            if (carrera._autos.Count < carrera.CantidadCompetidores)
            {
                if (carrera.TipoDeCompetencia == ECompetencia.F1)
                {
                    foreach (AutoF1 value in carrera._autos)
                    {
                        if (value == ((AutoF1)corredor))
                        {
                            i = false;
                            break;
                        }
                    }

                    if (i)
                    {
                        AutoF1.ModificarAuto(((AutoF1)corredor), carrera.CantidadVueltas);
                        carrera._autos.Add(corredor);
                        carrera.CantidadCompetidores += 1;
                    }

                }else if(carrera.TipoDeCompetencia == ECompetencia.MotocCross)
                {
                    foreach (MotoCross value in carrera._autos)
                    {
                        if (value == ((MotoCross)corredor))
                        {
                            i = false;
                            break;
                        }
                    }

                    if (i)
                    {
                        carrera._autos.Add(corredor);
                        carrera.CantidadCompetidores += 1;
                    }
                }
                   
            }
            else
                i = false;


                return i;
        }
        public static bool operator -(Competencia carrera, VehiculoDeCarrera corredor)
        {
            bool i = false;

                for (int c = 0; c < carrera._autos.Count ; c++)
                {
                    if (carrera.TipoDeCompetencia  == ECompetencia.F1) 
                    { 
                        if (carrera._autos[c] == ((AutoF1)corredor))
                        {
                              carrera._autos.RemoveAt(c);
                                        i = true;
                                break;
                        }
                    }else 
                    {

                        if (carrera._autos[c] == ((MotoCross)corredor))
                        {
                            carrera._autos.RemoveAt(c);
                            i = true;
                            break;
                        }
                    }
                }
            return i;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            bool i = false;
            if (c.TipoDeCompetencia == ECompetencia.F1)
            {
                foreach (AutoF1 value in c._autos)
                {
                    if (value == ((AutoF1)a)) i = true;
                }

            }else
            {
                foreach (AutoF1 value in c._autos)
                {
                    if (value == ((AutoF1)a)) i = true;
                }
            }

                return i;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
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
