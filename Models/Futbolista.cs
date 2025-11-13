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


       


        public Futbolista(string fullName, int edad, EDeporte deporte, DateTime fechaDebut, string posicion, string clubActual)
            : this(posicion, fullName, edad, deporte, fechaDebut)
        {
            _clubActual = clubActual;
        }
        private Futbolista(string posicion, string fullName, int edad, EDeporte deporte, DateTime fechaDebut)
                : this(fullName, edad, deporte, fechaDebut)
        {
            _posicion = posicion;
        }
        private Futbolista(string fullName, int edad, EDeporte deporte, DateTime fechaDebut)
             : base(fullName, edad, fechaDebut ,deporte)
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
