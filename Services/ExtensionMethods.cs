using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class ExtensionMethods
    {

        public static List<EFutbolista> OrderListBy(this List<EFutbolista> lista, EEstadisticas option)
        {
            List <EFutbolista> aux = new();
            switch (option)
            {
                case EEstadisticas.Goles:
                   lista.Sort((a, b) => a.Goles.CompareTo(b.Goles));
                    
                    break;
                case EEstadisticas.Asistencias:
                    lista.Sort((a, b) => a.Asistencias.CompareTo(b.Asistencias));
                    break;
                case EEstadisticas.MasRecientes:
                    lista.Sort((a, b) => a.Fecha.CompareTo(b.Fecha));
                    break;
                case EEstadisticas.MasAntiguas:
                    lista.Sort((a, b) => b.Fecha.CompareTo(a.Fecha));
                    break;
                default:
                    break;
            }

             aux.AddRange(lista);
            return aux;

        }
        public static List<Deportista> OrderListByV1(this List<Deportista> lista, EDeporte option)
        {
            return OrderList(lista, option);
        }

        private static List<Deportista> OrderList(List<Deportista> lista, EDeporte value)
        {
            List<Deportista> aux = new();
            List<Deportista> aux1 = new();
            foreach (Deportista item in lista)
            {
                if(item.Deporte == value)
                {
                    aux.Add(item);
                }
                else
                {
                    aux1.Add(item);
                }
            }

            if (aux1.Count >= 0)
            {
                aux1.Sort((a, b) => a.Deporte.CompareTo(b.Deporte));
                aux.AddRange(aux1);
            }

            return aux;
        }
      
    }
}
