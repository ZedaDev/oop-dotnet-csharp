using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PlayerStats
{
    public partial class FrmVerEstadisticas : frmMenuPrincipal
    {

        public Deportista Atleta
        {
            get;
            set;
        }
        public FrmVerEstadisticas()
        {
            InitializeComponent();

        }

        private void FrmVerEstadisticas_Load(object sender, EventArgs e)
        {
            lvVisor.Items.Clear();
            lvVisor.Items.Add("Aun No hay estadsiticas cargadas");
            btnAgregar.Text = "Agregar Estadistica";
            btnVer.Text = "Ver Estadistica";
            btnCerrarSesion.Text = "Guardar";
            cmbDeporte.Visible = false;
            cmbOrdenStats.DataSource = Enum.GetValues(typeof(EOrdenStats));
            cmbDeporte.Items.Add("Ordenar Mas Recientes");
            cmbDeporte.Items.Add("Ordenar Mas Antiguas");


            //Cargo la lista de deportistas desde Json


            
                        
           string pathJson = Atleta.MisEstadisticas(base.UserLogueado.NickName);
            // Crear directorio si no existe
            string dir = Path.GetDirectoryName(pathJson);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // Si el archivo existe, deserializamos los usuarios
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
                        Atleta.Estadisticas = JsonSerializer.Deserialize<List<Estadisticas>>(textArchive, options);
                    // Deserializamos la lista de Estadisticas
                }
            }

            //Cargo los deportistas [Nombre - Deporte] en el visor.
            if (Atleta.Estadisticas is not null && Atleta.Estadisticas.Count > 0)
                this.ActualizarVisor();
            else
                lvVisor.Items.Add("Aun No Hay Estadisticas Cargadas..");
        }


        protected override void ActualizarVisor()
        {
            lvVisor.Clear();
            StringBuilder sb = new();
            foreach (Estadisticas value in Atleta.Estadisticas)
            {
                if (value != null)
                    lvVisor.Items.Add($"Vs {value.Rival} ({value.Fecha}) | Stadium {value.Estadio}");
            }
        }
    }
}
