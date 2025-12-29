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

        public IEstadisticaFutbolista Stat { get; set; }
       
        public FrmCargarEstadisticas()
        {
            InitializeComponent();
        }

        public abstract void PrintDates();
    }
}
