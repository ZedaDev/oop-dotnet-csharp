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
            rtbComentario = new RichTextBox();
            txtRival = new TextBox();
            txtResultado = new TextBox();
            txtEstadio = new TextBox();
            txtCompeticion = new TextBox();
            SuspendLayout();
            // 
            // lbRival
            // 
            lbRival.AutoSize = true;
            lbRival.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbRival.Location = new Point(12, 64);
            lbRival.Name = "lbRival";
            lbRival.Size = new Size(50, 19);
            lbRival.TabIndex = 0;
            lbRival.Text = "Rival :";
            // 
            // lbEstadio
            // 
            lbEstadio.AutoSize = true;
            lbEstadio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbEstadio.Location = new Point(12, 161);
            lbEstadio.Name = "lbEstadio";
            lbEstadio.Size = new Size(65, 19);
            lbEstadio.TabIndex = 1;
            lbEstadio.Text = "Estadio :";
            // 
            // lbCompeticion
            // 
            lbCompeticion.AutoSize = true;
            lbCompeticion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbCompeticion.Location = new Point(12, 211);
            lbCompeticion.Name = "lbCompeticion";
            lbCompeticion.Size = new Size(94, 19);
            lbCompeticion.TabIndex = 3;
            lbCompeticion.Text = "Competicion";
            // 
            // lbresultado
            // 
            lbresultado.AutoSize = true;
            lbresultado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbresultado.Location = new Point(12, 114);
            lbresultado.Name = "lbresultado";
            lbresultado.Size = new Size(83, 19);
            lbresultado.TabIndex = 4;
            lbresultado.Text = "Resultado :";
            // 
            // lbFechaPartido
            // 
            lbFechaPartido.AutoSize = true;
            lbFechaPartido.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbFechaPartido.Location = new Point(12, 9);
            lbFechaPartido.Name = "lbFechaPartido";
            lbFechaPartido.Size = new Size(125, 20);
            lbFechaPartido.TabIndex = 5;
            lbFechaPartido.Text = "FECHA PARTIDO";
            // 
            // lbFechaRegistro
            // 
            lbFechaRegistro.AutoSize = true;
            lbFechaRegistro.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbFechaRegistro.Location = new Point(415, 253);
            lbFechaRegistro.Name = "lbFechaRegistro";
            lbFechaRegistro.Size = new Size(132, 20);
            lbFechaRegistro.TabIndex = 6;
            lbFechaRegistro.Text = "FECHA REGISTRO";
            // 
            // rtbComentario
            // 
            rtbComentario.Location = new Point(3, 271);
            rtbComentario.Name = "rtbComentario";
            rtbComentario.Size = new Size(667, 227);
            rtbComentario.TabIndex = 7;
            rtbComentario.Text = "";
            // 
            // txtRival
            // 
            txtRival.Location = new Point(68, 63);
            txtRival.Name = "txtRival";
            txtRival.Size = new Size(186, 23);
            txtRival.TabIndex = 8;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(101, 113);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(181, 23);
            txtResultado.TabIndex = 9;
            // 
            // txtEstadio
            // 
            txtEstadio.Location = new Point(84, 161);
            txtEstadio.Name = "txtEstadio";
            txtEstadio.Size = new Size(182, 23);
            txtEstadio.TabIndex = 10;
            // 
            // txtCompeticion
            // 
            txtCompeticion.Location = new Point(112, 210);
            txtCompeticion.Name = "txtCompeticion";
            txtCompeticion.Size = new Size(162, 23);
            txtCompeticion.TabIndex = 11;
            // 
            // FrmVerEstadistica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._143842_8167_argentinachilenota;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(897, 503);
            Controls.Add(txtCompeticion);
            Controls.Add(txtEstadio);
            Controls.Add(txtResultado);
            Controls.Add(txtRival);
            Controls.Add(rtbComentario);
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

        protected Label lbRival;
        protected Label lbEstadio;
        protected Label lbCompeticion;
        protected Label lbresultado;
        protected Label lbFechaPartido;
        protected Label lbFechaRegistro;
        protected RichTextBox rtbComentario;
        protected TextBox txtRival;
        protected TextBox txtResultado;
        protected TextBox txtEstadio;
        protected TextBox txtCompeticion;
    }
}