using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Service
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
            set
            {
                _usuarios = value;
            }
        }
        public static User SetUser
        {
            set
            {
                if (!_usuarios.Contains(value))
                    UsersList.Add(value);
            }
        }
        public static User DeleteUser
        {
            set
            {
                if (_usuarios.Contains(value))
                    UsersList.Remove(value);
            }
        }

        /// <summary>
        /// Verifica si el usuario se encuentra en List<User> usuarios.
        /// 
        /// </summary>
        /// <param name="usuarioNuevo"></param>
        /// <returns>devuelve True en caso de estar, false en caso de no encontrarse en la lista.</returns>
        public static bool VerificarUsuariosRegistrado(User usuarioNuevo)
        {
            bool usuarioExistente = false;

            // foreach para comprobar si el usuario ya existe en la lista
            foreach (User value in Usuarios.UsersList)
            {
                if (value == usuarioNuevo) // Compara el NickName
                {
                    usuarioExistente = true;
                    break;
                }
            }
            return usuarioExistente;
        }
       /* public static bool operator ==(List<User> usuarios, User usuario)
        {

        }*/
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


