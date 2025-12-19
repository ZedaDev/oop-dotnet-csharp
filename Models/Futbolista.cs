using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Futbolista : Deportista, IFutbolista
    {
        private string _posicion;
        private string _clubActual;

        public Futbolista()
        {
        }
        
        public Futbolista(string fullName, string edad,string apodo, EDeporte deporte, string fechaDebut, string posicion, string clubActual, ELadoHabil phHabil, string altura,string pais, string fechaDeRegistro, string user)
            : this(posicion, fullName, edad, apodo, deporte, fechaDebut, phHabil, altura, pais, fechaDeRegistro, user)
        {
            _clubActual = clubActual;
        }
       
        private Futbolista(string posicion, string fullName, string edad, string apodo, EDeporte deporte, string fechaDebut, ELadoHabil phHabil, string altura, string pais, string fechaDeRegistro,string user)
                : this(fullName, edad, apodo, deporte, fechaDebut, phHabil, altura, pais, fechaDeRegistro, user)
        {
            _posicion = posicion;
        }
        private Futbolista(string fullName, string edad, string apodo, EDeporte deporte, string fechaDebut, ELadoHabil phHabil, string altura, string pais, string fechaDeRegistro,string user)
             : base(fullName, edad, apodo, fechaDebut ,deporte, phHabil, altura, pais, fechaDeRegistro, user)
        {
        }
        public string Posicion 
        {
            get => _posicion;
            set
            {
                _posicion = value;
            }
        }

        public string ClubActual 
        {
            get => _clubActual;
            set
            {
                _clubActual = value;
            }
        }


    }
}
