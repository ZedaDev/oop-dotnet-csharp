using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public class Lapiz : IAcciones
    {
        private float _tamanioMina;

        public Lapiz(int unidades)
        {
            _tamanioMina = unidades;
        }

       ConsoleColor IAcciones.Color 
        {
            get => ConsoleColor.Gray;
            set => throw new NotImplementedException();
        }
        float IAcciones.UnidadesDeEscritura 
        {
            get => _tamanioMina; 
            set => _tamanioMina = value;
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            /*Cada caracter del texto gastara 0.1 de mina*/
            float mina = texto.Length * 0.1f;

            /*Al ser definidos los metodos de la interfaz de manera explicita
             se debe castear la clase a una instancia de la interfaz
            para poder cargar la propiedad explicita, si no no se puede acceder*/
            IAcciones actions = this;
            actions.UnidadesDeEscritura -= mina;
            

            EscrituraWrapper eWrapper = new(actions.Color, texto);

            return eWrapper;
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }




        private string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{this.GetType().Name}");
            IAcciones actions = this;
            sb.AppendLine($"Color De Tinta : {actions.Color}");
            sb.AppendLine($"Unidades De Tinta : {actions.UnidadesDeEscritura}");

            return sb.ToString();
        }
        public override string ToString()
        {
            return Mostrar();
        }
    }
}
