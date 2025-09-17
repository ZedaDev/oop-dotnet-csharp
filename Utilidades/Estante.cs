using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class Estante
    {
        private Producto[] _productos;
        private int _ubicacionEstante;


        //Contructores

        private Estante(int capacidad)
        {
            _productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacionEstante) 
            : this(capacidad)
        {
            _ubicacionEstante = ubicacionEstante;
        }

        //Getters

        public Producto[] GetProductos() => _productos;

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sg = new StringBuilder();
            for(int i = 0; i< e._productos.Length; i++)
            {
                if (!Object.ReferenceEquals(e._productos[i], null))//si el obnjeto es distinto de null
                {
                    sg.AppendLine($"{Producto.MostrarProducto(e._productos[i])}");
                    sg.AppendLine("----------------------");

                }
                //sg.AppendLine($"{Producto.MostrarProducto(e._productos[i])}");
            }
            return sg.ToString();
        }

        //Sobrecargas Operadores

        public static bool operator ==(Estante e, Producto p) 
        {
            bool rta = false;
            for (int i = 0; i < e._productos.Length; i++)
            {
                if (e._productos[i] == p) rta = true;
            }
            return rta;
        }
        public static bool operator !=(Estante e, Producto p) 
        { 
            return !(e == p);
        }


        /*+: Retornará true y agregará el producto si el estante posee capacidad
         de almacenar al menos un producto más y dicho producto no se encuentra
         en el estante, false caso contrario. Reutilizar código.*/
        public static bool operator +(Estante e, Producto p)
        {
            bool rta = false;
             int i;//alternativa dos if, crear variable dentro y bajar el index a i.
            if(e != p && (i = Array.IndexOf(e._productos, null)) != -1)
            {
                        e._productos[i] = p;
                        rta = true;
            }
                    return rta;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            Producto[] productos = new Producto[e._productos.Length - 1];

            if (e == p)
            {

                int j = 0;
                for (int i = 0; i < e._productos.Length; i++)
                {
                    if (e._productos[i] != p)
                    {
                        productos[j] = e._productos[i];
                        j++;
                    }
                }

                Estante estante = new Estante(productos.Length, e._ubicacionEstante);
                //Estante estante = new Estante();
                estante._productos = productos; 
                    return estante;
            }
            else return e;

        }


    }
}
