using Entities;
using Service;

namespace PlayerStats
{
    public partial class FrmCargarDeportista : Form
    {
       // public virtual void AbrirFormulario();
        public User UserLogueado
        {
            get;
            set;
        }
        public Deportistas D
        {
            get;
            set;
        }
        public FrmCargarDeportista()
        {
            InitializeComponent();
            cmbPhHabil.DataSource = Enum.GetValues(typeof(ELadoHabil));
            cmbPhHabil.SelectedIndex = -1;
            lbHoraActual.Text = DateTime.Now.ToString();
            lbUser.Text = UserLogueado?.NickName;
        }

        protected bool ComprobarCamposNull()
        {
            foreach (Control value in this.Controls)
            {
                if (value is TextBox txt && string.IsNullOrEmpty(txt.Text.Trim()))
                    return false;

                if (value is ComboBox cb && cb.SelectedIndex == -1)
                    return false;
            }
            return true;
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
            else if (mCalendar.SelectionRange.Start.Date == DateTime.Today.Date)
            {
                DialogResult res = MessageBox.Show("La fecha seleccionada es la actual, Desea Cambiarla?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Cancel)
                    ok = true;
            }
            else
                ok = true;

            return ok;
        }

    }
}
