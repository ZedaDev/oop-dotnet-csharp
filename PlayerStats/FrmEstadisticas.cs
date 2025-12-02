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
                //StringBuilder sb = new();
                foreach (Estadisticas v in Atleta.Estadisticas)
                {
                    if (v is EFutbolista value)
                        lvVisor.Items.Add($"Vs {value.Rival} ({value.Fecha}) | {value.Competicion} - Estadio {value.Estadio}");
                }

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
                    frm.Atleta = this.Atleta;
            frm.NickName = base.NickName
                ; frm.D = Dportistas;
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

        protected override void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lvVisor.SelectedIndices.Count > 0)
            {
                // Obtén el índice del elemento seleccionado
                int i = lvVisor.SelectedIndices[0];

                // Mostrar información de depuración
                // MessageBox.Show($"Índice seleccionado: {i}, Total de atletas: {D.Atletas.Count}");

                // Verificar que el índice esté dentro de un rango válido
                if (i >= 0 && i < Atleta.Estadisticas.Count)
                {
                    // Obtener el atleta correspondiente al índice

                    Estadisticas stat = Atleta.Estadisticas[i];  // Aquí accedemos directamente a D.Atletas[i]
                                                                // Crear y mostrar el formulario de estadísticas
                    DialogResult res = MessageBox.Show($"Seguro Desea Eliminar Esta Estadistica? \n {stat.Fecha} - {stat.Competicion}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        Atleta.Estadisticas.RemoveAt(i);
                        ActualizarVisor();
                        /*List<EFutbolista> lista = new();
                        Dportistas.TraerEstadisticasDelArchivo(Paths.StatsFutbolPath, Atleta.Estadisticas);
                        
                        List<Estadisticas> eLista = new();
                        lista.Remove((EFutbolista)stat);
                        eLista.AddRange(lista);
                        //eLista.Remove(stat);
                        //Dportistas.CargarEstadisticaAlArchivo(Paths.DeportistasPath, lista);

                        Dportistas.TraerEstadisticasDelArchivo(Paths.StatsFutbolPath, eFutbolistas);

                        foreach (Estadisticas value in eLista)
                        {
                            if (value is EFutbolista futbolStat)
                            {
                                if (value.Deportista == Atleta.FullName && value.Usuario == NickName)
                                    lista.Add(futbolStat);
                            }
                        }*/
                        Dportistas.CargarEstadisticasAlArchivo(Paths.StatsFutbolPath, Atleta.Estadisticas);
                        MessageBox.Show($"Estadistica Eliminada Con Exito", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
                MessageBox.Show($"Seleccione Una Estadistica", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
