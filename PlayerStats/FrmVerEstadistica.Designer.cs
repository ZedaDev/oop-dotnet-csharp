namespace PlayerStats
{
    partial class FrmVerEstadistica
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
            lbEstadio = new Label();
            lbCompeticion = new Label();
            lbresultado = new Label();
            lbFechaPartido = new Label();
            lbFechaRegistro = new Label();
            lboxComentario = new ListBox();
            SuspendLayout();
            // 
            // lbRival
            // 
            lbRival.AutoSize = true;
            lbRival.Location = new Point(12, 64);
            lbRival.Name = "lbRival";
            lbRival.Size = new Size(37, 15);
            lbRival.TabIndex = 0;
            lbRival.Text = "RIVAL";
            // 
            // lbEstadio
            // 
            lbEstadio.AutoSize = true;
            lbEstadio.Location = new Point(12, 161);
            lbEstadio.Name = "lbEstadio";
            lbEstadio.Size = new Size(52, 15);
            lbEstadio.TabIndex = 1;
            lbEstadio.Text = "ESTADIO";
            // 
            // lbCompeticion
            // 
            lbCompeticion.AutoSize = true;
            lbCompeticion.Location = new Point(12, 211);
            lbCompeticion.Name = "lbCompeticion";
            lbCompeticion.Size = new Size(86, 15);
            lbCompeticion.TabIndex = 3;
            lbCompeticion.Text = "COMPETICION";
            // 
            // lbresultado
            // 
            lbresultado.AutoSize = true;
            lbresultado.Location = new Point(12, 114);
            lbresultado.Name = "lbresultado";
            lbresultado.Size = new Size(69, 15);
            lbresultado.TabIndex = 4;
            lbresultado.Text = "RESULTADO";
            // 
            // lbFechaPartido
            // 
            lbFechaPartido.AutoSize = true;
            lbFechaPartido.Location = new Point(12, 9);
            lbFechaPartido.Name = "lbFechaPartido";
            lbFechaPartido.Size = new Size(93, 15);
            lbFechaPartido.TabIndex = 5;
            lbFechaPartido.Text = "FECHA PARTIDO";
            // 
            // lbFechaRegistro
            // 
            lbFechaRegistro.AutoSize = true;
            lbFechaRegistro.Location = new Point(520, 253);
            lbFechaRegistro.Name = "lbFechaRegistro";
            lbFechaRegistro.Size = new Size(99, 15);
            lbFechaRegistro.TabIndex = 6;
            lbFechaRegistro.Text = "FECHA REGISTRO";
            // 
            // lboxComentario
            // 
            lboxComentario.FormattingEnabled = true;
            lboxComentario.ItemHeight = 15;
            lboxComentario.Location = new Point(2, 271);
            lboxComentario.Name = "lboxComentario";
            lboxComentario.Size = new Size(656, 229);
            lboxComentario.TabIndex = 7;
            // 
            // FrmVerEstadistica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 503);
            Controls.Add(lboxComentario);
            Controls.Add(lbFechaRegistro);
            Controls.Add(lbFechaPartido);
            Controls.Add(lbresultado);
            Controls.Add(lbCompeticion);
            Controls.Add(lbEstadio);
            Controls.Add(lbRival);
            Name = "FrmVerEstadistica";
            Text = "FrmVerEstadistica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbRival;
        private Label lbEstadio;
        private Label lbCompeticion;
        private Label lbresultado;
        private Label lbFechaPartido;
        private Label lbFechaRegistro;
        private ListBox lboxComentario;
    }
}