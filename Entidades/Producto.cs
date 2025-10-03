namespace Entidades
{
    public class Producto
    {
        public int _codigo;
        public string _nombre;
        public double _precio;

        public Producto(int codigo, string nombre, double precio)
        {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
        }

        public string Mostrar() => $"{_codigo} - {_nombre} - {_precio}";

    }
}
