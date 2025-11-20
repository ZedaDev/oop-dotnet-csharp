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

        public Futbolista()
        {

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
            //inicializar lista estadisticas;
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

        public override string MisEstadisticas(string nickName, string deportista)
        {
            string pathJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "LOGS", "Users", nickName, "STATS", deportista, "Futbol.json");
            return pathJson;
        }
        public override string MisDeportistas(string nickName)
        {
            string pathJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "LOGS", "Users", nickName,"Deportistas","Deportistas.json");
            return pathJson;
        }

    }
}
