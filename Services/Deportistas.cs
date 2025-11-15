using Entities;
using System.Runtime.CompilerServices;
using System.Text;
namespace Service
{
    public class Deportistas
    {
      
        private static List<Deportista> _atletas;


        public Deportistas()
        {
            _atletas = new();
        }
        #region Properties
            public List<Deportista> Atletas
            {
                get => _atletas;
                set
                {
                    _atletas = value;
                }
            }
            public Deportista AgregarAtleta
            {
                set
                {
                    if (!_atletas.Contains(value))
                        Atletas.Add(value);
                }
            }
            public Deportista BorrarAtleta
            {
                set
                {
                    if (Atletas.Contains(value))
                        Atletas.Remove(value);
                }
            }
        #endregion

        #region Sobrecargas
            public static bool operator ==(Deportistas deportistas, Deportista atleta)
            {
                foreach (Deportista value in deportistas.Atletas)
                {
                    if (value == atleta)
                        return true;
                }

                return false;
            }
            public static bool operator !=(Deportistas deportistas, Deportista atleta)
            {
                return !(deportistas + atleta);
            }
            public static bool operator +(Deportistas deportistas, Deportista atleta)
            {
                if(deportistas != atleta)
                {
                    //deportistas.Atletas.Add(atleta);
                    deportistas.AgregarAtleta = atleta;
                     return true;
                }

                return false;
            }
            public static bool operator -(Deportistas deportistas, Deportista atleta)
            {
                if(deportistas == atleta)
                {
                    //deportistas.Atletas.Remove(atleta);
                    deportistas.BorrarAtleta = atleta;
                    return true;
                }

                return false;
            }


            public override string ToString()
            {
                return this.Mostrar();
            }

            public override bool Equals(object? obj)
            {
                return this == ((Deportista)obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        #endregion

        #region Methods
        public void OrdenarListaMayorMenor()
        {
            this.Atletas.Sort(IComparison);
        }
        public void OrdenarListaMenorMayor()
        {
            this.Atletas.Sort(IComparisonM);
        }


        private int IComparison(Deportista d, Deportista d1)
        {
            if (int.Parse(d.Edad) > int.Parse(d1.Edad))
                return -1;
            else if (int.Parse(d.Edad) < int.Parse(d1.Edad))
                return 1;
            else
                return 0;
        }
        private int IComparisonM(Deportista d, Deportista d1)
        {
           return IComparison(d, d1) * -1;
        }
        private string Mostrar()
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

