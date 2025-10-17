namespace WinFormCRUD.Crud2
{
    partial class AltaBajaModificacion
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
            txtObjeto = new TextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtObjeto
            // 
            txtObjeto.Location = new Point(12, 12);
            txtObjeto.MaxLength = 50;
            txtObjeto.Name = "txtObjeto";
            txtObjeto.Size = new Size(395, 23);
            txtObjeto.TabIndex = 0;
            txtObjeto.KeyPress += txtObjeto_KeyPress;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI", 10F);
            btnConfirmar.Location = new Point(144, 42);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(127, 31);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.Location = new Point(287, 42);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 31);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AltaBajaModificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 77);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(txtObjeto);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AltaBajaModificacion";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += AltaBajaModificacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtObjeto;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}