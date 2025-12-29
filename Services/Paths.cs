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

        private static readonly string BasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Logs", "Users");
        
        static Paths()
        {
           LoginPath = BuilderPath("Usuarios.json");
            CreateDirectory(LoginPath); 
        }

        /// <summary>
        /// Crea los directorios/Paths para guardar Deportistas y, Estadisticas.
        /// </summary>
        public static void SetPaths()
        {
            SetDeportistaPath();
            //SetFutbolStatsPath();
        }
        public static string BuilderPath(params string[] nickNameAndOrNameJson)
        {
            return Path.Combine(BasePath, Path.Combine(nickNameAndOrNameJson));
        }


        public static void SetDeportistaPath()
        {
            DeportistasPath = BuilderPath(NickName, "Deportistas", "Deportistas.json");
            CreateDirectory(DeportistasPath);

        
        }
       /* public static void SetFutbolStatsPath()
        {
            StatsFutbolPath = BuilderPath(NickName, "Deportistas", "Futbol.json");
            CreateDirectory(StatsFutbolPath);
        }*/


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
        public static string NickName
        {
            get;
            set;
        }
       /* public static string StatsFutbolPath
        {
            get;
            set;
        }*/
        
       
      
    

        public static void CreateDirectory(string pathJson)
        {
            string dir = Path.GetDirectoryName(pathJson);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            if (!File.Exists(pathJson))
            {
                using (File.Create(pathJson)) { } //File.Create no cierra el archivo, using lo hace implicitamente.
            }
        }



    }
}
