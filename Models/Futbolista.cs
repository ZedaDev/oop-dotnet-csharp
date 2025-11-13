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



        public Futbolista(string fullName, int edad, EDeporte deporte, DateTime fechaDebut, string posicion, string clubActual, string phHabil, string altura)
            : this(posicion, fullName, edad, deporte, fechaDebut, phHabil, altura)
        {
            _clubActual = clubActual;
        }
        private Futbolista(string posicion, string fullName, int edad, EDeporte deporte, DateTime fechaDebut, string phHabil, string altura)
                : this(fullName, edad, deporte, fechaDebut, phHabil, altura)
        {
            _posicion = posicion;
        }
        private Futbolista(string fullName, int edad, EDeporte deporte, DateTime fechaDebut, string phHabil, string altura)
             : base(fullName, edad, fechaDebut ,deporte, phHabil, altura)
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
