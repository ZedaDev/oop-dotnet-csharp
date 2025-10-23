using System.Text;
using Utilidades_8;
using Utilidades;
namespace Clase8Encapsulamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region EJercicio 1 - Puesto De Atencion
            /*
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
              */

            #endregion

            #region Ejercicio 2 - Consultar Indice
            /*
            Console.Title = "Consultar Indice";

            Libro libro = new();

            libro[1] = "Vamos vamos vamos vamos vamos vamos MILLONARIO!!";
            Console.WriteLine($"{libro[1]}");
            libro[1] = "YO A VOS TE SIGO AUNQUE VOS VAYAS BIEN YO A VOS TE SIGO AUNQUE VOS VAYAS MAL";
            Console.WriteLine($"{libro[1]}");
            Console.WriteLine($"{libro[2]}");
            */
            #endregion

            #region 3 - Estadistica Deportiva(Ej.4 Coleciones, Ahora Con Propiedades)

            Console.Title = "Estadistica Deportiva";

            Equipo team = new Equipo(11, "Club Atletico River Plate");

            Jugador j = new(11, "S. Driussi", 11, 15);
            Jugador j1 = new(11, "F. Colidio", 10, 16);
            Jugador j2 = new(111, "M. Salas", 15, 28);
            if (team + j)
                Console.WriteLine(j.MostrarDatos());

            j.Dni = "141901";
            j.Nombre = "Armani Armita";

            Console.WriteLine(j.MostrarDatos());

            if (team + j1)
                Console.WriteLine(j1.MostrarDatos());
            else
                Console.WriteLine($"NO SE AGREGO \n{j1.MostrarDatos()}");

            if (team + j2)
                Console.WriteLine(j2.MostrarDatos());

            team.MostrarTeam();
            Console.ReadKey();
            #endregion
        }
    }
}
