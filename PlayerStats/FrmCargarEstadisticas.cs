using Entities;

namespace PlayerStats
{
    public abstract partial class FrmCargarEstadisticas : Form
    {
        public int Indice
        {
            get;
            set;
        }
        public bool IsModifier
        {
            get;
            set;
        }

        public IEstadistica Stat { get; set; }

        public FrmCargarEstadisticas()
        {
            InitializeComponent();

        }

        public abstract void PrintDates();

        private void FrmCargarEstadisticas_Load(object sender, EventArgs e)
        {
            cmbScore.DataSource = Enum.GetValues(typeof(EResultado));
           
            txtResultado.Enabled = false;
        }

        private void cmbScore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbScore.SelectedIndex >= 0)
                txtResultado.Enabled = true;
            else
                txtResultado.Enabled = false;
        }
    }
}
