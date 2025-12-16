using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Utilidades_8;
using Exceptions;
namespace Utilidades
{
    public class Competencia<T>
        where T : VehiculoDeCarrera
    {
        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private List<T> _autos;
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

        public T this[int index]
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

        public List<T> Vehiculos 
        {
            get => _autos;
        }

        private Competencia()
        {
            _autos = new List<T>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas, ECompetencia tipoCompetencia)
            : this()
        {
            _cantidadCompetidores = cantidadCompetidores;
            _cantidadVueltas = cantidadVueltas;
            _tipoCompetencia = tipoCompetencia;
        }


        public static bool operator +(Competencia<T> carrera, T corredor)
        {
            bool i = true;
            //try
            //{
                if (carrera._autos.Count < carrera.CantidadCompetidores)
                {
                    if (carrera.TipoDeCompetencia == ECompetencia.F1)
                    {
                        if (!carrera.Vehiculos.Contains(corredor))
                        {
                            if (corredor is AutoF1)
                            {
                                corredor.Modificar(carrera.CantidadVueltas);

                                carrera._autos.Add(corredor);
                                carrera.CantidadCompetidores += 1;
                            }
                        }
                        else i = false;
                        /*foreach (T value in carrera._autos)
                        {
                            if(value is AutoF1 aValue && corredor is AutoF1 aCorredor)
                            {
                                if (aValue == aCorredor)
                                {
                                    i = false;
                                    break;
                                }
                            }
                        }*/

                        /*if (i)
                        {
                                if(corredor is AutoF1 af1)
                                {
                                    AutoF1.ModificarAuto(af1, carrera.CantidadVueltas);
                                    carrera._autos.Add(corredor);
                                    carrera.CantidadCompetidores += 1;
                                }
                            if(corredor.GetType() != typeof(AutoF1))
                            {
                                throw new CompetenciaNoDisponibleException();
                            }
                            else
                            {
                            }
                        }*/


                    }
                    else if (carrera.TipoDeCompetencia == ECompetencia.MotocCross)
                    {
                        if (!carrera.Vehiculos.Contains(corredor))
                        {
                            if (corredor is MotoCross)
                            {
                                corredor.Modificar(carrera.CantidadVueltas);

                                carrera._autos.Add(corredor);
                                carrera.CantidadCompetidores += 1;
                            }
                        }
                        else i = false;
                        /*foreach (T value in carrera.Vehiculos)
                        {
                            if (value is MotoCross aValue && corredor is MotoCross aCorredor)
                            {
                                if (aValue == aCorredor)
                                {
                                    i = false;
                                    break;
                                }
                            }
                           
                        }

                        if (i)
                        {
                                carrera._autos.Add(corredor);
                                carrera.CantidadCompetidores += 1;
                            /*if (corredor.GetType() != typeof(MotoCross))
                            {
                                throw new CompetenciaNoDisponibleException();
                            }
                            else
                            {
                            }
                            
                        }
                    }*/

                    }


                }
            /*}
            catch (CompetenciaNoDisponibleException ex)
            {

                throw new CompetenciaNoDisponibleException("Competencia incorrecta", typeof(Competencia<T>).ToString(), "+", ex?.InnerException);
            }*/


                return i;
        }
        public static bool operator -(Competencia<T> carrera, T corredor)
        {
            bool i = false;

                for (int c = 0; c < carrera._autos.Count ; c++)
                {
                    if (carrera.TipoDeCompetencia  == ECompetencia.F1) 
                    { 
                        if (carrera._autos[c] == corredor)
                        {
                              carrera._autos.RemoveAt(c);
                                        i = true;
                                break;
                        }
                    }else 
                    {

                        if (carrera._autos[c] == corredor)
                        {
                            carrera._autos.RemoveAt(c);
                            i = true;
                            break;
                        }
                    }
                }

                
            return i;
        }

        public static bool operator ==(Competencia<T> c, T a)
        {
            bool i = false;
            if (c.TipoDeCompetencia == ECompetencia.F1)
            {
                foreach (T value in c._autos)
                {
                    
                    if (value == a)
                    {
                        i = true;
                        break;
                    }
                }

            }else
            {
                foreach (T value in c._autos)
                {
                    if (value == a)
                    {
                        i = true;
                        break;
                    }
                }
            }
            if (!i)
               throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", typeof(Competencia<T>).ToString(), "==");
                
            return i;
        }
        public static bool operator !=(Competencia<T> c, T a)
        {
            return !(c == a);
        }


        public string MostrarCorredores()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Corredores : ");
            int i = 0;
            foreach (T corredor in _autos)
            {
                sb.AppendLine($"{corredor.MostrarDatos()}");
                i++;
            }
            sb.AppendLine($"Total : {i}");
            return sb.ToString();
        }
    }
}
