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
    

        public FrmEstadisticas()
        {
            InitializeComponent();

        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            SetControlsAndVisor();

        }


        protected override void ActualizarVisor()
        {
            //Hacerlo generico pasando List<T>, U para referenciar el type deol a estadistica con gettype().
            lvVisor.Clear();
            lvVisor.Items.Clear();
            List<Estadisticas> estadisticas = Deportistas.Atletas[Deportistas.INDEX].Estadisticas;
            if (estadisticas is not null && estadisticas.Count() > 0)
            {
                foreach (Estadisticas v in estadisticas)
                {
                    if (v is EFutbolista value)
                        lvVisor.Items.Add($"Vs {value.Rival} ({value.Fecha}) | {value.Competicion} - Estadio {value.Estadio}");
                }

                lbVisorCargado.ForeColor = Color.Green;
                lbVisorCargado.Text = $"Estadisticas Cargadas : {Deportistas.Atletas[Deportistas.INDEX].Estadisticas.Count()}";
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
                    frm.Stat = Deportistas.Atletas[Deportistas.INDEX].Estadisticas[i];

                    frm.ShowDialog();

                }
            }
        }

        protected override void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lvVisor.SelectedIndices.Count > 0)
            {
                // Obtén el índice del elemento seleccionado
                int i = lvVisor.SelectedIndices[0];

                Deportista d = Deportistas.Atletas[Deportistas.INDEX];

                if (i >= 0 && i < d.Estadisticas.Count())
                {
                    // Obtener el atleta correspondiente al índice

                    Estadisticas stat = d.Estadisticas[i];  
                    DialogResult res = MessageBox.Show($"Seguro Desea Eliminar Esta Estadistica? \n {stat.Fecha} - {stat.Competicion}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (res == DialogResult.Yes)
                    {
                        d.Estadisticas.RemoveAt(i);
                        Serializer<Deportista>.JsonSerializerList(Deportistas.Atletas, Paths.DeportistasPath);
                        ActualizarVisor();
                       
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
            lbUser.Text = Usuarios.MyUser.NickName;

            cmbDeporte.Visible = false;

            //Cargo los deportistas [Nombre - Deporte] en el visor.
            this.ActualizarVisor();
        }
      
    }
}
