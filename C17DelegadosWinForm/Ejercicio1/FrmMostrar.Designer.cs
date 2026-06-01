namespace C17DelegadosWinForm
{
    partial class FrmMostrar
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
            lbNombre = new Label();
            SuspendLayout();
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Segoe UI", 26F);
            lbNombre.Location = new Point(12, 31);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(148, 47);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre";
            // 
            // FrmMostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 118);
            Controls.Add(lbNombre);
            Name = "FrmMostrar";
            Text = "FrmMostrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNombre;
    }
}