namespace FrmCargarFutbolista
{
    partial class CargarFutbolista : FrmCargarDeportista.FrmCargarDeportista
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
            lbFechaNow = new Label();
            lbUserName = new Label();
            SuspendLayout();
            // 
            // btnCargar
            // 
            btnCargar.Click += btnCargar_Click;
            // 
            // lbPosicion
            // 
            lbPosicion.AutoSize = true;
            lbPosicion.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold);
            lbPosicion.Location = new Point(195, 187);
            lbPosicion.Name = "lbPosicion";
            lbPosicion.Size = new Size(61, 17);
            lbPosicion.TabIndex = 24;
            lbPosicion.Text = "Posicion";
            // 
            // txtPosicion
            // 
            txtPosicion.Location = new Point(213, 205);
            txtPosicion.Name = "txtPosicion";
            txtPosicion.PlaceholderText = "Escriba Aqui..";
            txtPosicion.Size = new Size(152, 23);
            txtPosicion.TabIndex = 25;
            // 
            // txtClubActual
            // 
            txtClubActual.Location = new Point(12, 261);
            txtClubActual.Name = "txtClubActual";
            txtClubActual.PlaceholderText = "Escriba Aqui..";
            txtClubActual.Size = new Size(186, 23);
            txtClubActual.TabIndex = 26;
            // 
            // lbClubActual
            // 
            lbClubActual.AutoSize = true;
            lbClubActual.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold);
            lbClubActual.Location = new Point(2, 243);
            lbClubActual.Name = "lbClubActual";
            lbClubActual.Size = new Size(80, 17);
            lbClubActual.TabIndex = 27;
            lbClubActual.Text = "Club Actual";
            // 
            // lbFechaNow
            // 
            lbFechaNow.AutoSize = true;
            lbFechaNow.Location = new Point(12, 9);
            lbFechaNow.Name = "lbFechaNow";
            lbFechaNow.Size = new Size(38, 15);
            lbFechaNow.TabIndex = 29;
            lbFechaNow.Text = "label2";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(12, 333);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(38, 15);
            lbUserName.TabIndex = 28;
            lbUserName.Text = "label1";
            // 
            // CargarFutbolista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 357);
            Controls.Add(lbFechaNow);
            Controls.Add(lbUserName);
            Controls.Add(lbClubActual);
            Controls.Add(txtClubActual);
            Controls.Add(txtPosicion);
            Controls.Add(lbPosicion);
            Name = "CargarFutbolista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Futbolista";
            Controls.SetChildIndex(txtFullName, 0);
            Controls.SetChildIndex(txtEdad, 0);
            Controls.SetChildIndex(txtAltura, 0);
            Controls.SetChildIndex(txtApodo, 0);
            Controls.SetChildIndex(cmbPhHabil, 0);
            Controls.SetChildIndex(mCalendar, 0);
            Controls.SetChildIndex(lbPosicion, 0);
            Controls.SetChildIndex(txtPosicion, 0);
            Controls.SetChildIndex(txtClubActual, 0);
            Controls.SetChildIndex(lbClubActual, 0);
            Controls.SetChildIndex(lbUserName, 0);
            Controls.SetChildIndex(lbFechaNow, 0);
            Controls.SetChildIndex(btnCargar, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPosicion;
        private TextBox txtPosicion;
        private TextBox txtClubActual;
        private Label lbClubActual;
        private Label lbFechaNow;
        private Label lbUserName;
    }
}
