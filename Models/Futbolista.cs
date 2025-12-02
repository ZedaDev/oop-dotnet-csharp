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
    public class Futbolista : Deportista
    {
        private string _posicion;
        private string _clubActual;
        private List<EFutbolista> _stats;

        public Futbolista()
        {
            _stats = new();
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

        public List<EFutbolista> Stats 
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

        //implementar en los demas deportistas con su lista de estadisticas. para luego hacer en un foreach v.traer automatico.




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
