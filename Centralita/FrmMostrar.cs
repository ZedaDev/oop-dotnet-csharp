using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralTelefonica;
namespace Centralita
{
    public partial class FrmMostrar : Form
    {

        private CentralTelefonica.Centralita _c;
        private ETipoDeLlamada _tipoDeLlamada;
        public FrmMostrar(CentralTelefonica.Centralita c)
        {
            InitializeComponent();
            
            _c = c;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            this.MostrarFacturacion();
        }

        public ETipoDeLlamada TipoLlamada
        {
            set
            {
                _tipoDeLlamada = value;
            }
        }
        private void MostrarFacturacion()
        {
            if(_tipoDeLlamada == ETipoDeLlamada.Local)
               rtbMostrar.Text = $"Ganancia De Llamadas Locales : ${_c.GananciasPorLocal}";
            else if (_tipoDeLlamada == ETipoDeLlamada.Provincial)
                rtbMostrar.Text = $"Ganancia De Llamadas Provinciales : ${_c.GananciasPorProvincial}";
            else
                rtbMostrar.Text = $"Ganancia De Todas Las Llamadas: ${_c.GananciasPorTotal:F2}\n {_c.ToString()}";
        }
    }
}
