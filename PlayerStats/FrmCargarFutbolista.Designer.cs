namespace PlayerStats
{
    partial class FrmCargarFutbolista : FrmCargarDeportista
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
            lbPosicion = new Label();
            txtPosicion = new TextBox();
            txtClubActual = new TextBox();
            lbClubActual = new Label();
            SuspendLayout();
            // 
            // txtAltura
            // 
            txtAltura.Size = new Size(83, 23);
            // 
            // mCalendar
            // 
            mCalendar.Location = new Point(526, 57);
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(590, 355);
            btnCargar.Click += btnCargar_Click;
            // 
            // lbPosicion
            // 
            lbPosicion.AutoSize = true;
            lbPosicion.BackColor = Color.Transparent;
            lbPosicion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lbPosicion.ForeColor = Color.White;
            lbPosicion.Location = new Point(478, 228);
            lbPosicion.Name = "lbPosicion";
            lbPosicion.Size = new Size(67, 16);
            lbPosicion.TabIndex = 24;
            lbPosicion.Text = "Posicion";
            // 
            // txtPosicion
            // 
            txtPosicion.Location = new Point(490, 248);
            txtPosicion.Name = "txtPosicion";
            txtPosicion.PlaceholderText = "Ej: Enganche..";
            txtPosicion.Size = new Size(152, 23);
            txtPosicion.TabIndex = 25;
            // 
            // txtClubActual
            // 
            txtClubActual.Location = new Point(490, 308);
            txtClubActual.Name = "txtClubActual";
            txtClubActual.PlaceholderText = "Ej: River Plate..";
            txtClubActual.Size = new Size(186, 23);
            txtClubActual.TabIndex = 26;
            // 
            // lbClubActual
            // 
            lbClubActual.AutoSize = true;
            lbClubActual.BackColor = Color.Transparent;
            lbClubActual.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lbClubActual.ForeColor = Color.White;
            lbClubActual.Location = new Point(478, 288);
            lbClubActual.Name = "lbClubActual";
            lbClubActual.Size = new Size(85, 16);
            lbClubActual.TabIndex = 27;
            lbClubActual.Text = "Club Actual";
            // 
            // FrmCargarFutbolista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 399);
            Controls.Add(lbClubActual);
            Controls.Add(txtClubActual);
            Controls.Add(txtPosicion);
            Controls.Add(lbPosicion);
            Name = "FrmCargarFutbolista";
            Text = "Futbolista";
            Controls.SetChildIndex(txtFullName, 0);
            Controls.SetChildIndex(txtEdad, 0);
            Controls.SetChildIndex(txtAltura, 0);
            Controls.SetChildIndex(txtApodo, 0);
            Controls.SetChildIndex(cmbPhHabil, 0);
            Controls.SetChildIndex(mCalendar, 0);
            Controls.SetChildIndex(txtNacionalidad, 0);
            Controls.SetChildIndex(lbPosicion, 0);
            Controls.SetChildIndex(txtPosicion, 0);
            Controls.SetChildIndex(txtClubActual, 0);
            Controls.SetChildIndex(lbClubActual, 0);
            Controls.SetChildIndex(btnCargar, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPosicion;
        private TextBox txtPosicion;
        private TextBox txtClubActual;
        private Label lbClubActual;
    }
}
