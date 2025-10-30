namespace Marvel_Avengers
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMostrarPersonajes = new Button();
            rtbPersonajes = new RichTextBox();
            SuspendLayout();
            // 
            // btnMostrarPersonajes
            // 
            btnMostrarPersonajes.BackColor = SystemColors.ButtonHighlight;
            btnMostrarPersonajes.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            btnMostrarPersonajes.Location = new Point(198, 12);
            btnMostrarPersonajes.Name = "btnMostrarPersonajes";
            btnMostrarPersonajes.Size = new Size(169, 42);
            btnMostrarPersonajes.TabIndex = 0;
            btnMostrarPersonajes.Text = "Mostrar Personajes";
            btnMostrarPersonajes.UseVisualStyleBackColor = false;
            btnMostrarPersonajes.Click += btnMostrarPersonajes_Click;
            // 
            // rtbPersonajes
            // 
            rtbPersonajes.Location = new Point(6, 60);
            rtbPersonajes.Name = "rtbPersonajes";
            rtbPersonajes.Size = new Size(558, 299);
            rtbPersonajes.TabIndex = 1;
            rtbPersonajes.Text = "";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(568, 371);
            Controls.Add(rtbPersonajes);
            Controls.Add(btnMostrarPersonajes);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Marvel";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMostrarPersonajes;
        private RichTextBox rtbPersonajes;
    }
}
