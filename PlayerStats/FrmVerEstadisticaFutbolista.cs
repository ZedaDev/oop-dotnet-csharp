using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerStats
{
    public partial class FrmVerEstadisticaFutbolista : FrmVerEstadistica
    {
        public FrmVerEstadisticaFutbolista()
        {
            InitializeComponent();
        }

        private void FrmVerEstadisticaFutbolista_Load(object sender, EventArgs e)
        {
            base.EnableDisabledTextBox();
            lbTiroLibre.Visible = false;
            lbGolPenal.Visible = false;
            txtGPenal.Visible = false;
            txtGTLibre.Visible = false;

            PrintInfoStat();
        }

        private void PrintInfoStat()
        {
            if(Stat is EFutbolista v)
            {
                //rtbComentario.ReadOnly = true; //Solo Lectura.
                rtbComentario.Enabled = false;

                txtRival.Text = v.Rival;
                txtResultado.Text = v.Resultado;
                txtEstadio.Text = v.Estadio;
                txtCompeticion.Text = v.Competicion;

                txtGoles.Text = v.Goles;
                /*Logica mostrar label y texbox de gol de penal y de tiro libre.
                 * if(int.Parse(v.Goles) > 0)
                {
                    if()
                }*/
                txtAsistencias.Text = v.Asistencias;
                txtMinutosJugados.Text = v.MinutosJugados;
                txtTAmarilla.Text = v.TarjetaAmarilla;
                txtTitular.Text = v.Titular ? "Si" : "No";
                txtTRoja.Text = v.TarjetaRoja ? "Si" : "No";
                txtTRoja.ForeColor = v.TarjetaRoja is true ? Color.Red : Color.Green;
               

                lbFechaRegistro.ForeColor = Color.LightGreen;
                lbFechaRegistro.Text = $"Estadistica Cargada {v.FechaRegistro}";

                rtbComentario.Text = v.Comentario;
                lbFechaPartido.Text = $"[MATCH DATE] {v.Fecha}";
                lbFechaPartido.ForeColor = Color.LightGreen;




            }
        }
    }
}
