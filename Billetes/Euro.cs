using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double _amount;
        private static double _quoteAgainstDollar;

        static Euro()
        {
            Euro._quoteAgainstDollar = 1.17; ///Cuantos Dolares Cuesta un Euro?
        }

        public Euro(double amount)
        {
            this._amount = amount;
        }
        public Euro(double amount, double cotizacion)
            : this(amount)
        {
            _quoteAgainstDollar = cotizacion;
        }

        public double GetAmount() => _amount;
        public static double GetQuote() => _quoteAgainstDollar;

        public static void SetCotizacion(double quote)
        {
            _quoteAgainstDollar = quote;
        }


        public static explicit operator Dolar(Euro e)
        {
            double amountDolar = e.GetAmount() / Euro.GetQuote();
            return new Dolar(amountDolar);
        }

        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)((Dolar)e); // Cast en cadena: Euro → Dolar → Pesos
        }

        public static implicit operator Euro(double d) => new Euro(d);

        public static bool operator ==(Euro e, Dolar d)
        {
            return e.GetAmount() == ((Euro)d).GetAmount();
        }

        public static bool operator !=(Euro e, Dolar d) => !(e == d);

        public static bool operator ==(Euro e, Pesos p)
        {
            return e.GetAmount() == ((Euro)p).GetAmount();
        }

        public static bool operator !=(Euro e, Pesos p) => !(e == p);

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetAmount() - ((Euro)d).GetAmount());
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetAmount() + ((Euro)d).GetAmount());
        }
        public static Euro operator +(Euro e, Pesos d)
        {
            return new Euro(e.GetAmount() + ((Euro)d).GetAmount());
        }
        public static Euro operator -(Euro e, Pesos d)
        {
            return new Euro(e.GetAmount() - ((Euro)d).GetAmount());
        }

    }
}
