using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Producto = Entidades.Producto;
using Utilidades;

namespace Clase6Colecciones
{
    public class Ejercicio6
    {

        public void Ejecutar()
        {
            #region PRIMERA PARTE 

            /*
             * Dictionary<int, string> _maquinaExpendedora = new();
                int code;
                string p = " ";

            //Lleno el Diccionario
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

            //Muestro productos disponibles y el usuario los selecciona.
            do
            {

                 Console.Clear();
                 Console.WriteLine($"PRODCUTOS DISPONIBLES : \n{Mostrar(_maquinaExpendedora)}");
                    
                 Console.WriteLine("Digite la posicion y seleccione un producto : ");
                    int option = Validador.PedirYValidarNumeroEntero();
                    _maquinaExpendedora.Remove(option);
                 Console.WriteLine($"PRODCUTOS DISPONIBLES LUEGO DE SELECCIONAR : \n{Mostrar(_maquinaExpendedora)}");

                 Console.WriteLine("Desea Seguir seleccionando productos? s/n");
            } while (Validador.ValidarRespuesta());*/
            #endregion

            #region Refactorizacion Dictionary<int,Producto>
            Dictionary<int, Producto> _maquinaExpendedora = new();
            int code;
            string p = " ";

            //Lleno el Diccionario
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Codigo Del Producto : ");
                int codeKey = Validador.PedirYValidarNumeroEntero();
                Console.WriteLine("Codigo De Barra Del Producto : ");
                code = Validador.PedirYValidarNumeroEntero();
                Console.WriteLine("Nombre Del Producto : ");
                while (!Validador.ValidarString(p = Console.ReadLine()))
                {
                    Console.Clear();
                    Console.WriteLine("Nombre Del Producto : ");

                }
                Console.WriteLine("Precio Del Producto : ");
                double precio = (double)Validador.PedirYValidarNumeroEntero();
                Producto prod = new(code, p, precio);
                _maquinaExpendedora.Add(codeKey,prod);
            }

            //Muestro productos disponibles y el usuario los selecciona.
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
            
            #endregion
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
        private string Mostrar(Dictionary<int,Producto> maquinaExpendedora)
        {
                StringBuilder sb = new StringBuilder();
                foreach (KeyValuePair<int, Producto> producto in maquinaExpendedora)
                {
                    sb.AppendLine($"Posicion : {producto.Key}\n {producto.Value.Mostrar()}\n");
                }
                return sb.ToString();
        }
    }
}
