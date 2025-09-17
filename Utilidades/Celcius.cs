using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class Celcius
    {
        double _temperatura;

        public Celcius(double temperatura)
        {
            _temperatura = temperatura;
        }

        public static explicit operator Fahrenheit(Celcius c)
        {
            return new Fahrenheit(c._temperatura * 9.0 / 5 + 32);
        }
        public static explicit operator Kelvin(Celcius c)
        {
            return new Kelvin(c._temperatura + 273.15);
        }

        // Operadores == y !=
        public static bool operator ==(Celcius c, Fahrenheit f)
        {
            return (c - f) == 0;
        }

        public static bool operator !=(Celcius c, Fahrenheit f)
        {
            return !(c == f);
        }

        public static bool operator ==(Celcius c, Kelvin k)
        {
            return (c - k) == 0;
        }

        public static bool operator !=(Celcius c, Kelvin k)
        {
            return !(c == k);
        }

        // Operadores + y -

        public static double operator -(Celcius c, Kelvin k)
        {
            return c._temperatura - ((Celcius)k)._temperatura;
        }

        public static double operator +(Celcius c, Kelvin k)
        {
            return c._temperatura + ((Celcius)k)._temperatura;
        }
        //Sobrecargas De Metodos

        public static double operator -(Celcius c, Fahrenheit f)
        {
            return c._temperatura - ((Celcius)f)._temperatura;
        }
        public static double operator +(Celcius c, Fahrenheit f)
        {
            return c._temperatura + ((Celcius)f)._temperatura;
        }

        public double GetTemperatura() => _temperatura;
    }
}
