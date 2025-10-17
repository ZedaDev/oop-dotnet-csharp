namespace WinFormCRUD.Crud2
{
    partial class FrmAltaModificacion
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
            components = new System.ComponentModel.Container();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            lstObjetos = new ListBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAgregar.Location = new Point(290, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(62, 51);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnEliminar.Location = new Point(290, 68);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(62, 51);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "-";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnModificar.Location = new Point(290, 123);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(62, 51);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "M";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // lstObjetos
            // 
            lstObjetos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstObjetos.FormattingEnabled = true;
            lstObjetos.ItemHeight = 15;
            lstObjetos.Location = new Point(12, 4);
            lstObjetos.Name = "lstObjetos";
            lstObjetos.Size = new Size(272, 364);
            lstObjetos.TabIndex = 5;
            // 
            // FrmAltaModificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 386);
            Controls.Add(lstObjetos);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAltaModificacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista Del Supermercado";
            FormClosing += FrmAltaModificacion_FormClosing;
            Load += FrmAltaModificacion_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private ListBox lstObjetos;
        private ToolTip toolTip1;
    }
}