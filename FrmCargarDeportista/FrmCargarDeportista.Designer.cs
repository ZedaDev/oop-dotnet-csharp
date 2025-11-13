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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            lbFullName = new Label();
            lbEdad = new Label();
            lbAltura = new Label();
            lbApodo = new Label();
            lbPhHabil = new Label();
            cmbPhHabil = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            lbFechaDebut = new Label();
            btnCargar = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(117, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(22, 205);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(117, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(224, 79);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(117, 23);
            textBox4.TabIndex = 3;
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
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(420, 63);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 21;
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
            btnCargar.Location = new Point(12, 294);
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
            Controls.Add(monthCalendar1);
            Controls.Add(cmbPhHabil);
            Controls.Add(lbPhHabil);
            Controls.Add(lbApodo);
            Controls.Add(lbAltura);
            Controls.Add(lbEdad);
            Controls.Add(lbFullName);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FrmCargarDeportista";
            Text = "Deportista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lbFullName;
        private Label lbEdad;
        private Label lbAltura;
        private Label lbApodo;
        private Label lbPhHabil;
        private ComboBox cmbPhHabil;
        private MonthCalendar monthCalendar1;
        private Label lbFechaDebut;
        private Button btnCargar;
    }
}
