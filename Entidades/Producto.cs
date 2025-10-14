namespace Entidades
{
    public class Producto
    {
        public int _codigo { get; set; }
        public string _nombre { get; set; }
        public double _precio { get; set; }

        public Producto() { }
        public Producto(int codigo, string nombre, double precio)
        {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
        }

        public string Mostrar() => $"Producto : {_nombre} - Price : {_precio}";

    }
}
