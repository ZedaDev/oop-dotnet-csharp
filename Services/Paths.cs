using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Service
{
    public static class Paths
    {
        static Paths()
        {
            LoginPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Logs", "Users", "Usuarios.json");
            CreateDirectory(LoginPath);

           

        }



        public static string LoginPath
        {
            get;
            set;
        }
        public static string DeportistasPath
        {
            get;
            set;
        }
        public static string DeportistasPathv1
        {
            get;
            set;
        }
        public static string NickName
        {
            get;
            set;
        }
        public static string StatsFutbolPath
        {
            get;
            set;
        }
        
        /*public static void AddStatsToList(List<Deportista> atletas)
        {
            
            if (File.Exists(Paths.StatsFutbolPath))//Paths.DeportistasPath)
            {

                foreach (Deportista value in atletas)
                {
                    if (value is Futbolista v)
                    {

                        List<EFutbolista> stats = new();
                        //v.TraerStatsDArchivo(Paths.StatsFutbolPath, stats);
                        v.CargarStat(stats,value, NickName);
                    }
                }
                    /else if (value is Tenista v)
                    {
                        List<EFutbolista> stats = new();
                        v.TraerFutbolStatsDArchivo(Paths.StatsFutbolPath, stats);
                        if (stats.Count > 0)
                            value.Estadisticas.AddRange(stats);
                    }
                    else if (value is Boxeador v)
                    {
                        List<EFutbolista> stats = new();
                        v.TraerFutbolStatsDArchivo(Paths.StatsFutbolPath, stats);
                        if (stats.Count > 0)
                            value.Estadisticas.AddRange(stats);
                    }
                    ///Agregar mas casos en casos de que haya mas deportistas(Boxeador, tenista).
                }
            }
        }*/

       /* private static void DeportistaIs(Deportista value)
        {
            switch (value)
            {
                case Futbolista futbolista:
                    List<EFutbolista> stats = new();
                    futbolista.TraerStatsDArchivo(Paths.StatsFutbolPath, stats);
                    if (stats.Count > 0)
                        value.Estadisticas.AddRange(stats);
                    break;
                default:
                    break;
            }
            if (value is Futbolista v)
                    {
                        List<EFutbolista> stats = new();
                        v.TraerStatsDArchivo(Paths.StatsFutbolPath, stats);
                        if (stats.Count > 0)
                            value.Estadisticas.AddRange(stats);
                    }
        }
       REFACTORIZAR PARA CUANDO ESTEN LAS CLASES DE LOS DEPORTISTAS HECHAS.
        */
        public static void SetDeportistaPath(string nick)
        {
            DeportistasPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Logs", "Users", nick, "Deportistas", "Deportistas.json");
            CreateDirectory(DeportistasPath);

            /*DeportistasPathv1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Logs", "Users", nick, "Deportistas.json");
            CreateDirectory(DeportistasPathv1);*/
        }
        public static void SetFutbolStatsPath(string nick)
        {
            StatsFutbolPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Logs", "Users", nick, "Deportistas", "Futbol.json");
            CreateDirectory(StatsFutbolPath);
        }
        public static void TraerDeportistasDelArchivo(string pathJson, Deportistas D) //traer futbolistas, sobrecargar para mas deportistas.
        {
            if (string.IsNullOrEmpty(pathJson))
            {
                throw new ArgumentNullException(nameof(pathJson), "La ruta del archivo no puede ser nula o vacía.");
            }

            // Si existe un archivo.json dentro de la ruta general, deserializamos el archivo json.
            if (File.Exists(pathJson))
            {
                using (StreamReader archivo = new(pathJson))
                {
                    var options = new JsonSerializerOptions();
                    //options.Converters = new JsonStringEnumConverter();

                    // Para enum
                    //IncludeFields = true,
                    options.WriteIndented = true; // Incluir campos privados durante la deserialización



                    string textArchive = archivo.ReadToEnd();

                    if (!string.IsNullOrEmpty(textArchive.Trim()))
                    {

                        List<Futbolista> deportistasJson = JsonSerializer.Deserialize<List<Futbolista>>(textArchive, options);

                        if (deportistasJson.Count > 0)
                            D.Atletas.AddRange(deportistasJson);

                    }

                    // Deserializamos el archivo, cargando la lista con los datos del file.
                }

            }
        }

        /// <summary>
        /// Actualiza la lista, trayendo los datos del archivo json.
        /// </summary>
        /// <param name="pathJson"></param>
        public static void DeserializarArchivoUsuarios(string pathJson)
        {

            
            // Si el archivo existe, deserializamos los usuarios
            if (File.Exists(pathJson))
            {
                using (StreamReader archivo = new(pathJson))
                {
                    JsonSerializerOptions options = new();
                    options.WriteIndented = true;

                    string textArchive = archivo.ReadToEnd(); //Leer todo el archivo

                    // Deserializamos la lista de usuarios
                    Usuarios.UsersList = JsonSerializer.Deserialize<List<User>>(textArchive, options);
                }
            }
        }

        /// <summary>
        /// Serializa la lista de usuarios en formato json.
        /// Se guarda en la misma ruta de registro preconfigurada en el constructor 'LoginPath'.
        /// </summary>
        public static void GuardarUsuariosEnArchivo()
        {

            // Configurar opciones para serialización
            JsonSerializerOptions jsonObject = new();
            jsonObject.WriteIndented = true;

            // Serializar la lista de usuarios
            string jsonUsuarios = JsonSerializer.Serialize(Usuarios.UsersList, jsonObject);

            // Sobrescribir el archivo JSON con la lista actualizada
            File.WriteAllText(LoginPath, jsonUsuarios); //crea el archivo si no existe.
        } 
        
    

        public static void CreateDirectory(string pathJson)
        {
            string dir = Path.GetDirectoryName(pathJson);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }



    }
}
