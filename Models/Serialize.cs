using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Entities
{
    public class Serialize
    {
        private string _path;


        public Serialize()
        {
            _path = @"../../../../Logs";
            //_path = Path.Combine(directory, "Users.json");

            if (!Directory.Exists(_path))
                Directory.CreateDirectory(_path);

          
        }

        public string UsersPath 
        {
            get 
            { 
                return _path;
            } 
        }

        public void SerializarUsuariosJson(List<User> usuarios)
        {

            JsonSerializerOptions options = new();
            options.WriteIndented = true;

            using (StreamWriter sw = new(_path+"/Users.Json", true, Encoding.UTF8))
            {
                string objJson = JsonSerializer.Serialize(usuarios, options);

                sw.WriteLine(objJson);
            }
        }
        public List<User> DeserializarUsuariosJson()
        {

            List<User> usuarios = new();

            using (StreamReader sw = new(UsersPath)) // sw puede leer del archivo
            {
                string jsonUsuarios = sw.ReadToEnd(); //guardo el archivo en formato string JSON

                usuarios = (List<User>)JsonSerializer.Deserialize(jsonUsuarios, typeof(List<User>));
                //Guardo en la lista, la lista de usuario que traje del archivo.
            }
          
            return usuarios;
        }

    }
}
