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
            menuStrip1 = new MenuStrip();
            deserializarToolStripMenuItem = new ToolStripMenuItem();
            ToolTipJson = new ToolStripMenuItem();
            ToolTipXml = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lstVisor
            // 
            lstVisor.FormattingEnabled = true;
            lstVisor.ItemHeight = 15;
            lstVisor.Location = new Point(12, 30);
            lstVisor.Name = "lstVisor";
            lstVisor.Size = new Size(435, 244);
            lstVisor.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            btnEliminar.Location = new Point(344, 282);
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
            btnModificar.Location = new Point(194, 280);
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
            btnAgregar.Location = new Point(25, 280);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(87, 34);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { deserializarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(459, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // deserializarToolStripMenuItem
            // 
            deserializarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolTipJson, ToolTipXml });
            deserializarToolStripMenuItem.Name = "deserializarToolStripMenuItem";
            deserializarToolStripMenuItem.Size = new Size(78, 20);
            deserializarToolStripMenuItem.Text = "Deserializar";
            // 
            // ToolTipJson
            // 
            ToolTipJson.Name = "ToolTipJson";
            ToolTipJson.Size = new Size(180, 22);
            ToolTipJson.Text = "JSON";
            ToolTipJson.Click += ToolTipJson_Click;
            // 
            // ToolTipXml
            // 
            ToolTipXml.Name = "ToolTipXml";
            ToolTipXml.Size = new Size(180, 22);
            ToolTipXml.Text = "XML";
            ToolTipXml.Click += ToolTipJson_Click;
            // 
            // FrmCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 324);
            Controls.Add(menuStrip1);
            Controls.Add(btnAgregar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(lstVisor);
            MainMenuStrip = menuStrip1;
            Name = "FrmCRUD";
            Text = "FrmCRUD";
            FormClosing += FrmCRUD_FormClosing;
            Load += FrmCRUD_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVisor;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem deserializarToolStripMenuItem;
        private ToolStripMenuItem ToolTipJson;
        private ToolStripMenuItem ToolTipXml;
    }
}
