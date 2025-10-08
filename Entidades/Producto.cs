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

        public string Mostrar() => $"Codigo de Barra : {_codigo} - Producto : {_nombre} - Price : {_precio}";

    }
}
