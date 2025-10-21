using System.Text;
using Utilidades_8;
namespace Clase8Encapsulamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Puesto De Atencion";

            Negocio n1 = new Negocio("VeintiChincue");
            Cliente c1 = new Cliente("Don Adriano", 1);
            Cliente c2 = new Cliente("Don Bernabe", 2);
            Cliente c3 = new Cliente("Don Labruna", 3);
            Cliente c4 = new Cliente("Don Peucelle", 4);
            Cliente c5 = new Cliente("Don Minella", 5);


            if (n1 + c1)
            {
                Console.WriteLine($"\nSe agrego El Cliente {c1.Number} - {c1.Name} a la Queue");
            }

            if (!(n1 + c1))
            {
                Console.WriteLine($"\nEl Cliente {c1.Number} - {c1.Name} Ya se Encuentra En La Queue");
            }

            if (n1 + c2)
            {
                Console.WriteLine($"Se agrego El Cliente {c2.Number} - {c2.Name} a la Queue");
            }

            if (n1 + c3)
            {
                Console.WriteLine($"Se agrego El Cliente {c3.Number} - {c3.Name} a la Queue");
            }

            Console.WriteLine($"Clientes Pendientes Por Atender : {n1.PendientClients}");

            StringBuilder sb = new();
            while (~n1)
            {
               sb.AppendLine($"Clientes pendientes : {n1.PendientClients}");
                if(n1.PendientClients == 0)
                     sb.AppendLine("\nTodos Los Clientes Fueron Atendidos");

            }
            Console.WriteLine($"{sb.ToString()}");
        }
    }
}
