namespace C17DelegadosWinForm
{
    partial class FrmTestDelegados
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
            txtNombre = new TextBox();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(30, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(351, 23);
            txtNombre.TabIndex = 0;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(70, 82);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(278, 36);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FrmTestDelegados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 164);
            Controls.Add(btnActualizar);
            Controls.Add(txtNombre);
            Name = "FrmTestDelegados";
            Text = "FrmTestDelegados";
            Load += FrmTestDelegados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Button btnActualizar;
    }
}