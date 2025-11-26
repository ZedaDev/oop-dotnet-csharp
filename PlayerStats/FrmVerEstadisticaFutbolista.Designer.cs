namespace PlayerStats
{
    partial class FrmVerEstadisticaFutbolista
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
            lbTitular = new Label();
            lbGoles = new Label();
            lbAsistencias = new Label();
            lbMinutos = new Label();
            lbTAmarilla = new Label();
            lbTRoja = new Label();
            lbTiroLibre = new Label();
            lbGolPenal = new Label();
            SuspendLayout();
            // 
            // lbTitular
            // 
            lbTitular.AutoSize = true;
            lbTitular.Location = new Point(272, 64);
            lbTitular.Name = "lbTitular";
            lbTitular.Size = new Size(51, 15);
            lbTitular.TabIndex = 8;
            lbTitular.Text = "TITULAR";
            // 
            // lbGoles
            // 
            lbGoles.AutoSize = true;
            lbGoles.Location = new Point(272, 114);
            lbGoles.Name = "lbGoles";
            lbGoles.Size = new Size(42, 15);
            lbGoles.TabIndex = 10;
            lbGoles.Text = "GOLES";
            // 
            // lbAsistencias
            // 
            lbAsistencias.AutoSize = true;
            lbAsistencias.Location = new Point(272, 161);
            lbAsistencias.Name = "lbAsistencias";
            lbAsistencias.Size = new Size(76, 15);
            lbAsistencias.TabIndex = 12;
            lbAsistencias.Text = "ASISTENCIAS";
            // 
            // lbMinutos
            // 
            lbMinutos.AutoSize = true;
            lbMinutos.Location = new Point(272, 211);
            lbMinutos.Name = "lbMinutos";
            lbMinutos.Size = new Size(112, 15);
            lbMinutos.TabIndex = 14;
            lbMinutos.Text = "MINUTOS JUGADOS";
            // 
            // lbTAmarilla
            // 
            lbTAmarilla.AutoSize = true;
            lbTAmarilla.Location = new Point(484, 161);
            lbTAmarilla.Name = "lbTAmarilla";
            lbTAmarilla.Size = new Size(110, 15);
            lbTAmarilla.TabIndex = 16;
            lbTAmarilla.Text = "TARJETA AMARILLA";
            // 
            // lbTRoja
            // 
            lbTRoja.AutoSize = true;
            lbTRoja.Location = new Point(484, 211);
            lbTRoja.Name = "lbTRoja";
            lbTRoja.Size = new Size(81, 15);
            lbTRoja.TabIndex = 18;
            lbTRoja.Text = "TARJETA ROJA";
            // 
            // lbTiroLibre
            // 
            lbTiroLibre.AutoSize = true;
            lbTiroLibre.Location = new Point(484, 64);
            lbTiroLibre.Name = "lbTiroLibre";
            lbTiroLibre.Size = new Size(119, 15);
            lbTiroLibre.TabIndex = 20;
            lbTiroLibre.Text = "GOLES DE TIRO LIBRE";
            // 
            // lbGolPenal
            // 
            lbGolPenal.AutoSize = true;
            lbGolPenal.Location = new Point(484, 114);
            lbGolPenal.Name = "lbGolPenal";
            lbGolPenal.Size = new Size(98, 15);
            lbGolPenal.TabIndex = 22;
            lbGolPenal.Text = "GOLES DE PENAL";
            // 
            // FrmVerEstadisticaFutbolista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 502);
            Controls.Add(lbGolPenal);
            Controls.Add(lbTiroLibre);
            Controls.Add(lbTRoja);
            Controls.Add(lbTAmarilla);
            Controls.Add(lbMinutos);
            Controls.Add(lbAsistencias);
            Controls.Add(lbGoles);
            Controls.Add(lbTitular);
            Name = "FrmVerEstadisticaFutbolista";
            Text = "FrmVerEstadisticaFutbolista";
            Controls.SetChildIndex(lbTitular, 0);
            Controls.SetChildIndex(lbGoles, 0);
            Controls.SetChildIndex(lbAsistencias, 0);
            Controls.SetChildIndex(lbMinutos, 0);
            Controls.SetChildIndex(lbTAmarilla, 0);
            Controls.SetChildIndex(lbTRoja, 0);
            Controls.SetChildIndex(lbTiroLibre, 0);
            Controls.SetChildIndex(lbGolPenal, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitular;
        private Label lbGoles;
        private Label lbAsistencias;
        private Label lbMinutos;
        private Label lbTAmarilla;
        private Label lbTRoja;
        private Label lbTiroLibre;
        private Label lbGolPenal;
    }
}