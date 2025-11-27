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
    public partial class FrmEstadisticas : frmMenuPrincipal
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

        public FrmEstadisticas()
        {
            InitializeComponent();

        }
        public void InicializarAttributos(string usuario, Deportistas d, Deportista atleta)
        {
            //base.InitialiteAttributes(deportistas, usuario);            base.UserLogueado = usuario;
            base.Dportistas = d;
            base.NickName = usuario;
            _atleta = atleta;
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            SetControlsAndVisor();
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

            if (Atleta.Estadisticas.Count > 0)
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

        public override void btnAgregar_Click(object sender, EventArgs e)
        {
                   FrmCargarEstadisticas frm = new FrmCargarEstadisticaFutbolista();
                    frm.Atleta = this.Atleta; frm.NickName = base.NickName; frm.D = Dportistas;
                    this.Hide();
                    frm.ShowDialog();

                    this.Show();
                    ActualizarVisor();
        }

        protected override void btnVer_Click(object sender, EventArgs e)
        {
            if (lvVisor.SelectedIndices.Count > 0)
            {
                int i = lvVisor.SelectedIndices[0];

                if (i == -1)
                    MessageBox.Show("Seleccione Una Estadistica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    FrmVerEstadistica frm = new FrmVerEstadisticaFutbolista();
                    frm.Stat = Atleta.Estadisticas[i];

                    frm.ShowDialog();
                    //MessageBox.Show("AQUI SE ABRE EL FORMULARIO PARA VER STATS");

                }
            }
        }
        private void SetControlsAndVisor()
        {
            btnAgregar.Text = "Agregar Estadistica";
            btnVer.Text = "Ver Estadistica";
            btnCerrarSesion.Text = "Guardar";

            btnAgregar.Enabled = true;
            lbDateTime.Text = DateTime.Now.Date.ToShortDateString();
            lbDateTime.ForeColor = Color.Green;
            lbUser.Text = base.NickName;

            cmbDeporte.Visible = false;

            //Cargo los deportistas [Nombre - Deporte] en el visor.

            this.ActualizarVisor();
        }
      
    }
}
