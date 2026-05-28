using Entities;
using Service;
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
    public partial class FrmFutbolistaDates : FrmDeportistaDates
    {
        public FrmFutbolistaDates()
        {
            InitializeComponent();
        }

        private void CharguingDates()
        {
            Futbolista f = (Futbolista)Deportistas.MyAtleta;
            //TotalStatsFutbolista tSF = f.CalcularStats<TotalStatsFutbolista>();
            TotalStatsFutbolista tSF = f.AllStatsDat1<TotalStatsFutbolista>();

            //Manejar aqui los colores del txt Debut,etc <--
            lbNombre.Text = $"{f.FullName}";
            lbApodo.Text = f.Apodo;
            lbAltura.Text = $"{f.Altura}cms.";
            lbClubActual.Text = $"Club Actual {f.ClubActual}";
            lbPosicion.Text = f.Posicion; lbPosicion.ForeColor = Color.LightGreen;
            lbPHabil.Text = f.PhHabil == ELadoHabil.Izq ? "Zurdo" : "Diestro";
            

            lbPartidosJugados.Text = $"[{tSF.PartidosJugados}]"; lbPartidosJugados.ForeColor = Color.LightGreen;
            lbPartidosGanados.Text = $"{tSF.PartidosGanados}";
            lbPartidosEmpatados.Text = $"{tSF.PartidosEmpatados}";
            lbPartidosPerdidos.Text = $"{tSF.PartidosPerdidos}"; lbMvp.ForeColor = Color.IndianRed;
            lbMvp.Text = $"[{tSF.MvpTotal}]"; lbMvp.ForeColor = Color.LightGreen;
            lbGTiroLibre.Text = $"{tSF.GolesTotalesTiroLibre} "; lbGTiroLibre.ForeColor = Color.LightGreen;
            lbGPenal.Text = $"{tSF.GolesTotalesPenal}";
            lbGoles.Text = $"{tSF.GolesTotales}"; lbGoles.ForeColor = Color.DarkGreen;
            lbAsistencias.Text = $"{tSF.AsistenciasTotales}"; lbGoles.ForeColor = Color.LightGreen;
            lbTarjetaAmarilla.Text = $"{tSF.TarjetaAmarillaTotal}";
            lbTarjetaRoja.Text = $"{tSF.TarjetaRojaTotal}"; lbTarjetaRoja.ForeColor = Color.Red;
            lbDebut.Text = tSF.PartidoDebut; lbDebut.ForeColor = Color.LightGreen;

                string message = "Meses";
            if(tSF.TiempoDeCarrera >= 1)
            {
                message = "Años";
            }
            
            lbTiempoCarrera.Text = $"{tSF.TiempoDeCarrera} {message} "; lbTiempoCarrera.ForeColor = Color.SpringGreen;
            lbTitularidades.Text = $"{tSF.TitularTotales}"; lbDebut.ForeColor = Color.LightGreen;
            lbMinutosJugados.Text = $"[{tSF.MinutosTotales}]"; lbDebut.ForeColor = Color.SpringGreen;
            // Establecer el contenido con dos líneas vacías arriba (para mover el texto hacia abajo)
            rtbComentario.Text = $"{f.Comentario}";

            // Configuración básica del RichTextBox
            rtbComentario.Padding = new Padding(5, 3, 5, 3);  // Márgenes: izquierda(5), arriba(1), derecha(5), abajo(3)

            // Márgenes para el texto
            rtbComentario.SelectionIndent = 8;  // Desplaza el texto hacia la derecha
            rtbComentario.SelectionRightIndent = 8; // Desplaza el texto hacia la izquierda

            // Estilo visual
            rtbComentario.BackColor = Color.FromArgb(240, 240, 240);  // Fondo claro
            rtbComentario.ForeColor = Color.DarkSlateGray;  // Texto oscuro
            rtbComentario.Font = new Font("Arial", 10, FontStyle.Regular);  // Fuente

            // Configuración de bordes redondeados (si usas un control personalizado)
            rtbComentario.BorderStyle = BorderStyle.None;  // Eliminar borde por defecto

        }

        private void MiFormulario_Load(object sender, EventArgs e)
        {
            if(Deportistas.MyAtleta.Estadisticas.Count <= 0)
            {
                AccesoDatos ac = new();
                ac.TraerEstadisticasDeportista(Deportistas.MyAtleta);
            }
            EnableDisabledTextBox();
            CharguingDates();
        }
        public void EnableDisabledTextBox()
        {
            foreach (Control value in Controls)
            {
               

                if (value is Label lb)
                {
                    lb.BackColor = Color.Transparent;
                    lb.ForeColor = Color.White;
                    lb.Font = new Font(lb.Font,FontStyle.Bold);
                    
                }

            }
        }

        private void lbPosicion_Click(object sender, EventArgs e)
        {

        }
    }
}
