﻿using System.Text;

namespace CentralTelefonica
{
    public class Centralita
    {
        private List<Llamada> _llamadas;
        protected string _razonSocial;


        private Centralita()
        {
            _llamadas = new();
        }
        public Centralita(string nombreEmpresa)
            : this()
        {
            _razonSocial = nombreEmpresa;
        }


        public List<Llamada> Llamadas
        {
            get => _llamadas;
        }
        public  float GananciasPorLocal
        {
            get => CalcularGanancia(ETipoDeLlamada.Local);
        }
        public  float GananciasPorProvincial
        {
            get => CalcularGanancia(ETipoDeLlamada.Provincial);
        }
        public  float GananciasPorTotal
        {
            get => CalcularGanancia(ETipoDeLlamada.Provincial);
        }


       

        public void OrdenarLlamadas()
        {
            Llamadas.Sort(ComparisonFunction);
        }

        private int ComparisonFunction(Llamada l1, Llamada l2)
        {
            if (l1.Duracion > l2.Duracion) return 1;

            if (l1.Duracion == l2.Duracion) return 0;

            return -1;
        }

        /*El método Mostrar expondrá la razón social, la ganancia total,
         * ganancia por llamados locales y provinciales y el detalle de las llamadas
         * realizadas.*/

        public string Mostrar()
        {
            StringBuilder sb = new();

            sb.AppendLine($"{_razonSocial}");
            sb.AppendLine($"\nGanancia Local : {CalcularGanancia(ETipoDeLlamada.Local)}");
            sb.AppendLine($"\nGanancia Provincial : {CalcularGanancia(ETipoDeLlamada.Provincial)}");
            sb.AppendLine($"\nGanancia Total : {CalcularGanancia(ETipoDeLlamada.Todas)}");

            sb.AppendLine($"\nDetalles :");
            foreach (Llamada l in Llamadas)
            {
            sb.AppendLine($"+++++++++++++++++++++++++++++");
                if(l is Local local)
                {
                 sb.AppendLine($"\n{local.Mostrar()}");
                }
                else if(l is Provincial prov)
                {
                 sb.AppendLine($"\n{prov.Mostrar()}");
                }
            }

            return sb.ToString();
        }
        private float CalcularGanancia(ETipoDeLlamada tipoDeLlamada)
        {
            float result = 0.0f;

            switch (tipoDeLlamada)
            {
                case ETipoDeLlamada.Local:
                    result = CalcularLlamada(tipoDeLlamada);
                    break;
                case ETipoDeLlamada.Provincial:
                    result = CalcularLlamada(tipoDeLlamada);
                    break;
                case ETipoDeLlamada.Todas:
                    result += CalcularGanancia(ETipoDeLlamada.Local);
                    result += CalcularGanancia(ETipoDeLlamada.Provincial);
                    break;
            }
            return result;
        }

        private float CalcularLlamada(ETipoDeLlamada tipo)
        {
            float result = 0.0f;
            foreach (Llamada l in Llamadas)
            {
                if(tipo == ETipoDeLlamada.Local)
                {
                    if (l is Local local)
                    {
                        result += local.CostoLlamada;
                    }
                }else if(tipo == ETipoDeLlamada.Provincial)
                {
                    if (l is Provincial prov)
                    {
                        result += prov.CostoLlamada;
                    }
                }
            }
            return result;
        }
    }
}
