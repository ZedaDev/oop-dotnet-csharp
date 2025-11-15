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
            Service.Deportistas deportistas1 = new Service.Deportistas();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerEstadisticas));
            cmbOrdenStats = new ComboBox();
            lbOrdenar = new Label();
            SuspendLayout();
            // 
            // cmbOrdenStats
            // 
            cmbOrdenStats.BackColor = SystemColors.Desktop;
            cmbOrdenStats.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbOrdenStats.ForeColor = Color.LawnGreen;
            cmbOrdenStats.FormattingEnabled = true;
            cmbOrdenStats.Location = new Point(549, 254);
            cmbOrdenStats.Name = "cmbOrdenStats";
            cmbOrdenStats.Size = new Size(156, 27);
            cmbOrdenStats.TabIndex = 12;
            // 
            // lbOrdenar
            // 
            lbOrdenar.AutoSize = true;
            lbOrdenar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbOrdenar.Location = new Point(544, 234);
            lbOrdenar.Name = "lbOrdenar";
            lbOrdenar.Size = new Size(71, 15);
            lbOrdenar.TabIndex = 13;
            lbOrdenar.Text = "Stats Order";
            // 
            // FrmVerEstadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 335);
            Controls.Add(lbOrdenar);
            Controls.Add(cmbOrdenStats);
            D = deportistas1;
            Name = "FrmVerEstadisticas";
            Text = "FrmVerEstadisticas";
            Load += FrmVerEstadisticas_Load;
            Controls.SetChildIndex(cmbOrdenStats, 0);
            Controls.SetChildIndex(lbOrdenar, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOrdenStats;
        private Label lbOrdenar;
    }
}