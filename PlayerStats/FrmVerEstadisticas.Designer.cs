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
            lbDateTime.Text = "21/11/2025";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(3, 295);
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
            //cmbDeporte.Items.AddRange(new object[] { EDeporte.Futbol, EDeporte.Boxeo, EDeporte.Tenis });
            cmbDeporte.Location = new Point(247, 12);
            // 
            // lvVisor
            // 
            lvVisor.Location = new Point(15, 53);
            // 
            // lbVisorCargado
            // 
            lbVisorCargado.Size = new Size(170, 13);
            lbVisorCargado.Text = "No Hay Deportistas Cargados Aun";
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