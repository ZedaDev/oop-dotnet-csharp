
using Entities;
using Service;
namespace TesterUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User u1 = new("Don", "123");
            User u2 = new("Don1", "123");
            User u3 = new("Don", "123");

            Usuarios.SetUser = u1;
            Usuarios.SetUser = u2;
            Usuarios.SetUser = u3;

            Console.WriteLine($"{Usuarios.Mostrar()}");
           // Console.WriteLine($"{Usuarios.UsersList == u1}");
          //  Console.WriteLine($"{Usuarios.UsersList != u1}");
            Console.WriteLine($"{u1.ToString()}");

           // u1.NickName = "Don1";
            Console.WriteLine($"{u1.ToString()}");
            Console.WriteLine("+++++++++++++\n");

           // u1.NickName = "Don Dono";
            Console.WriteLine($"NICKNAME CAMBIADO : {u1.ToString()}");
            Console.WriteLine($"{Usuarios.Mostrar()}");
            Console.WriteLine("+++++++++++++\n");
            Usuarios.DeleteUser = u2;
            Console.WriteLine($"{Usuarios.Mostrar()}");
        }
    }
}
