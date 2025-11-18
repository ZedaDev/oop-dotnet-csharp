namespace FrmCargarDeportista
{
    partial class FrmCargarDeportista
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
        protected void InitializeComponent()
        {
            txtFullName = new TextBox();
            txtEdad = new TextBox();
            txtAltura = new TextBox();
            txtApodo = new TextBox();
            lbFullName = new Label();
            lbEdad = new Label();
            lbAltura = new Label();
            lbApodo = new Label();
            lbPhHabil = new Label();
            cmbPhHabil = new ComboBox();
            mCalendar = new MonthCalendar();
            lbFechaDebut = new Label();
            btnCargar = new Button();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(22, 79);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(117, 23);
            txtFullName.TabIndex = 0;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(22, 140);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(117, 23);
            txtEdad.TabIndex = 1;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(22, 205);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(117, 23);
            txtAltura.TabIndex = 2;
            // 
            // txtApodo
            // 
            txtApodo.Location = new Point(224, 79);
            txtApodo.Name = "txtApodo";
            txtApodo.Size = new Size(117, 23);
            txtApodo.TabIndex = 3;
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold);
            lbFullName.Location = new Point(12, 52);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(126, 17);
            lbFullName.TabIndex = 7;
            lbFullName.Text = "Nombre Completo ";
            // 
            // lbEdad
            // 
            lbEdad.AutoSize = true;
            lbEdad.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold);
            lbEdad.Location = new Point(12, 122);
            lbEdad.Name = "lbEdad";
            lbEdad.Size = new Size(38, 17);
            lbEdad.TabIndex = 9;
            lbEdad.Text = "Edad";
            // 
            // lbAltura
            // 
            lbAltura.AutoSize = true;
            lbAltura.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold);
            lbAltura.Location = new Point(12, 187);
            lbAltura.Name = "lbAltura";
            lbAltura.Size = new Size(46, 17);
            lbAltura.TabIndex = 11;
            lbAltura.Text = "Altura";
            // 
            // lbApodo
            // 
            lbApodo.AutoSize = true;
            lbApodo.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold);
            lbApodo.Location = new Point(213, 52);
            lbApodo.Name = "lbApodo";
            lbApodo.Size = new Size(49, 17);
            lbApodo.TabIndex = 13;
            lbApodo.Text = "Apodo";
            // 
            // lbPhHabil
            // 
            lbPhHabil.AutoSize = true;
            lbPhHabil.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold);
            lbPhHabil.Location = new Point(195, 120);
            lbPhHabil.Name = "lbPhHabil";
            lbPhHabil.Size = new Size(83, 17);
            lbPhHabil.TabIndex = 15;
            lbPhHabil.Text = "Pierna Habil";
            // 
            // cmbPhHabil
            // 
            cmbPhHabil.FormattingEnabled = true;
            cmbPhHabil.Location = new Point(224, 140);
            cmbPhHabil.Name = "cmbPhHabil";
            cmbPhHabil.Size = new Size(121, 23);
            cmbPhHabil.TabIndex = 20;
            // 
            // mCalendar
            // 
            mCalendar.Location = new Point(420, 63);
            mCalendar.Name = "mCalendar";
            mCalendar.TabIndex = 21;
            // 
            // lbFechaDebut
            // 
            lbFechaDebut.AutoSize = true;
            lbFechaDebut.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold);
            lbFechaDebut.Location = new Point(404, 20);
            lbFechaDebut.Name = "lbFechaDebut";
            lbFechaDebut.Size = new Size(125, 34);
            lbFechaDebut.TabIndex = 22;
            lbFechaDebut.Text = "Seleccione Fecha \r\nDebut Profesional :\r\n";
            // 
            // btnCargar
            // 
            btnCargar.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargar.Location = new Point(490, 298);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(184, 40);
            btnCargar.TabIndex = 23;
            btnCargar.Text = "Cargar Deportista";
            btnCargar.UseVisualStyleBackColor = true;
            // 
            // FrmCargarDeportista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 350);
            Controls.Add(btnCargar);
            Controls.Add(lbFechaDebut);
            Controls.Add(mCalendar);
            Controls.Add(cmbPhHabil);
            Controls.Add(lbPhHabil);
            Controls.Add(lbApodo);
            Controls.Add(lbAltura);
            Controls.Add(lbEdad);
            Controls.Add(lbFullName);
            Controls.Add(txtApodo);
            Controls.Add(txtAltura);
            Controls.Add(txtEdad);
            Controls.Add(txtFullName);
            Name = "FrmCargarDeportista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deportista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected TextBox txtFullName;
        protected TextBox txtEdad;
        protected TextBox txtAltura;
        protected TextBox txtApodo;
        private Label lbFullName;
        private Label lbEdad;
        private Label lbAltura;
        private Label lbApodo;
        private Label lbPhHabil;
        protected ComboBox cmbPhHabil;
        protected MonthCalendar mCalendar;
        private Label lbFechaDebut;
        protected Button btnCargar;
    }
}
