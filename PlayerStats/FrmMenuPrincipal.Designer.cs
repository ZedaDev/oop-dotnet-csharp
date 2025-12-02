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
            btnEliminar = new Button();
            btnModificar = new Button();
            lvVisor = new ListView();
            btnCerrarSesion = new Button();
            lbVisorCargado = new Label();
            SuspendLayout();
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbUser.Location = new Point(3, -1);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(104, 19);
            lbUser.TabIndex = 0;
            lbUser.Text = "Usuario Name";
            // 
            // lbDateTime
            // 
            lbDateTime.AutoSize = true;
            lbDateTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbDateTime.Location = new Point(618, -1);
            lbDateTime.Name = "lbDateTime";
            lbDateTime.Size = new Size(47, 19);
            lbDateTime.TabIndex = 1;
            lbDateTime.Text = "Fecha";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            btnAgregar.Location = new Point(280, 313);
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
            cmbDeporte.Location = new Point(12, 326);
            cmbDeporte.Name = "cmbDeporte";
            cmbDeporte.Size = new Size(241, 23);
            cmbDeporte.TabIndex = 7;
            cmbDeporte.SelectedIndexChanged += cmbDeporte_SelectedIndexChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(549, 106);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(166, 36);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(549, 189);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(166, 36);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // lvVisor
            // 
            lvVisor.Location = new Point(3, 52);
            lvVisor.MultiSelect = false;
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
            // lbVisorCargado
            // 
            lbVisorCargado.AutoSize = true;
            lbVisorCargado.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lbVisorCargado.ForeColor = Color.Red;
            lbVisorCargado.Location = new Point(15, 34);
            lbVisorCargado.Name = "lbVisorCargado";
            lbVisorCargado.Size = new Size(39, 13);
            lbVisorCargado.TabIndex = 12;
            lbVisorCargado.Text = "VISOR ";
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(721, 355);
            Controls.Add(lbVisorCargado);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lvVisor);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(cmbDeporte);
            Controls.Add(btnVer);
            Controls.Add(btnAgregar);
            Controls.Add(lbDateTime);
            Controls.Add(lbUser);
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Player Stats";
            Load += frmMenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Label lbUser;
        protected Label lbDateTime;
        protected Button btnAgregar;
        protected Button btnVer;
        protected ComboBox cmbDeporte;
        protected Button btnEliminar;
        protected Button btnModificar;
        protected ListView lvVisor;
        protected Button btnCerrarSesion;
        protected Label lbVisorCargado;
    }
}
