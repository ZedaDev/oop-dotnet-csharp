using Entities;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
namespace Service
{
    public class Deportistas
    {
      
        private static List<Deportista> _atletas;


        public Deportistas()
        {
            _atletas = new();
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
                return !(deportistas + atleta);
            }
            public static bool operator +(Deportistas deportistas, Deportista atleta)
            {
                if(deportistas != atleta)
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

        public void CargarDeportistaAlArchivo(string pathJson, List<Deportista> atletas, string nombreUsuario)
        {
            //string pathJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "LOGS", "Users", nombreUsuario, "Deportistas.Json");
            string dir = Path.GetDirectoryName(pathJson);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            //setteo las opciones del json al serialiar(Identa como json, guarda los datos privados)
            JsonSerializerOptions jsonObject = new()
            {
                WriteIndented = true,
                IncludeFields = true
            };


            //guardo el string que traje de la lista de atletas, con las opciones del jsonobject(identa como json el texto, inlcuye campos privados al serializar).
            string jsonDeportistas = JsonSerializer.Serialize(atletas, jsonObject);
            //string jsonDeportistas = JsonSerializer.Serialize(D.Atletas, jsonObject);

            //serializo todo el texto, en donde?, en el la ruta del archivo, de donde?, del string que serialize de la lista.
            File.WriteAllText(pathJson, jsonDeportistas);

        }

        public void TraerDeportistasDelArchivo(string pathJson, List<Deportista> atletas)
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
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        IncludeFields = true, // Incluir campos privados durante la deserialización
                    };

                    string textArchive = archivo.ReadToEnd();

                    if (!string.IsNullOrEmpty(textArchive.Trim()))
                        atletas.AddRange(JsonSerializer.Deserialize<List<Deportista>>(textArchive, options));
                    // Deserializamos el archivo, cargando la lista con los datos del file.
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

