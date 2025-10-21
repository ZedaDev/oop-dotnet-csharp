using System.Numerics;

namespace Utilidades_8
{
    public class Cliente
    {
        private string _name;
        private int _number;

        public Cliente(string name, int number)
            : this(number)
        {
            _name = name;
        }
        public Cliente(int number)
        {
            _number = number;
        }



        public int Number
        {
            get { return _number; }
        }
        public string Name
        {
            get { return _name; }
            set {
                if(string.IsNullOrEmpty(value.Trim()))
                    _name = value;
                }
        }

        public static bool operator ==(Cliente c1, Cliente c2) => c1._number == c2._number;
        public static bool operator !=(Cliente c1, Cliente c2) => !(c1 == c2);


    }
}
