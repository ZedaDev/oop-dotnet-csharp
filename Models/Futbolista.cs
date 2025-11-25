using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Futbolista : Deportista
    {
        private string _posicion;
        private string _clubActual;
        private List<EFutbolista> _stats;

        public Futbolista()
        {
            _stats = new();
        }
        public Futbolista(string fullName, string edad,string apodo, EDeporte deporte, string fechaDebut, string posicion, string clubActual, string phHabil, string altura,string pais)
            : this(posicion, fullName, edad, apodo, deporte, fechaDebut, phHabil, altura, pais)
        {
            _clubActual = clubActual;
        }
       
        private Futbolista(string posicion, string fullName, string edad, string apodo, EDeporte deporte, string fechaDebut, string phHabil, string altura, string pais)
                : this(fullName, edad, apodo, deporte, fechaDebut, phHabil, altura, pais)
        {
            _posicion = posicion;
        }
        private Futbolista(string fullName, string edad, string apodo, EDeporte deporte, string fechaDebut, string phHabil, string altura, string pais)
             : base(fullName, edad, apodo, fechaDebut ,deporte, phHabil, altura, pais)
        {
            _stats = new();
        }
        public string Posicion 
            { 
                get => _posicion;
                set => _posicion = value;
            }
        public string ClubActual 
        { 
            get => _clubActual;
            set => _clubActual = value; 
        }
        public List<EFutbolista> ListaEstadisticas 
        {
            get => _stats;
        }
        public EFutbolista CargarStatFutbolista 
        {
            set
            {
                if(!_stats.Contains(value))
                _stats.Add(value);

            }
        }

        public override void CargarStat(List<EFutbolista> stats, List<Deportista> atletas, string nick)
        {
            foreach (Deportista value in atletas)
            {
                if (value is Futbolista futbolista)
                {

                    foreach (Estadisticas item in futbolista.Estadisticas)
                    {
                        if (item is EFutbolista futbolStat && futbolStat.Deportista == value.FullName)
                        {
                            stats.Add(futbolStat);
                        }
                    }
                }
            }
        }
        public override string MisEstadisticas(string nickName)
        {
            string pathJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Logs", "Users", nickName, "Deportistas", "Futbol.json");
            return pathJson;
        }
        public override string MisDeportistas(string nickName)
        {
            string pathJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Logs", "Users", nickName,"Deportistas","Deportistas.json");
            return pathJson;
        }

    }
}
