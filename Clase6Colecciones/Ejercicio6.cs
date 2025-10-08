using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Utilidades;

namespace Clase6Colecciones
{
    public class Ejercicio6
    {

        public void Ejecutar()
        {
             Dictionary<int, string> _maquinaExpendedora = new();
                int code;
                string p = " ";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Codigo Del Producto : ");
                    code = Validador.PedirYValidarNumeroEntero();
                Console.WriteLine("Nombre Del Producto : ");
                while (!Validador.ValidarString(p = Console.ReadLine())) 
                {
                    Console.Clear();
                    Console.WriteLine("Nombre Del Producto : ");
                   
                }
                    _maquinaExpendedora.Add(code, p);
            }

            /*StringBuilder sb = new();
            foreach(KeyValuePair <int,string> productos in _maquinaExpendedora)
            {
                sb.AppendLine($"Posicion : {productos.Key} Nombre : {productos.Value}");
            }
            */
            do
            {

                 Console.Clear();
                 Console.WriteLine($"PRODCUTOS DISPONIBLES : \n{Mostrar(_maquinaExpendedora)}");
                    
                 Console.WriteLine("Digite la posicion y seleccione un producto : ");
                    int option = Validador.PedirYValidarNumeroEntero();
                    _maquinaExpendedora.Remove(option);
                 Console.WriteLine($"PRODCUTOS DISPONIBLES LUEGO DE SELECCIONAR : \n{Mostrar(_maquinaExpendedora)}");

                 Console.WriteLine("Desea Seguir seleccionando productos? s/n");
            } while (Validador.ValidarRespuesta());
        }

        private string Mostrar(Dictionary<int,string> maquinaExpendedora)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<int, string> productos in maquinaExpendedora)
            {
                sb.AppendLine($"Posicion : {productos.Key} Nombre : {productos.Value.ToString()}");
            }
            return sb.ToString();
        }
    }
}
