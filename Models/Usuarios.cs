using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Usuarios
    {
        private static List<User> _usuarios;

        static Usuarios()
        {
            Usuarios._usuarios = new();
        }

        public static List<User> UsersList
        {
            get => Usuarios._usuarios;
        }
        public static User SetUser
        {
            set 
            {
                if(_usuarios != value)
                {
                    UsersList.Add(value); 
                }
            }
        }
        public static User DeleteUser
        {
            set 
            {
                if(_usuarios == value)
                {
                    UsersList.Remove(value); 
                }
            }
        }
        

        public static string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Usuarios Registrados : ");
            foreach (User value in UsersList)
            {
             sb.AppendLine($"{value.ToString()}");
            }
            sb.AppendLine($"Total : {UsersList.Count} Usuarios Registrados");
            return sb.ToString();
        }


    }
}
