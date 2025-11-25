using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Entities;

namespace PlayerStats
{
    public partial class FrmCargarEstadisticaFutbolista : FrmCargarEstadisticas
    {


        public FrmCargarEstadisticaFutbolista()
        {
            InitializeComponent();
            //base._d = new();
            
        }

        private void FrmCargarEstadisticaFutbolista_Load(object sender, EventArgs e)
        {
            //setteo el combo box de tarjeta amarilla
            cmbTAmarilla.Items.Add("1");
            cmbTAmarilla.Items.Add("2");


        }

        private void cbTAmarilla_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTAmarilla.Checked)
                cmbTAmarilla.Enabled = true;
            else
                cmbTAmarilla.Enabled = false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            if (CheckCamps())
            {

                //
                string fecha = mcFecha.SelectionStart.ToString("dd-MM-yyyy");
                string goles = txtGoles.Text;
                string rival = txtRival.Text;
                string resultado = txtResultado.Text;
                string competicion = txtCompeticion.Text;
                string estadio = txtEstadio.Text;
                string asistencias = txtAsistencias.Text;
                string minutos = txtMinutosJugados.Text;
                string amarilla = "0";
                string comentario = rtcComentario.Text;
                if (cbTAmarilla.Checked)
                    amarilla = cmbTAmarilla.SelectedIndex.ToString();

                bool roja = cbTRoja.Checked;
                bool titular = cbTitutlar.Checked;
                EFutbolista stat = new EFutbolista(titular, goles, asistencias, amarilla, roja, minutos, resultado, fecha, rival, competicion, estadio, comentario, Atleta.FullName);
                //Atleta.AgregarEstadistica = stat;
                if(Atleta + stat)
                {
                    List<EFutbolista> lista = new();
                    foreach (Estadisticas value in Atleta.Estadisticas)
                    {
                        if(value is EFutbolista futbolStat)
                        {
                            lista.Add(futbolStat);
                        }
                    }
                  D.CargarEstadisticaAlArchivo(Atleta.MisEstadisticas(NickName), lista);
                  MessageBox.Show($"Estadistica Cargada Con Exito", "Congratulations", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Su Estadistica A Cargar, Ya Existe", "Stat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                    // D.CargarEstadisticaAlArchivo(pathJson, ((Futbolista)Atleta).ListaEstadisticas);
                    // D.CargarDeportistaAlArchivo(Atleta.MisDeportistas(NickName), D);
                    // MessageBox.Show($"Estadistica Cargada Con Exito", "Congratulations", MessageBoxButtons.OK);



                ClearCamps(); //Limpio todos los textboxs,etc.
        }
    }
        protected bool ClearCamps()
        {
            foreach (Control value in this.Controls)
            {
                if (value is TextBox txt)
                    txt.Clear();

                if (value is ComboBox cmb)
                    cmb.SelectedIndex = -1;

                if (value is MonthCalendar mCalendar)
                    mCalendar.SetDate(DateTime.Today);
            }
            return true;
        }

        protected bool CheckCamps()
        {
            bool ok = false;


            if (!ComprobarCamposNull())
                MessageBox.Show("Asegurese de completar todos los campos", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (mcFecha.SelectionRange.Start.Date == DateTime.Today.Date)
            {
                DialogResult res = MessageBox.Show("La fecha seleccionada es la actual, Desea Cambiarla?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Cancel)
                    ok = true;
            }
            else
                ok = true;

            return ok;
        }

        protected bool ComprobarCamposNull()
        {
            foreach (Control value in this.Controls)
            {
                if (value is TextBox txt && string.IsNullOrEmpty(txt.Text.Trim()))
                {
                    return false;
                }

                if(value is RichTextBox rtb && string.IsNullOrEmpty(rtb.Text.Trim()))
                {
                    return false;
                }

            }
            return true;
        }
    }
}
