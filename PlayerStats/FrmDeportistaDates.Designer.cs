using PlayerStats.Properties;

namespace PlayerStats
{
    partial class FrmDeportistaDates
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
            lbDebut = new Label();
            lbAltura = new Label();
            lbNombre = new Label();
            lbApodo = new Label();
            lbPHabil = new Label();
            rtbComentario = new RichTextBox();
            lbAlturaEs = new Label();
            lbLHabil = new Label();
            lbApodoEs = new Label();
            SuspendLayout();
            // 
            // lbDebut
            // 
            lbDebut.AutoSize = true;
            lbDebut.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lbDebut.Location = new Point(12, 9);
            lbDebut.Name = "lbDebut";
            lbDebut.Size = new Size(51, 19);
            lbDebut.TabIndex = 0;
            lbDebut.Text = "DEBUT";
            // 
            // lbAltura
            // 
            lbAltura.AutoSize = true;
            lbAltura.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbAltura.Location = new Point(61, 103);
            lbAltura.Name = "lbAltura";
            lbAltura.Size = new Size(31, 15);
            lbAltura.TabIndex = 4;
            lbAltura.Text = "1.80";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Segoe UI", 10F);
            lbNombre.Location = new Point(12, 44);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(137, 19);
            lbNombre.TabIndex = 6;
            lbNombre.Text = "Franco Mastantuono";
            // 
            // lbApodo
            // 
            lbApodo.AutoSize = true;
            lbApodo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbApodo.Location = new Point(63, 74);
            lbApodo.Name = "lbApodo";
            lbApodo.Size = new Size(56, 15);
            lbApodo.TabIndex = 8;
            lbApodo.Text = "MASTAN";
            // 
            // lbPHabil
            // 
            lbPHabil.AutoSize = true;
            lbPHabil.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbPHabil.Location = new Point(95, 131);
            lbPHabil.Name = "lbPHabil";
            lbPHabil.Size = new Size(40, 15);
            lbPHabil.TabIndex = 10;
            lbPHabil.Text = "Zurdo";
            // 
            // rtbComentario
            // 
            rtbComentario.Location = new Point(12, 207);
            rtbComentario.Name = "rtbComentario";
            rtbComentario.ReadOnly = true;
            rtbComentario.Size = new Size(640, 219);
            rtbComentario.TabIndex = 11;
            rtbComentario.Text = "";
            // 
            // lbAlturaEs
            // 
            lbAlturaEs.AutoSize = true;
            lbAlturaEs.Location = new Point(12, 103);
            lbAlturaEs.Name = "lbAlturaEs";
            lbAlturaEs.Size = new Size(45, 15);
            lbAlturaEs.TabIndex = 12;
            lbAlturaEs.Text = "Altura :";
            // 
            // lbLHabil
            // 
            lbLHabil.AutoSize = true;
            lbLHabil.Location = new Point(12, 131);
            lbLHabil.Name = "lbLHabil";
            lbLHabil.Size = new Size(77, 15);
            lbLHabil.TabIndex = 13;
            lbLHabil.Text = "Pierna Habil :";
            // 
            // lbApodoEs
            // 
            lbApodoEs.AutoSize = true;
            lbApodoEs.Location = new Point(12, 74);
            lbApodoEs.Name = "lbApodoEs";
            lbApodoEs.Size = new Size(52, 15);
            lbApodoEs.TabIndex = 14;
            lbApodoEs.Text = "Apodo : ";
            // 
            // FrmDeportistaDates
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resources.vecteezy_ai_generated_beautuful_sporting_background_with_copy_space_37236785;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(664, 429);
            Controls.Add(lbApodoEs);
            Controls.Add(lbLHabil);
            Controls.Add(lbAlturaEs);
            Controls.Add(rtbComentario);
            Controls.Add(lbPHabil);
            Controls.Add(lbApodo);
            Controls.Add(lbNombre);
            Controls.Add(lbAltura);
            Controls.Add(lbDebut);
            Name = "FrmDeportistaDates";
            Text = "FrmDeportistaDates";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Label LBdEBUT;
       protected Label lbAltura;
       protected Label lbNombre;
       protected Label lbApodo;
       protected Label lbPHabil;
       protected RichTextBox rtbComentario;
        protected Label lbDebut;
        protected Label lbAlturaEs;
        protected Label lbLHabil;
        protected Label lbApodoEs;
    }
}