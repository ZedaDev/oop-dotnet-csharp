namespace PlayerStats
{
    partial class FrmCargarEstadisticas
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
            lbRival = new Label();
            lbResultado = new Label();
            lbCompeticion = new Label();
            lbEstadio = new Label();
            rtcComentario = new RichTextBox();
            txtRival = new TextBox();
            txtResultado = new TextBox();
            txtCompeticion = new TextBox();
            txtEstadio = new TextBox();
            mcFecha = new MonthCalendar();
            lbFecha = new Label();
            btnCargar = new Button();
            lbComentario = new Label();
            SuspendLayout();
            // 
            // lbRival
            // 
            lbRival.AutoSize = true;
            lbRival.Location = new Point(3, 53);
            lbRival.Name = "lbRival";
            lbRival.Size = new Size(32, 15);
            lbRival.TabIndex = 0;
            lbRival.Text = "Rival";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(171, 53);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(59, 15);
            lbResultado.TabIndex = 1;
            lbResultado.Text = "Resultado";
            // 
            // lbCompeticion
            // 
            lbCompeticion.AutoSize = true;
            lbCompeticion.Location = new Point(171, 133);
            lbCompeticion.Name = "lbCompeticion";
            lbCompeticion.Size = new Size(76, 15);
            lbCompeticion.TabIndex = 3;
            lbCompeticion.Text = "Competicion";
            // 
            // lbEstadio
            // 
            lbEstadio.AutoSize = true;
            lbEstadio.Location = new Point(3, 133);
            lbEstadio.Name = "lbEstadio";
            lbEstadio.Size = new Size(45, 15);
            lbEstadio.TabIndex = 5;
            lbEstadio.Text = "Estadio";
            // 
            // rtcComentario
            // 
            rtcComentario.Location = new Point(3, 335);
            rtcComentario.Name = "rtcComentario";
            rtcComentario.Size = new Size(396, 180);
            rtcComentario.TabIndex = 10;
            rtcComentario.Text = "";
            // 
            // txtRival
            // 
            txtRival.Location = new Point(12, 71);
            txtRival.Name = "txtRival";
            txtRival.Size = new Size(100, 23);
            txtRival.TabIndex = 11;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(185, 71);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 13;
            // 
            // txtCompeticion
            // 
            txtCompeticion.Location = new Point(185, 151);
            txtCompeticion.Name = "txtCompeticion";
            txtCompeticion.Size = new Size(100, 23);
            txtCompeticion.TabIndex = 15;
            // 
            // txtEstadio
            // 
            txtEstadio.Location = new Point(12, 151);
            txtEstadio.Name = "txtEstadio";
            txtEstadio.Size = new Size(100, 23);
            txtEstadio.TabIndex = 17;
            // 
            // mcFecha
            // 
            mcFecha.Location = new Point(662, 38);
            mcFecha.Name = "mcFecha";
            mcFecha.TabIndex = 22;
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Location = new Point(621, 18);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(97, 15);
            lbFecha.TabIndex = 23;
            lbFecha.Text = "Seleccione Fecha";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(749, 485);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(161, 40);
            btnCargar.TabIndex = 24;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            // 
            // lbComentario
            // 
            lbComentario.AutoSize = true;
            lbComentario.Location = new Point(3, 317);
            lbComentario.Name = "lbComentario";
            lbComentario.Size = new Size(70, 15);
            lbComentario.TabIndex = 25;
            lbComentario.Text = "Comentario";
            // 
            // FrmCargarEstadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 527);
            Controls.Add(lbComentario);
            Controls.Add(btnCargar);
            Controls.Add(lbFecha);
            Controls.Add(mcFecha);
            Controls.Add(txtEstadio);
            Controls.Add(txtCompeticion);
            Controls.Add(txtResultado);
            Controls.Add(txtRival);
            Controls.Add(rtcComentario);
            Controls.Add(lbEstadio);
            Controls.Add(lbCompeticion);
            Controls.Add(lbResultado);
            Controls.Add(lbRival);
            Name = "FrmCargarEstadisticas";
            Text = "Cargar Stats";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbRival;
        private Label lbResultado;
        private Label lbCompeticion;
        private Label lbEstadio;
        private Label label5;
        protected RichTextBox rtcComentario;
        protected TextBox txtRival;
        protected TextBox txtResultado;
        protected TextBox txtCompeticion;
        protected TextBox txtEstadio;
        protected MonthCalendar mcFecha;
        private Label lbFecha;
        protected Button btnCargar;
        private Label lbComentario;
    }
}