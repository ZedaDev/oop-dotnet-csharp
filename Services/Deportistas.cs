using Entities;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;


using System.Text.Json.Serialization;
using System.Xml;
namespace Service
{
    public class Deportistas
    {
      
        private static List<Deportista> _atletas;
        private static List<Estadisticas> _generales;


        public Deportistas()
        {
            _atletas = new();
            _generales = new();
        }
        #region Properties
            public List<Deportista> Atletas
            {
                get => _atletas;
                set
                {
                    _atletas = value;
                }
            }

        
            public List<Estadisticas> Estadisticas
            {
                get => _generales;
                set
                {
                    _generales = value;
                }
            }
            public Deportista AgregarAtleta
            {
                set
                {
                    if (!_atletas.Contains(value))
                        Atletas.Add(value);
                }
            }
            public Deportista BorrarAtleta
            {
                set
                {
                    if (Atletas.Contains(value))
                        Atletas.Remove(value);
                }
            }
            public string PathD
            {
                get;
                set;
            }
        #endregion

        #region Sobrecargas
            public static bool operator ==(Deportistas deportistas, Deportista atleta)
            {
                foreach (Deportista value in deportistas.Atletas)
                {
                    if (value == atleta)
                        return true;
                }

                return false;
            }
            public static bool operator !=(Deportistas deportistas, Deportista atleta)
            {
                return !(deportistas == atleta);
            }
            public static bool operator +(Deportistas deportistas, Deportista atleta)
            {
                if(!(deportistas == atleta))
                {
                    //deportistas.Atletas.Add(atleta);
                    deportistas.AgregarAtleta = atleta;
                     return true;
                }

                return false;
            }
            public static bool operator -(Deportistas deportistas, Deportista atleta)
            {
                if(deportistas == atleta)
                {
                    //deportistas.Atletas.Remove(atleta);
                    deportistas.BorrarAtleta = atleta;
                    return true;
                }

                return false;
            }


            public override string ToString()
            {
                return this.Mostrar();
            }

            public override bool Equals(object? obj)
            {
                return this == ((Deportista)obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        #endregion

        #region Methods
        public void OrdenarListaMayorMenor()
        {
            this.Atletas.Sort(IComparison);
        }
        public void OrdenarListaMenorMayor()
        {
            this.Atletas.Sort(IComparisonM);
        }

        //CREAR MAS METODOS SIMILARES PARA MAS DEPORTISTAS
        public void CargarEstadisticasFutbolAlArchivo(string pathJson,List<EFutbolista> stat)
        {
            string dir = Path.GetDirectoryName(pathJson);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            JsonSerializerOptions jsonObject = new();
            jsonObject.WriteIndented = true;
         
            //guardo el string que traje de la lista de atletas, con las opciones del jsonobject(identa como json el texto, inlcuye campos privados al serializar).
            string jsonDeportistas = JsonSerializer.Serialize(stat, jsonObject);
            //string jsonDeportistas = JsonSerializer.Serialize(D.Atletas, jsonObject);

            File.WriteAllText(pathJson, jsonDeportistas);
            //serializo todo el texto, en donde?, en el la ruta del archivo, de donde?, del string que serialize de la lista.
            /*using (StreamWriter writer = new StreamWriter(pathJson, true, Encoding.UTF8))
            {
                writer.Write(jsonDeportistas);
            };*/

        }
        public void CargarEstadisticasAlArchivo(string pathJson,List<Estadisticas> stat)
        {
            string dir = Path.GetDirectoryName(pathJson);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            JsonSerializerOptions jsonObject = new();
            jsonObject.WriteIndented = true;
            jsonObject.Converters.Add(new EstadisticasConverter());
         
            //guardo el string que traje de la lista de atletas, con las opciones del jsonobject(identa como json el texto, inlcuye campos privados al serializar).
            string jsonDeportistas = JsonSerializer.Serialize(stat, jsonObject);
            //string jsonDeportistas = JsonSerializer.Serialize(D.Atletas, jsonObject);

            File.WriteAllText(pathJson, jsonDeportistas);
            //serializo todo el texto, en donde?, en el la ruta del archivo, de donde?, del string que serialize de la lista.
            /*using (StreamWriter writer = new StreamWriter(pathJson, true, Encoding.UTF8))
            {
                writer.Write(jsonDeportistas);
            };*/

        }
        public void CargarEstadisticaAlArchivo1(string pathJson, List<Estadisticas> stat)
        {
            string dir = Path.GetDirectoryName(pathJson);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            JsonSerializerOptions jsonObject = new();
            jsonObject.WriteIndented = true;
            jsonObject.Converters.Add(new EstadisticasConverter());

            // Intentar leer el archivo existente (si existe) para obtener las estadísticas previas
           // List<Estadisticas> estadisticasExistentes = new List<Estadisticas>();

           /* if (File.Exists(pathJson))
            {
                try
                {
                    // Leer el archivo y deserializar el contenido
                    string jsonExistente = File.ReadAllText(pathJson);
                    estadisticasExistentes = JsonSerializer.Deserialize<List<Estadisticas>>(jsonExistente, jsonObject);
                }
                catch (JsonException ex)
                {
                    // Si el archivo está vacío o tiene un formato incorrecto, se maneja el error.
                    Console.WriteLine($"Error al leer el archivo JSON: {ex.Message}");
                    // No se agregan estadísticas previas, solo se guardará la nueva lista.
                }
            }*/

            // Ahora que tenemos las estadísticas existentes (si las había), agregamos la nueva estadística
            //estadisticasExistentes.AddRange(stat);  // Agrega todas las estadísticas de la lista `stat`

            // Serializar la lista combinada (estadísticas existentes + nuevas)
            string jsonDeportistas = JsonSerializer.Serialize(stat, jsonObject);

            // Guardar el archivo con la lista actualizada (no sobrescribe, sino que agrega)
            File.WriteAllText(pathJson, jsonDeportistas);

        }
        public void CargarEstadisticaAlArchivo(string pathJson,List<Estadisticas> stat)
        {
            string dir = Path.GetDirectoryName(pathJson);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            JsonSerializerOptions jsonObject = new();
            jsonObject.WriteIndented = true;
            jsonObject.Converters.Add(new EstadisticasConverter());
         
            //guardo el string que traje de la lista de atletas, con las opciones del jsonobject(identa como json el texto, inlcuye campos privados al serializar).
            string jsonDeportistas = JsonSerializer.Serialize(stat, jsonObject);
            //string jsonDeportistas = JsonSerializer.Serialize(D.Atletas, jsonObject);

            File.WriteAllText(pathJson, jsonDeportistas);
            //serializo todo el texto, en donde?, en el la ruta del archivo, de donde?, del string que serialize de la lista.
            /*using (StreamWriter writer = new StreamWriter(pathJson, true, Encoding.UTF8))
            {
                writer.Write(jsonDeportistas);
            };*/

        }


        //CREAR MAS METODOS SIMILARES PARA MAS DEPORTISTAS
        public  void ArchiveTooList(string pathJson, Deportistas D) //traer futbolistas, sobrecargar para mas deportistas.
        {

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
                    options.Converters.Add(new DeportistaConverter());


                    string textArchive = archivo.ReadToEnd();

                    if (!string.IsNullOrEmpty(textArchive.Trim()))
                    {

                        D.Atletas.AddRange(JsonSerializer.Deserialize<List<Deportista>>(textArchive, options));

                        /*if (deportistasJson.Count > 0)
                            D.Atletas.AddRange(deportistasJson);*/

                    }

                    // Deserializamos el archivo, cargando la lista con los datos del file.
                }

            }
        }
        
        public  void FutbolistasArchiveTooList(string pathJson, Deportistas D) //traer futbolistas, sobrecargar para mas deportistas.
        {

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
        
        public void TraerEstadisticasDelArchivo(string pathJson, List<Estadisticas> stats)
        {
            if (string.IsNullOrEmpty(pathJson))
            {
                throw new ArgumentNullException(nameof(pathJson), "La ruta del archivo no puede ser nula o vacía.");
            }
            //obtengo el directorio de la ruta, excluye archivos.
            string? dir = Path.GetDirectoryName(pathJson);
            
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // Si existe un archivo.json dentro de la ruta general, deserializamos el archivo json.
            if (File.Exists(pathJson))
            {
                using (StreamReader archivo = new(pathJson))
                {
                    
                    JsonSerializerOptions options = new();
                    options.WriteIndented = true;
                    options.Converters.Add(new EstadisticasConverter());

                    string textArchive = archivo.ReadToEnd();

                    if (!string.IsNullOrEmpty(textArchive.Trim()))
                    {

                       stats.AddRange(JsonSerializer.Deserialize<List<Estadisticas>>(textArchive, options));
                       
                        /*if(deportistasJson.Count > 0)
                           stats.AddRange(deportistasJson);*/

                    }
                   
                }

            }


        }
        public void CargarDeportistaAlArchivo(string pathJson,List<Deportista> D)
        {
            //string pathJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "LOGS", "Users", nombreUsuario, "Deportistas.Json");
            string dir = Path.GetDirectoryName(pathJson);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            //setteo las opciones del json al serialiar(Identa como json, guarda los datos privados)
            JsonSerializerOptions jsonObject = new();

            jsonObject.WriteIndented = true;
                
            //guardo el string que traje de la lista de atletas, con las opciones del jsonobject(identa como json el texto, inlcuye campos privados al serializar).
            string jsonDeportistas = JsonSerializer.Serialize(D, jsonObject);
            //string jsonDeportistas = JsonSerializer.Serialize(D.Atletas, jsonObject);
            
            File.WriteAllText(pathJson, jsonDeportistas);
            //serializo todo el texto, en donde?, en el la ruta del archivo, de donde?, del string que serialize de la lista.
           /* using (StreamWriter writer = new StreamWriter(pathJson, true,Encoding.UTF8))
            {
                writer.Write(jsonDeportistas);
            }*/
           // File.WriteAllText(pathJson, jsonDeportistas);

        }
        public void CargarDeportistaAlArchivoV1(string pathJson,List<Deportista> d)
        {
            //string pathJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "LOGS", "Users", nombreUsuario, "Deportistas.Json");
            string dir = Path.GetDirectoryName(pathJson);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            //setteo las opciones del json al serialiar(Identa como json, guarda los datos privados)
            JsonSerializerOptions jsonObject = new();

            jsonObject.WriteIndented = true;
            jsonObject.Converters.Add(new DeportistaConverter());
                
            //guardo el string que traje de la lista de atletas, con las opciones del jsonobject(identa como json el texto, inlcuye campos privados al serializar).
            string jsonDeportistas = JsonSerializer.Serialize(d, jsonObject);
            //string jsonDeportistas = JsonSerializer.Serialize(D.Atletas, jsonObject);

            //serializo todo el texto, en donde?, en el la ruta del archivo, de donde?, del string que serialize de la lista.
            using (StreamWriter writer = new StreamWriter(pathJson, false,Encoding.UTF8))
            {
                writer.WriteLine(jsonDeportistas);
            }
           // File.WriteAllText(pathJson, jsonDeportistas);

        }

        public void TraerDeportistasDelArchivo(string pathJson, Deportistas D) //traer futbolistas, sobrecargar para mas deportistas.
        {
            if (string.IsNullOrEmpty(pathJson))
            {
                throw new ArgumentNullException(nameof(pathJson), "La ruta del archivo no puede ser nula o vacía.");
            }
            //obtengo el directorio de la ruta, excluye archivos.
            string? dir = Path.GetDirectoryName(pathJson);

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
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

        public void TraerStatsFutbolistaDArchivo(string pathJson, List<EFutbolista> stats)
        {

            // Si existe un archivo.json dentro de la ruta general, deserializamos el archivo json.
            if (File.Exists(pathJson))
            {
                using (StreamReader archivo = new(pathJson))
                {
                    var options = new JsonSerializerOptions();

                    string textArchive = archivo.ReadToEnd();


                    if (!string.IsNullOrEmpty(textArchive.Trim()))
                    {

                        List<EFutbolista> deportistasJson = JsonSerializer.Deserialize<List<EFutbolista>>(textArchive, options);

                        if (deportistasJson.Count > 0)
                            stats.AddRange(deportistasJson);

                    }

                }
            }
        }

        public void CargarStat(List<Estadisticas> stats, List <Deportista> atletas, string nick)
        {
            foreach (Deportista value in atletas)
            {
                foreach (Estadisticas item in stats)
                {
                    if (item.Deportista == value.FullName)
                        value.AgregarEstadistica = item;
                }
            }
            
        }
        private int IComparison(Deportista d, Deportista d1)
        {
            if (int.Parse(d.Edad) > int.Parse(d1.Edad))
                return -1;
            else if (int.Parse(d.Edad) < int.Parse(d1.Edad))
                return 1;
            else
                return 0;
        }
        private int IComparisonM(Deportista d, Deportista d1)
        {
           return IComparison(d, d1) * -1;
        }
        private string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Atletas Cargados : ");
            foreach (Deportista value in Atletas)
            {
                sb.AppendLine($"{value.ToString()}");
            }
            sb.AppendLine($"Total : {Atletas.Count} Atletas Registrados");
            return sb.ToString();
        }

        #endregion

    }
}

