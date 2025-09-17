using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class Kelvin
    {
        double _temperatura;

        public Kelvin(double temperatura)
        {
            _temperatura = temperatura;
        }

        // Conversiones explícitas
        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit((k._temperatura * 9.0 / 5.0) - 459.67);
        }

        public static explicit operator Celcius(Kelvin k)
        {
            return new Celcius(k._temperatura - 273.15);
        }

        // Operadores == y !=
        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return ((k - f) == 0);
        }

        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }

        public static bool operator ==(Kelvin k, Celcius c)
        {
            return ((k - c) == 0);
        }

        public static bool operator !=(Kelvin k, Celcius c)
        {
            return !(k == c);
        }

        // Operadores + y -
        public static double operator -(Kelvin k, Fahrenheit f)
        {
            return k._temperatura - ((Kelvin)f)._temperatura;
        }

        public static double operator +(Kelvin k, Fahrenheit f)
        {
            return k._temperatura + ((Kelvin)f)._temperatura;
        }

        public static double operator -(Kelvin k, Celcius c)
        {
            return k._temperatura - ((Kelvin)c)._temperatura;
        }

        public static double operator +(Kelvin k, Celcius c)
        {
            return k._temperatura + ((Kelvin)c)._temperatura;
        }

        public double GetTemperatura() => _temperatura;
    }


}
