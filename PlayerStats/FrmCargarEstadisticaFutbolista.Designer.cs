namespace PlayerStats
{
    partial class FrmCargarEstadisticaFutbolista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargarEstadisticaFutbolista));
            cbTitutlar = new CheckBox();
            txtGoles = new TextBox();
            txtAsistencias = new TextBox();
            txtMinutosJugados = new TextBox();
            lbGoles = new Label();
            lbAsistencias = new Label();
            lbMinutos = new Label();
            cmbTAmarilla = new ComboBox();
            cbTRoja = new CheckBox();
            cbTAmarilla = new CheckBox();
            SuspendLayout();
            // 
            // btnCargar
            // 
            btnCargar.Click += btnCargar_Click;
            // 
            // cbTitutlar
            // 
            cbTitutlar.AutoSize = true;
            cbTitutlar.Location = new Point(330, 236);
            cbTitutlar.Name = "cbTitutlar";
            cbTitutlar.Size = new Size(59, 19);
            cbTitutlar.TabIndex = 26;
            cbTitutlar.Text = "Titular";
            cbTitutlar.UseVisualStyleBackColor = true;
            // 
            // txtGoles
            // 
            txtGoles.Location = new Point(12, 236);
            txtGoles.Name = "txtGoles";
            txtGoles.Size = new Size(100, 23);
            txtGoles.TabIndex = 27;
            // 
            // txtAsistencias
            // 
            txtAsistencias.Location = new Point(185, 236);
            txtAsistencias.Name = "txtAsistencias";
            txtAsistencias.Size = new Size(100, 23);
            txtAsistencias.TabIndex = 28;
            // 
            // txtMinutosJugados
            // 
            txtMinutosJugados.Location = new Point(339, 151);
            txtMinutosJugados.Name = "txtMinutosJugados";
            txtMinutosJugados.Size = new Size(100, 23);
            txtMinutosJugados.TabIndex = 29;
            // 
            // lbGoles
            // 
            lbGoles.AutoSize = true;
            lbGoles.Location = new Point(3, 218);
            lbGoles.Name = "lbGoles";
            lbGoles.Size = new Size(36, 15);
            lbGoles.TabIndex = 30;
            lbGoles.Text = "Goles";
            // 
            // lbAsistencias
            // 
            lbAsistencias.AutoSize = true;
            lbAsistencias.Location = new Point(171, 218);
            lbAsistencias.Name = "lbAsistencias";
            lbAsistencias.Size = new Size(65, 15);
            lbAsistencias.TabIndex = 32;
            lbAsistencias.Text = "Asistencias";
            // 
            // lbMinutos
            // 
            lbMinutos.AutoSize = true;
            lbMinutos.Location = new Point(330, 133);
            lbMinutos.Name = "lbMinutos";
            lbMinutos.Size = new Size(97, 15);
            lbMinutos.TabIndex = 36;
            lbMinutos.Text = "Minutos Jugados";
            // 
            // cmbTAmarilla
            // 
            cmbTAmarilla.FormattingEnabled = true;
            cmbTAmarilla.Location = new Point(339, 71);
            cmbTAmarilla.Name = "cmbTAmarilla";
            cmbTAmarilla.Size = new Size(121, 23);
            cmbTAmarilla.TabIndex = 37;
            // 
            // cbTRoja
            // 
            cbTRoja.AutoSize = true;
            cbTRoja.Location = new Point(498, 71);
            cbTRoja.Name = "cbTRoja";
            cbTRoja.Size = new Size(86, 19);
            cbTRoja.TabIndex = 38;
            cbTRoja.Text = "Tarjeta Roja";
            cbTRoja.UseVisualStyleBackColor = true;
            // 
            // cbTAmarilla
            // 
            cbTAmarilla.AutoSize = true;
            cbTAmarilla.Location = new Point(330, 46);
            cbTAmarilla.Name = "cbTAmarilla";
            cbTAmarilla.Size = new Size(107, 19);
            cbTAmarilla.TabIndex = 39;
            cbTAmarilla.Text = "Tarjeta Amarilla";
            cbTAmarilla.UseVisualStyleBackColor = true;
            cbTAmarilla.CheckedChanged += cbTAmarilla_CheckedChanged;
            // 
            // FrmCargarEstadisticaFutbolista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(913, 532);
            Controls.Add(cbTAmarilla);
            Controls.Add(cbTRoja);
            Controls.Add(cmbTAmarilla);
            Controls.Add(lbMinutos);
            Controls.Add(lbAsistencias);
            Controls.Add(lbGoles);
            Controls.Add(txtMinutosJugados);
            Controls.Add(txtAsistencias);
            Controls.Add(txtGoles);
            Controls.Add(cbTitutlar);
            Name = "FrmCargarEstadisticaFutbolista";
            Text = "FrmCargarEstadisticaFutbolista";
            Load += FrmCargarEstadisticaFutbolista_Load;
            Controls.SetChildIndex(rtcComentario, 0);
            Controls.SetChildIndex(txtRival, 0);
            Controls.SetChildIndex(txtResultado, 0);
            Controls.SetChildIndex(txtCompeticion, 0);
            Controls.SetChildIndex(txtEstadio, 0);
            Controls.SetChildIndex(mcFecha, 0);
            Controls.SetChildIndex(btnCargar, 0);
            Controls.SetChildIndex(cbTitutlar, 0);
            Controls.SetChildIndex(txtGoles, 0);
            Controls.SetChildIndex(txtAsistencias, 0);
            Controls.SetChildIndex(txtMinutosJugados, 0);
            Controls.SetChildIndex(lbGoles, 0);
            Controls.SetChildIndex(lbAsistencias, 0);
            Controls.SetChildIndex(lbMinutos, 0);
            Controls.SetChildIndex(cmbTAmarilla, 0);
            Controls.SetChildIndex(cbTRoja, 0);
            Controls.SetChildIndex(cbTAmarilla, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbTitutlar;
        private TextBox txtGoles;
        private TextBox txtAsistencias;
        private TextBox txtMinutosJugados;
        private Label lbGoles;
        private Label lbAsistencias;
        private Label lbMinutos;
        private ComboBox cmbTAmarilla;
        private CheckBox cbTRoja;
        private CheckBox cbTAmarilla;
    }
}