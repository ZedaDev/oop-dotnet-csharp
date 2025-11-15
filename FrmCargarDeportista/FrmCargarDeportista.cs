using Entities;
using Service;

namespace FrmCargarDeportista
{
    public partial class FrmCargarDeportista : Form
    {
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
        }

        protected bool ComprobarCamposNull()
        {
            foreach (Control value in this.Controls)
            {
                if (value is TextBox txt && string.IsNullOrEmpty(txt.Text.Trim()))
                {
                    return false;
                }
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
    }
}
