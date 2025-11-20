namespace PlayerStats
{
    partial class FrmVerEstadisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            SuspendLayout();
            // 
            // lbUser
            // 
            lbUser.Size = new Size(71, 19);
            lbUser.Text = "USUARIO";
            // 
            // lbDateTime
            // 
            lbDateTime.ForeColor = Color.Green;
            lbDateTime.Location = new Point(621, -1);
            lbDateTime.Size = new Size(85, 19);
            lbDateTime.Text = "19/11/2025";
            // 
            // btnAgregar
            // 
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbDeporte
            // 
            cmbDeporte.DataSource = new EDeporte[]
    {
    EDeporte.Futbol,
    EDeporte.Boxeo,
    EDeporte.Tenis
    };
            // 
            // lvVisor
            // 
            //lvVisor.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
            // 
            // FrmVerEstadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(718, 332);
            Name = "FrmVerEstadisticas";
            Text = "FrmVerEstadisticas";
            Load += FrmVerEstadisticas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //private ComboBox cmbOrdenStats;
        //private Label lbOrdenar;
    }
}