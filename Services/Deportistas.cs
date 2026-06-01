using Entities;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;


using System.Text.Json.Serialization;
using System.Xml;
namespace Service
{
    public  static class Deportistas 
    {
      
        private static List<Deportista> _atletas;


             
            static Deportistas()
            {
                _atletas = new();
            }
        #region Properties
            public static List<Deportista> Atletas
            {
                get => _atletas;
                set
                {
                    _atletas = value;
                }
            }

            public static Deportista AgregarAtleta
            {
                set
                {
                    if (!_atletas.Contains(value))
                        Atletas.Add(value);
                }
            }
            public static Deportista BorrarAtleta
            {
                set
                {
                    if (Atletas.Contains(value))
                        Atletas.Remove(value);
                }
            }
            public static Deportista MyAtleta
            {
                    get;
                    set;
            }
            public static int INDEX
            {
                    get;
                    set;
            }

    

        #endregion

        public static void EliminarEstadisticas(List<Estadisticas> list, Deportista deportista)
        {
            foreach (Estadisticas value in list)
            {
                if(value == deportista)
                {
                    list.Remove(value);
                }
            }
        }
        #region Sobrecargas
           
        #endregion

        #region Methods
        /*public static void OrdenarListaMayorMenor()
        {
            Atletas.Sort(IComparison);
        }
        public static void OrdenarListaMenorMayor()
        {
            Atletas.Sort(IComparisonM);
        }*/


        private static int IComparison(Deportista d, Deportista d1)
        {
            if (int.Parse(d.Edad) > int.Parse(d1.Edad))
                return -1;
            else if (int.Parse(d.Edad) < int.Parse(d1.Edad))
                return 1;
            else
                return 0;
        }
        private static int IComparisonM(Deportista d, Deportista d1)
        {
           return IComparison(d, d1) * -1;
        }
        private static  string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Atletas Cargados : ");
            foreach (Deportista value in Atletas)
            {
                sb.AppendLine($"{value.ToString()}");
            }
            sb.AppendLine($"Total : {Atletas.Count} Atletas Registrados");
            return sb.ToString();
        }

        #endregion

    }
}

