using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class Producto
    {
        private string _codigoDeBarra;
        private string _marca;
        private float _precio;


        //Contructor
        public Producto(string codigoDeBarra, string marca, float precio)
        {
            _codigoDeBarra = codigoDeBarra;
            _marca = marca;
            _precio = precio;
        }


    //Conversiones 
        public static explicit operator string(Producto p) => p._codigoDeBarra;

    //Operadores
         public static bool operator ==(Producto p, Producto p1)
         {
            bool rta = false;
            if (!(p is null || p1 is null))
            {
                if (p._marca == p1._marca && p._codigoDeBarra == p1._codigoDeBarra) rta = true;
            }
            return rta;
         }

        public static bool operator !=(Producto p, Producto p1)
        {
            return !(p == p1);
        }
        public static bool operator ==(Producto p, string marca)
        {
            bool rta = false;
            if (p.GetMarca() == marca) rta = true;
            return rta;
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        //Getters
        public string GetMarca() => _marca;
        public float GetPrecio() => _precio;


        public static string MostrarProducto(Producto p)
        {
            return $"Marca : {p._marca}\nPrecio : {p._precio}\nCDB : {(string)p}";
        }


       }
   }


