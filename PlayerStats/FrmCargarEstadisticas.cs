using Entities;
using Service;
using ProjectExceptions;
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
    public partial class FrmCargarEstadisticas : Form
    {
        protected Deportista _atleta;
        protected Deportistas _d;
        public string NickName { get; set; }
        public Deportista Atleta
        {
            get => _atleta;
            set
            {
                if (value is not null)
                    _atleta = value;
            }
        }
        public Deportistas D
        {
            get => _d;
            set
            {
                if (value is not null)
                    _d = value;
            }
        }
        public FrmCargarEstadisticas()
        {
            InitializeComponent();
        }


    }
}
