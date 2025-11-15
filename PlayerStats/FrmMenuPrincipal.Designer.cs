namespace PlayerStats
{
    partial class frmMenuPrincipal
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
            lbUser = new Label();
            lbDateTime = new Label();
            btnAgregar = new Button();
            btnVer = new Button();
            cmbDeporte = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            lvVisor = new ListView();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbUser.Location = new Point(12, 19);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(104, 19);
            lbUser.TabIndex = 0;
            lbUser.Text = "Usuario Name";
            // 
            // lbDateTime
            // 
            lbDateTime.AutoSize = true;
            lbDateTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbDateTime.Location = new Point(452, 19);
            lbDateTime.Name = "lbDateTime";
            lbDateTime.Size = new Size(47, 19);
            lbDateTime.TabIndex = 1;
            lbDateTime.Text = "Fecha";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            btnAgregar.Location = new Point(268, 295);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(163, 36);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar Deportista";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(549, 52);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(166, 36);
            btnVer.TabIndex = 3;
            btnVer.Text = "Estadisticas";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // cmbDeporte
            // 
            cmbDeporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeporte.FormattingEnabled = true;
            cmbDeporte.Location = new Point(12, 304);
            cmbDeporte.Name = "cmbDeporte";
            cmbDeporte.Size = new Size(241, 23);
            cmbDeporte.TabIndex = 7;
            cmbDeporte.SelectedIndexChanged += cmbDeporte_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(549, 106);
            button1.Name = "button1";
            button1.Size = new Size(166, 36);
            button1.TabIndex = 8;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(549, 189);
            button2.Name = "button2";
            button2.Size = new Size(166, 36);
            button2.TabIndex = 9;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            // 
            // lvVisor
            // 
            lvVisor.Location = new Point(3, 53);
            lvVisor.Name = "lvVisor";
            lvVisor.Size = new Size(530, 236);
            lvVisor.TabIndex = 10;
            lvVisor.UseCompatibleStateImageBehavior = false;
            lvVisor.View = View.List;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(579, 300);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(127, 27);
            btnCerrarSesion.TabIndex = 11;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(718, 332);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lvVisor);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbDeporte);
            Controls.Add(btnVer);
            Controls.Add(btnAgregar);
            Controls.Add(lbDateTime);
            Controls.Add(lbUser);
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Player Stats";
            FormClosing += frmMenuPrincipal_FormClosing;
            Load += frmMenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUser;
        private Label lbDateTime;
        private Button btnAgregar;
        private Button btnVer;
        private ComboBox cmbDeporte;
        private Button button1;
        private Button button2;
        private ListView lvVisor;
        private Button btnCerrarSesion;
    }
}
