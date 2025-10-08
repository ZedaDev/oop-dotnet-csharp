using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Producto = Entidades.Producto;
using Utilidades;
using System.Threading.Channels;

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
            /*
             * Dictionary<int, Producto> _maquinaExpendedora = new();
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
             */
            #endregion

            #region PARTE 2

            Stack<Producto> bebidas = new();
            Stack<Producto> tortas = new();
            Stack<Producto> papasFritas = new();
            Dictionary<int, Stack<Producto>> maquinaExpendedora = new();

            Console.WriteLine("Bebidas Cargadas. . .");
            CargarPilaProductos(90.5,bebidas, 3, "bebidas");
            Console.WriteLine("Tortas Cargadas. . .");
            CargarPilaProductos(105.5,tortas, 3, "tortas");
            Console.WriteLine("Papas Fritas Cargadas. . .");
            CargarPilaProductos(50.5,papasFritas, 3, "papas fritas");

            maquinaExpendedora.Add(10,bebidas);
            maquinaExpendedora.Add(15,tortas);
            maquinaExpendedora.Add(9,papasFritas);

            Console.WriteLine($"{MostrarDic(maquinaExpendedora)}"); 
                Console.ReadKey();
            //Muestro productos disponibles y el usuario los selecciona.
            do
            {

                //Console.WriteLine($"PRODCUTOS DISPONIBLES : \n{Mostrar(maquinaExpendedora)}");

                Console.Clear();
                Console.WriteLine("Ingrese la Posicion del Producto a Retirar : ");
                string p = Console.ReadLine();
                int pos;
                    if (maquinaExpendedora.ContainsKey(pos = Validador.PedirYValidarNumeroEntero()))
                    {
                       Stack<Producto> pila = maquinaExpendedora[pos];
                        if(pila.Count > 0)
                        {
                            Producto pRetirar = pila.Peek();
                            Console.WriteLine($"Producto a retirar \n {pRetirar.Mostrar()}");
                            pila.Pop();

                        }
                    }else Console.WriteLine("NO HAY STOCK DISPONIBLE");



                    Console.WriteLine($"\nPRODCUTOS DISPONIBLES LUEGO DE RETIRAR : \n{MostrarDic(maquinaExpendedora)}");

                Console.WriteLine("Desea Seguir seleccionando productos? s/n");
            } while (Validador.ValidarRespuesta());
            #endregion
        }


        private void CargarPilaProductos(double precio, Stack<Producto> pila, int cantidad, string name)
        {

            for (int i = 0; i < cantidad; i++)
            {
                pila.Push(new(i, $"{name}", precio));
            }
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
        private string Mostrar(Dictionary<int, Stack<Producto>> maquinaExpendedora)
        {

            StringBuilder sb = new();
            foreach (KeyValuePair<int, Stack<Producto>> productos in maquinaExpendedora)
            {
                int pos = productos.Key;
                Stack<Producto> producto = productos.Value;
                if (producto.Count > 0)
                {
                    foreach (Producto p in producto)
                    {
                        sb.AppendLine($"Codigo : {pos}\n{p.Mostrar()}\n");

                    }
                }else sb.AppendLine($"PRODUCTO EN POSICION {pos} SIN STOCK");



            }
            return sb.ToString();
        }
        private string MostrarDic(Dictionary<int, Stack<Producto>> maquinaExpendedora)
        {

            StringBuilder sb = new();
            foreach (KeyValuePair<int, Stack<Producto>> productos in maquinaExpendedora)
            {
                if(productos.Value.Count > 0) //controla excepcion al vaciar productos.
                sb.AppendLine($"Codigo : {productos.Key} Producto : {productos.Value.Peek()._nombre} Cantidad Disponible : {productos.Value.Count}\n");
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
