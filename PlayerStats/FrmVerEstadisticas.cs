using Entities;
using Service;
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
        private Deportista _atleta;
        public Deportista Atleta
        {
            get => _atleta;
            set
            {
                if (value is not null)
                    _atleta = value;
            }
        }

        public FrmVerEstadisticas()
        {
            InitializeComponent();
        }
        public void InicializarAttributos(User usuario, Deportistas d, Deportista atleta)
        {
            base.InitialiteAttributes(d, usuario);
            _atleta = atleta;
        }


        private void FrmVerEstadisticas_Load(object sender, EventArgs e)
        {

            btnAgregar.Text = "Agregar Estadistica";
            btnVer.Text = "Ver Estadistica";
            btnCerrarSesion.Text = "Guardar";

            btnAgregar.Enabled = true;
            lbDateTime.Text = DateTime.Now.Date.ToShortDateString();
            lbDateTime.ForeColor = Color.Green;
            lbUser.Text = base.UserLogueado.NickName;

            cmbDeporte.Visible = false;
            lvVisor.Items.Clear();





            //Cargo la lista de deportistas desde Json




            string pathJson = Atleta.MisEstadisticas(base.UserLogueado.NickName, Atleta.FullName);
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

            this.ActualizarVisor();

        }


        protected override void ActualizarVisor()
        {
            lvVisor.Clear();
            lvVisor.Items.Clear();
            if (Atleta.Estadisticas is not null && Atleta.Estadisticas.Count > 0)
            {
                StringBuilder sb = new();
                foreach (Estadisticas value in Atleta.Estadisticas)
                {
                    if (value != null)
                        lvVisor.Items.Add($"Vs {value.Rival} ({value.Fecha}) | {value.Competicion}");
                }
            }

            if(Atleta.Estadisticas.Count > 0)
            {
                lbVisorCargado.ForeColor = Color.Green;
                lbVisorCargado.Text = $"Estadisticas Cargadas : {Atleta.Estadisticas.Count}";

            }
            else
            {
                lbVisorCargado.ForeColor = Color.Red;
                lbVisorCargado.Text = "No hay estadisticas cargadas aun.";

            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int i = lvVisor.SelectedIndices[0];

            if (i != -1)
            {
                FrmCargarEstadisticaFutbolista frmCEF = new();

                frmCEF.Atleta = this.Atleta;
                this.Hide();
                frmCEF.NickName = base.UserLogueado.NickName;
                frmCEF.D = D;
                frmCEF.Show();


                ActualizarVisor();

            }
            else
                MessageBox.Show("Seleccione Una Estadistica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
