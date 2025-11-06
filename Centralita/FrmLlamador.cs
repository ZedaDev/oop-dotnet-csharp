using CentralTelefonica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centralita
{
    public partial class FrmLlamador : Form
    {
        protected EFranja _franja;
        protected CentralTelefonica.Centralita _c;
        protected ETipoDeLlamada _tipoLlamada;
        /*FrmLlamador tendrá una propiedad de sólo lectura que expondrá dicha Centralita,
         * a fin de volver a ser leída por el formulario de menú una vez terminada
         * la acción.*/
        public FrmLlamador(CentralTelefonica.Centralita c)
        {
            InitializeComponent();
            _c = c;
        }
        private void FrmLlamador_Load(object sender, EventArgs e)
        {

            cbmFranja.DataSource = Enum.GetValues(typeof(EFranja));
            txtNroDestino.ReadOnly = true;
            foreach (Control ctr in Controls)
            {
                if (ctr is TextBox txt)
                {
                    txt.MaxLength = 10;
                }
            }

        }


        public CentralTelefonica.Centralita Centralita
        {
            get
            {
                return _c;
            }
        }

        private string ValidateTxt
        {
            set
            {
                TextBox txt = IsActive();
                Regex regex = new(@"^\d{1,10}$");//1 a 10 numeros, maximo 10.
                if (!regex.IsMatch(value))
                {
                    MessageBox.Show("ERROR!, solo se permiten datos numericos");
                    txt.Clear();
                    txt.Focus();
                }

            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (txtNroDestino == IsActive())
                    txtNroDestino.Text += btn.Text;

                if (txtNroDestino.TextLength >= 1 && txtNroDestino.Text[0] == '#')
                    cbmFranja.Enabled = true;
                else
                    cbmFranja.Enabled = false;
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TextBox txt = IsActive();
            CleanTxt(txt);
        }

        private void txtNroOrigen_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.Tag = "Active";
                foreach (Control control in Controls)
                {
                    if (control is TextBox otherTxt && otherTxt != txt)
                    {
                        otherTxt.Tag = "false";
                    }
                }

            }
        }

        private void CleanTxt(TextBox txt)
        {

            if (txt is not null)
            {
                txt.Clear();
                txt.Tag = "false";
            }
        }
        private TextBox IsActive()
        {
            foreach (Control control in this.Controls)
            {

                if (control is TextBox txt && txt.Tag?.ToString() == "Active")
                {
                    return txt;
                    // Salimos del bucle después de limpiar el TextBox enfocado

                }
            }
            return null;
        }



        private void txtNroDestino_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                if (!string.IsNullOrEmpty(txt.Text))
                    ValidateTxt = txt.Text;
            }
        }

        private void cbmFranja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmFranja.SelectedIndex >= 0)
                Enum.TryParse(cbmFranja.SelectedValue.ToString(), out _franja);
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if (txtNroDestino != null && txtNroOrigen != null)
            {
                Random random = new();
                if (txtNroDestino.Text[0] != '#')
                {
                    Local local = new("Buenos Aires", random.Next(1, 50), "La Plata", (float)(random.NextDouble() * (5.1) + 0.5));

                    //_c += local;
                    //_c += local;
                    Centralita.Llamadas.Add(local);

                    MessageBox.Show($"Llamada Local realizada\n{local.ToString()}");
                    LimpiarCampos();

                }
                else
                {
                    Provincial prov = new(random.Next(1, 50), "Rosario", "La Plata", _franja);
                    Centralita.Llamadas.Add(prov);
                    //_c += prov;


                    MessageBox.Show($"Llamada Provincial realizada\n{prov.ToString()}");
                    LimpiarCampos();

                }

            }
        }
        private void LimpiarCampos()
        {
            // Limpiar los campos de texto
            txtNroOrigen.Clear();
            txtNroDestino.Clear();

            // Limpiar la franja horaria si estaba habilitada
            cbmFranja.SelectedIndex = -1;
            cbmFranja.Enabled = false;

            // Reiniciar el estado de los botones de la interfaz
            txtNroDestino.Focus(); // Volver a enfocar el cuadro de texto de destino
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
