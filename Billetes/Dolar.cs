namespace Billetes
{
        public class Dolar
        {
            private double _amount;
            private static double _quoteAgainstDollar;

            static Dolar()
            {
                _quoteAgainstDollar = 1.0; 
            }

            public Dolar(double amount)
            {
                _amount = amount;
            }

            public Dolar(double amount, double cotizacion) : this(amount)
            {
                _quoteAgainstDollar = cotizacion;
            }

            public double GetAmount() => _amount;
            public static double GetQuote() => _quoteAgainstDollar;




            public static explicit operator Euro(Dolar d)
            {
                return new Euro(d.GetAmount() / Euro.GetQuote());
            }

            public static explicit operator Pesos(Dolar d)
            {
                return new Pesos(d.GetAmount() / Pesos.GetQuote());
            }

            public static implicit operator Dolar(double d) => new Dolar(d);

            public static bool operator ==(Dolar a, Euro b)
            {
                return ((Euro)a).GetAmount() == b.GetAmount();
            }

            public static bool operator !=(Dolar a, Euro b) => !(a == b);

            public static bool operator ==(Dolar a, Pesos b)
            {
                return a.GetAmount() == ((Dolar)b).GetAmount();
            }

            public static bool operator !=(Dolar a, Pesos b) => !(a == b);

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.GetAmount() - ((Dolar)e).GetAmount());
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.GetAmount() + ((Dolar)e).GetAmount());
        }
        public static Dolar operator -(Dolar d, Pesos p)
        {
            return new Dolar(d.GetAmount() - ((Dolar)p).GetAmount());
        }
        public static Dolar operator +(Dolar d, Pesos p)
        {
            return new Dolar(d.GetAmount() + ((Dolar)p).GetAmount());
        }
    }
    }


