using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class Fahrenheit
    {
        double _temperatura;

        public Fahrenheit(double temperatura)
        {
            _temperatura = temperatura;
        }

    //Sobrecargas De Conversion
        public static explicit operator Celcius(Fahrenheit f)
        {
            return new Celcius((f._temperatura - 32) * 5.0 / 9);
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f._temperatura + 459.67) * 5.0 / 9.0);
        }

        //Sobrecarga De Operadores

        public static bool operator ==(Fahrenheit f, Celcius c)
        {
            return c == f;
        }
        public static bool operator !=(Fahrenheit f, Celcius c)
        {
            return !(f == c);
        }
        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return k == f;
        }
        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }

        public static double operator -(Fahrenheit f, Celcius c)
        {
            return f._temperatura - ((Fahrenheit)c)._temperatura;
        }
        public static double operator +(Fahrenheit f, Celcius c)
        {
            return f._temperatura + ((Fahrenheit)c)._temperatura;
        }
        public static double operator -(Fahrenheit f, Kelvin k)
        {
            return f._temperatura - ((Fahrenheit)k)._temperatura;
        }
        public static double operator +(Fahrenheit f, Kelvin k)
        {
            return f._temperatura + ((Fahrenheit)k)._temperatura;
        }

        public double GetTemperatura() => _temperatura;
    }
}
