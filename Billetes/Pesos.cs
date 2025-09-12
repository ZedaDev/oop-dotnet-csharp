using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double _amount;
        private static double _quoteAgainstDollar;

        static Pesos()
        {
            Pesos._quoteAgainstDollar = 1 / 1432.74; ///Cuantos Dolares Cuesta un Peso?
        }

        public Pesos(double amount) {
            this._amount = amount;
         }
        public Pesos(double amount, double cotizacion)
            : this(amount)
        {
            _quoteAgainstDollar = cotizacion;
        }

        public double GetAmount() => _amount;
        public static double GetQuote() => _quoteAgainstDollar;
        

        public static explicit operator Dolar(Pesos pesos)
        {
            return new Dolar(pesos.GetAmount() * GetQuote());
        }

        public static explicit operator Euro(Pesos p)
        {
            return (Euro)((Dolar)p);
        }

        public static implicit operator Pesos(Double p) => new Pesos(p);


        public static bool operator ==(Pesos p, Dolar d)
        {
            return ((Dolar)p).GetAmount() == d.GetAmount();
        }
        public static bool operator !=(Pesos p, Dolar d) => !(p == d);
        

        public static bool operator ==(Pesos p, Euro d){

            return ((Euro)p).GetAmount() == d.GetAmount();
        }
        public static bool operator !=(Pesos p, Euro d) => !(p == d);
        public static bool operator ==(Pesos p, Pesos d) => p.GetAmount() == d.GetAmount();
        
        public static bool operator !=(Pesos p, Pesos d) => !(p == d);

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.GetAmount() - (d.GetAmount() / Pesos.GetQuote()));
        }
        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.GetAmount() + (d.GetAmount() / Pesos.GetQuote()));
        }
        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.GetAmount() + ((Dolar)e).GetAmount() / Pesos.GetQuote());
        }
        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.GetAmount() - ((Dolar)e).GetAmount() / Pesos.GetQuote());
        }
    }
}
