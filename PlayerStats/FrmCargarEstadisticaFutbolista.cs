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
using ProjectExceptions;
using System.Reflection;



namespace PlayerStats
{
    public partial class FrmCargarEstadisticaFutbolista : FrmCargarEstadisticas
    {


        public FrmCargarEstadisticaFutbolista()
        {
            InitializeComponent();

        }

        private void FrmCargarEstadisticaFutbolista_Load(object sender, EventArgs e)
        {
            //setteo el combo box de tarjeta amarilla
            SettControlsMenu();
        }

        private void SettControlsMenu()
        {
            cmbTAmarilla.Items.Add("1");
            cmbTAmarilla.Items.Add("2");

            IsVisible(false);
        }
        private void IsVisible(bool value)
        {
            txtGPenal.Visible = value;
            txtGTiroLibre.Visible = value;
            lbGPenal.Visible = value;
            lbGTiroLibre.Visible = value;
        }
        private void cbTAmarilla_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTAmarilla.Checked)
                cmbTAmarilla.Enabled = true;
            else
                cmbTAmarilla.Enabled = false;
        }

        private void VerifyParseNumbersCamps(Control.ControlCollection controls)
        {
            try
            {
                foreach (Control item in Controls)
                {
                    if (item is TextBox txt && txt.Tag == "parse" && !string.IsNullOrEmpty(txt.Text.Trim()))
                    {
                        int.Parse(txt.Text);
                    }
                }
            }
            catch (FormatException e)
            {

                throw new txtIsNotParseNumber
                    (
                        "Formato De texto no valido para parsear", this.GetType().Name,
                        MethodBase.GetCurrentMethod().Name,
                        e
                    );
            }
            catch (OverflowException ex)
            {

                throw new txtIsNotParseNumber
                   (
                       "Texto supera los limites INT", this.GetType().Name,
                       MethodBase.GetCurrentMethod().Name,
                       ex
                   ); 
            }
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {

                VerifyParseNumbersCamps(this.Controls);
               
            }
            catch (txtIsNotParseNumber ex)
            {
                    MessageBox.Show($"{ex}");
                /*Console.WriteLine($"{ex.ToString()}");*/
                //Exception inner = ex.InnerException;
                /*Exception inner = ex;
                while (inner is not null)
                {
                    MessageBox.Show($"{inner.ToString()}");
                    inner = inner.InnerException;
                }*/
                ClearCamps();
            }
            if (CheckCamps())
            {

                //
                string fechaRegistro = DateTime.Now.Date.ToString("dd-MM-yyyy");
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
                EFutbolista stat = new EFutbolista(titular, goles, asistencias, amarilla, roja, minutos, resultado, fecha, rival, competicion, estadio, comentario, Atleta.FullName, fechaRegistro, NickName);

                if (txtGPenal.Visible is true && txtGTiroLibre.Visible is true)
                {
                    stat.GolesPenal = txtGPenal.Text;
                    stat.GolesTiroLibre = txtGTiroLibre.Text;
                }

                if (Atleta + stat)
                {

                    D.Estadisticas.Add(stat);
                    D.CargarEstadisticaAlArchivo1(Atleta.MisEstadisticas(NickName), D.Estadisticas);
                    MessageBox.Show($"Estadistica Cargada Con Exito", "Congratulations", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Su Estadistica A Cargar, Ya Existe", "Estadistica Existense", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


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

                if (value is RichTextBox rtc)
                    rtc.Clear();
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
                if(value is TextBox txt && txt.Visible is true)
                {
                    if (string.IsNullOrEmpty(txt.Text.Trim()))
                        return false;
                }

                if (value is RichTextBox rtb && string.IsNullOrEmpty(rtb.Text.Trim()))
                {
                    return false;
                }

            }
            return true;
        }

        private void txtGoles_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(txtGoles.Text, out int goles) && goles > 0)
            {
                IsVisible(true);
            }
            else
            {
                IsVisible(false);

            }
        }
    }
}
