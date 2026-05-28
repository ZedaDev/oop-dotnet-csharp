using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C18Hilos
{
    public partial class FrmEjercicio1Relojero : Form
    {

        Task taskHora;
        CancellationTokenSource cancellation;
        public FrmEjercicio1Relojero()
        {
            InitializeComponent();
        }

        public void IniciarReloj()
        {
            while (!cancellation.IsCancellationRequested)
            {
                this.AsignarHora();

                Thread.Sleep(1000);
            }
        }
        private void AsignarHora()
        {
       
                if (this.InvokeRequired)
                {
                    this.BeginInvoke(this.AsignarHora);
                }
                else
                {

                    this.lbHora.Text = DateTime.Now.ToString("HH:mm:ss");
                 }

                
       }

          
        


        private void FrmEjercicio1Relojero_Load(object sender, EventArgs e)
        {
            InstanceTaskAndCancellation();

        }
        private void InstanceTaskAndCancellation()
        {
            this.cancellation = new();
            this.taskHora = Task.Run(this.IniciarReloj, cancellation.Token);
        }

        private void FrmEjercicio1Relojero_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.cancellation.Cancel();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            this.cancellation.Cancel();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Si el hilo esta corriendo(no fue cancelado) no hace nada
            //Si el hilo no esta corriendo, ejecuta nuevamente la Tarea

            if(taskHora.Status != TaskStatus.Running)
                InstanceTaskAndCancellation();

        }
    }
}
