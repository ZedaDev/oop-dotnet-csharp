namespace PlayerStats
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
            rtbDescripcion = new RichTextBox();
            lbDescripcion = new Label();
            lbNacion = new Label();
            txtNacionalidad = new TextBox();
            lbUser = new Label();
            lbHoraActual = new Label();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(22, 79);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Escriba Aqui..";
            txtFullName.Size = new Size(163, 23);
            txtFullName.TabIndex = 0;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(213, 79);
            txtEdad.Name = "txtEdad";
            txtEdad.PlaceholderText = "Escriba Aqui..";
            txtEdad.Size = new Size(85, 23);
            txtEdad.TabIndex = 1;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(213, 207);
            txtAltura.Name = "txtAltura";
            txtAltura.PlaceholderText = "EJ: 1.81..";
            txtAltura.Size = new Size(70, 23);
            txtAltura.TabIndex = 2;
            // 
            // txtApodo
            // 
            txtApodo.Location = new Point(22, 142);
            txtApodo.Name = "txtApodo";
            txtApodo.PlaceholderText = "Escriba Aqui..";
            txtApodo.Size = new Size(147, 23);
            txtApodo.TabIndex = 3;
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.BackColor = Color.Transparent;
            lbFullName.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold);
            lbFullName.ForeColor = SystemColors.Menu;
            lbFullName.Location = new Point(12, 59);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(126, 17);
            lbFullName.TabIndex = 7;
            lbFullName.Text = "Nombre Completo ";
            // 
            // lbEdad
            // 
            lbEdad.AutoSize = true;
            lbEdad.BackColor = Color.Transparent;
            lbEdad.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold);
            lbEdad.ForeColor = SystemColors.Menu;
            lbEdad.Location = new Point(213, 59);
            lbEdad.Name = "lbEdad";
            lbEdad.Size = new Size(38, 17);
            lbEdad.TabIndex = 9;
            lbEdad.Text = "Edad";
            // 
            // lbAltura
            // 
            lbAltura.AutoSize = true;
            lbAltura.BackColor = Color.Transparent;
            lbAltura.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold);
            lbAltura.ForeColor = SystemColors.Menu;
            lbAltura.Location = new Point(213, 187);
            lbAltura.Name = "lbAltura";
            lbAltura.Size = new Size(46, 17);
            lbAltura.TabIndex = 11;
            lbAltura.Text = "Altura";
            // 
            // lbApodo
            // 
            lbApodo.AutoSize = true;
            lbApodo.BackColor = Color.Transparent;
            lbApodo.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold);
            lbApodo.ForeColor = SystemColors.Menu;
            lbApodo.Location = new Point(12, 122);
            lbApodo.Name = "lbApodo";
            lbApodo.Size = new Size(49, 17);
            lbApodo.TabIndex = 13;
            lbApodo.Text = "Apodo";
            // 
            // lbPhHabil
            // 
            lbPhHabil.AutoSize = true;
            lbPhHabil.BackColor = Color.Transparent;
            lbPhHabil.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold);
            lbPhHabil.ForeColor = SystemColors.Menu;
            lbPhHabil.Location = new Point(213, 120);
            lbPhHabil.Name = "lbPhHabil";
            lbPhHabil.Size = new Size(83, 17);
            lbPhHabil.TabIndex = 15;
            lbPhHabil.Text = "Pierna Habil";
            // 
            // cmbPhHabil
            // 
            cmbPhHabil.FormattingEnabled = true;
            cmbPhHabil.Location = new Point(213, 140);
            cmbPhHabil.Name = "cmbPhHabil";
            cmbPhHabil.Size = new Size(121, 23);
            cmbPhHabil.TabIndex = 20;
            // 
            // mCalendar
            // 
            mCalendar.Location = new Point(523, 57);
            mCalendar.Name = "mCalendar";
            mCalendar.TabIndex = 21;
            // 
            // lbFechaDebut
            // 
            lbFechaDebut.AutoSize = true;
            lbFechaDebut.BackColor = Color.Transparent;
            lbFechaDebut.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold);
            lbFechaDebut.ForeColor = SystemColors.Menu;
            lbFechaDebut.Location = new Point(501, 14);
            lbFechaDebut.Name = "lbFechaDebut";
            lbFechaDebut.Size = new Size(125, 34);
            lbFechaDebut.TabIndex = 22;
            lbFechaDebut.Text = "Seleccione Fecha \r\nDebut Profesional :\r\n";
            // 
            // btnCargar
            // 
            btnCargar.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargar.Location = new Point(587, 355);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(184, 40);
            btnCargar.TabIndex = 23;
            btnCargar.Text = "Cargar Deportista";
            btnCargar.UseVisualStyleBackColor = true;
            // 
            // rtbDescripcion
            // 
            rtbDescripcion.Location = new Point(3, 262);
            rtbDescripcion.Name = "rtbDescripcion";
            rtbDescripcion.Size = new Size(462, 133);
            rtbDescripcion.TabIndex = 24;
            rtbDescripcion.Text = "Escriba Aqui..";
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.BackColor = Color.Transparent;
            lbDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbDescripcion.ForeColor = SystemColors.Menu;
            lbDescripcion.Location = new Point(3, 244);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(72, 15);
            lbDescripcion.TabIndex = 25;
            lbDescripcion.Text = "Descripcion";
            // 
            // lbNacion
            // 
            lbNacion.AutoSize = true;
            lbNacion.BackColor = Color.Transparent;
            lbNacion.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold);
            lbNacion.ForeColor = SystemColors.Menu;
            lbNacion.Location = new Point(12, 187);
            lbNacion.Name = "lbNacion";
            lbNacion.Size = new Size(116, 17);
            lbNacion.TabIndex = 26;
            lbNacion.Text = "Tierra Natal(Pais)";
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Location = new Point(22, 207);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.PlaceholderText = "Escriba Aqui..";
            txtNacionalidad.Size = new Size(147, 23);
            txtNacionalidad.TabIndex = 27;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.ForeColor = Color.Lime;
            lbUser.Location = new Point(19, 11);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(56, 15);
            lbUser.TabIndex = 28;
            lbUser.Text = "USUARIO";
            // 
            // lbHoraActual
            // 
            lbHoraActual.AutoSize = true;
            lbHoraActual.BackColor = Color.Transparent;
            lbHoraActual.Font = new Font("Segoe UI", 8F, FontStyle.Bold | FontStyle.Italic);
            lbHoraActual.ForeColor = Color.LawnGreen;
            lbHoraActual.Location = new Point(16, 35);
            lbHoraActual.Name = "lbHoraActual";
            lbHoraActual.Size = new Size(56, 13);
            lbHoraActual.TabIndex = 29;
            lbHoraActual.Text = "HORARIO";
            // 
            // FrmCargarDeportista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = Properties.Resources._23949_mast1;
            ClientSize = new Size(783, 400);
            Controls.Add(lbHoraActual);
            Controls.Add(lbUser);
            Controls.Add(txtNacionalidad);
            Controls.Add(lbNacion);
            Controls.Add(lbDescripcion);
            Controls.Add(rtbDescripcion);
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
            ForeColor = Color.Black;
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
        private RichTextBox rtbDescripcion;
        private Label lbDescripcion;
        private Label lbNacion;
        protected TextBox txtNacionalidad;
        private Label lbUser;
        private Label lbHoraActual;
    }
}
