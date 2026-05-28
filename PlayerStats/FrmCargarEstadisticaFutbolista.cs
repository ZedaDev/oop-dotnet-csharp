using Entities;
using ProjectExceptions;
using Service;



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
        public override void PrintDates()
        {
            SettControlsMenu();
            PrintInfoStat();
        }
        private void PrintInfoStat()
        {
            if (Stat is EFutbolista v)
            {
                mcFecha.SetDate(v.Fecha);
                //cmbScore.SelectedIndex = 
               
                rtcComentario.Text = v.Comentario;

                txtRival.Text = v.Rival;
                txtResultado.Text = v.Resultado;
                txtEstadio.Text = v.Estadio;
                txtCompeticion.Text = v.Competicion;

                txtGoles.Text = v.Goles;
                //Logica mostrar label y texbox de gol de penal y de tiro libre.
                if (int.Parse(v.Goles) > 0)
                {
                    if (int.Parse(v.GolesPenal) > 0)
                    {
                        lbGPenal.Visible = true;
                        txtGPenal.Visible = true;
                        txtGPenal.Text = v.GolesPenal;
                        txtGPenal.Enabled = false;
                    }
                    else if (int.Parse(v.GolesTiroLibre) > 0)
                    {
                        lbGTiroLibre.Visible = true;
                        txtGTiroLibre.Visible = true;
                        txtGTiroLibre.Text = v.GolesTiroLibre;
                        txtGTiroLibre.Enabled = false;
                    }

                }
                txtAsistencias.Text = v.Asistencias;
                txtMinutosJugados.Text = v.MinutosJugados;
                //SettControlsMenu();
                    if (v.TarjetaAmarilla == 1)
                        cmbTAmarilla.SelectedIndex = 0;
                    else if(v.TarjetaAmarilla < 1)
                        cmbTAmarilla.SelectedIndex = -1;
                    else 
                        cmbTAmarilla.SelectedIndex = 1;


                    cbTitutlar.Checked = v.Titular;
                    cbTRoja.Checked = v.TarjetaRoja;
                    cbMvp.Checked = v.Mvp;
            }
        }
        private void IsVisible(bool value)
        {
            txtGPenal.Visible = value;
            txtGTiroLibre.Visible = value;
            lbGPenal.Visible = value;
            lbGTiroLibre.Visible = value;
            cmbTAmarilla.Enabled = value;
        }
        private void SettControlsMenu()
        {
            if (cmbTAmarilla.Items.Count == 0)
            {
                cmbTAmarilla.Items.Add("1");
                cmbTAmarilla.Items.Add("2");
                IsVisible(false);
            }
            
            

            if (IsModifier)
            {
                btnCargar.Text = "Modificar";
                cmbScore.DataSource = Enum.GetValues(typeof(EResultado));
                cmbScore.SelectedIndex = (int)Stat.Score;

            }
            else
                cmbScore.SelectedIndex = -1;
        }

        private void cbTAmarilla_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTAmarilla.Checked)
                cmbTAmarilla.Enabled = true;
            else
                cmbTAmarilla.Enabled = false;
        }

        private EFutbolista? ObtenerEstadistica()
        {
            if (CheckCamps())
            {

                //
                DateTime fechaRegistro = DateTime.Now.Date;
                DateTime fecha = mcFecha.SelectionStart;
                EResultado score = (EResultado)cmbScore.SelectedIndex;
                string goles = txtGoles.Text;
                string rival = txtRival.Text;
                string resultado = txtResultado.Text;
                string competicion = txtCompeticion.Text;
                string estadio = txtEstadio.Text;
                string asistencias = txtAsistencias.Text;
                string minutos = txtMinutosJugados.Text;
                int amarilla = 0;
                if (cbTAmarilla.Checked)
                    amarilla = cmbTAmarilla.SelectedIndex+1;

                string comentario = rtcComentario.Text;
                bool roja = cbTRoja.Checked;
                bool titular = cbTitutlar.Checked;
                EFutbolista stat = new(titular, goles, asistencias, amarilla, roja, minutos, resultado, fecha, rival, competicion, estadio, comentario, Deportistas.MyAtleta.FullName, fechaRegistro, Usuarios.MyUser.NickName, score);
                stat.Mvp = cbMvp.Checked;
                stat.club = txtClubActual.Text;

                if (txtGPenal.Visible is true && txtGTiroLibre.Visible is true)
                {
                    stat.GolesPenal = txtGPenal.Text;
                    stat.GolesTiroLibre = txtGTiroLibre.Text;
                }

                return stat;

            }
            else
                return null;
        }
        public void btnCargar_Click(object sender, EventArgs e)
        {
           
                   EFutbolista stat = ObtenerEstadistica();
            
            if (IsModifier)
            {
                        stat.Id = Stat.Id;

            }


                try
                {
                        if(stat is not null)
                           CargarModificarEstadisticaBDDJson(stat);
                  
                }
                catch (Exception)
                {

                    MessageBox.Show("Error", "Estadistica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            } //esto lo deberia encapsular en metodos y poner todo dentro del TRY, luego segun el isModifier
        // entrar a un metodo o el otro.

        private bool CargarModificarEstadisticaBDDJson(EFutbolista stat)
        {
            if (IsModifier)
            {
                ModificarEstadisticaBDDJson(stat);
            }
            else
            {
                CargarEstadisticaBDDJson(stat);
            }

                return true;
        }

        private void CargarEstadisticaBDDJson(EFutbolista stat)
        {

            AccesoDatos ac = new();
            if (ac.InsertarEstadisticasFutbolista(stat, Usuarios.MyUser.Id, Deportistas.MyAtleta.Id))
            {

                Deportistas.MyAtleta.AgregarEstadistica = stat;
                
                Serializer<Deportista>.JsonSerializerList(Deportistas.Atletas, Paths.DeportistasPath);
                MessageBox.Show($"Estadistica Cargada Con Exito BDD", "Congratulations", MessageBoxButtons.OK);
                ClearCamps(); //Limpio todos los textboxs,etc.
            }
            else
                MessageBox.Show($"Estadistica ERROR", "ERROR", MessageBoxButtons.OK);

        }
        private void ModificarEstadisticaBDDJson(EFutbolista stat)
        {
            AccesoDatos ac1 = new();

            if (ac1.UpdateEstadisticaFutbolista(stat, Deportistas.MyAtleta.Id, Usuarios.MyUser.Id))
            {
                Deportistas.MyAtleta.Estadisticas[Indice] = stat; 
                MessageBox.Show($"Estadistica Modificada Con Exito en BDD", "Congratulations Base De Datos", MessageBoxButtons.OK);
                ClearCamps(); //Limpio todos los textboxs,etc.
            }
            else
                MessageBox.Show($"ERROR!", "ERROR Base De Datos", MessageBoxButtons.OK);
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

        public bool CheckCamps()
        {
            bool ok = false;


            if (!ComprobarCamposNull())
                MessageBox.Show("Asegurese de completar todos los campos", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            /*else if (mcFecha.SelectionRange.Start.Date == DateTime.Today.Date)
            {
                DialogResult res = MessageBox.Show("La fecha seleccionada es la actual, Desea Cambiarla?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Cancel)
                    ok = true;
            }*/
            else
                ok = true;

            return ok;
        }

        public bool ComprobarCamposNull()
        {
            foreach (Control value in this.Controls)
            {
                if (value is TextBox txt && txt.Visible is true)
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
            if (int.TryParse(txtGoles.Text, out int goles) && goles > 0)
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
