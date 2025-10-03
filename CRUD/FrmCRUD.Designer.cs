namespace CRUD
{
    partial class FrmCRUD
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
            lstVisor = new ListBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // lstVisor
            // 
            lstVisor.FormattingEnabled = true;
            lstVisor.ItemHeight = 15;
            lstVisor.Location = new Point(12, 12);
            lstVisor.Name = "lstVisor";
            lstVisor.Size = new Size(435, 244);
            lstVisor.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            btnEliminar.Location = new Point(347, 264);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(85, 32);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            btnModificar.Location = new Point(200, 264);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(85, 32);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            btnAgregar.Location = new Point(27, 262);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(87, 34);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 306);
            Controls.Add(btnAgregar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(lstVisor);
            Name = "FrmCRUD";
            Text = "FrmCRUD";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstVisor;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
    }
}
