using CentralTelefonica;

namespace TestCentralita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Center");

            // Mis 4 llamadas

            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial(20,"Rosario","La Plata", EFranja.Franja_2);
            Local l3 = new Local("Lanús", 11, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(l2, EFranja.Franja_3);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c.Llamadas.Add(l1);
            //Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l2);
            //Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l3);
            //Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l4);
            Console.WriteLine(c.Mostrar());

            c.OrdenarLlamadas();
            Console.WriteLine(c.Mostrar());

            Console.ReadKey();
        }
    }
}
