using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace Entities
{
    public class Serializer<T>
        where T : class
    {


       
        /// <summary>
        /// Escribe una Lista de Objetos en un Archivo, Sobreescribiendolo.
        /// </summary>
        /// <param name="objetoS"></param>
        /// <param name="pathJson"></param>
        public static void JsonSerializerList(List<T> objetoS, string pathJson)
        {
                JsonSerializerOptions jsonObject = new ();
                jsonObject.WriteIndented = true;
                jsonObject.Converters.Add(new JsonStringEnumConverter());
              

                //Creo el json en formato string
                string jsonUsuarios = JsonSerializer.Serialize(objetoS, jsonObject);

                //escribo en el archivo, si no existe lo crea, si existe lo sobreescribe.
                File.WriteAllText(pathJson, jsonUsuarios);
        }


        /// <summary>
        /// Escribe todo el txt archivo en una Lista
        /// </summary>
        /// <param name="pathJson"></param>
        /// <returns>Retorna una lista del tipo de dato implementado en el ARCHIVO, si el ARCHIVO esta vacio retorna una Lista Inicializada Sin datos</returns>
        public static List<T> JsonDeserializeList(string pathJson)
        {

              string txtArchive = File.ReadAllText(pathJson);

            if (string.IsNullOrEmpty(txtArchive.Trim()))
                return new List<T>();

             return JsonSerializer.Deserialize<List<T>>(txtArchive);
        }


    }
}
