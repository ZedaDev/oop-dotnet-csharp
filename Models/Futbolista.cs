using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Futbolista : Deportista
    {
        private string _posicion;
        private string _clubActual;


        public Futbolista(string fullName, string edad, EDeporte deporte, DateTime fechaDebut, string posicion, string clubActual, string phHabil, string altura,string pais)
            : this(posicion, fullName, edad, deporte, fechaDebut, phHabil, altura, pais)
        {
            _clubActual = clubActual;
        }
       
        private Futbolista(string posicion, string fullName, string edad, EDeporte deporte, DateTime fechaDebut, string phHabil, string altura, string pais)
                : this(fullName, edad, deporte, fechaDebut, phHabil, altura, pais)
        {
            _posicion = posicion;
        }
        private Futbolista(string fullName, string edad, EDeporte deporte, DateTime fechaDebut, string phHabil, string altura, string pais)
             : base(fullName, edad, fechaDebut ,deporte, phHabil, altura, pais)
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



    }
}
