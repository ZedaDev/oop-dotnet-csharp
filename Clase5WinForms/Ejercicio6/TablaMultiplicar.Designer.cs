namespace Clase5WinForms.Ejercicio6
{
    partial class TablaMultiplicar
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
            txtNumero = new TextBox();
            lstTabla = new ListBox();
            label1 = new Label();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(79, 56);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 0;
            txtNumero.Enter += txtNumero_Enter;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // lstTabla
            // 
            lstTabla.FormattingEnabled = true;
            lstTabla.ItemHeight = 15;
            lstTabla.Location = new Point(58, 94);
            lstTabla.Name = "lstTabla";
            lstTabla.Size = new Size(145, 184);
            lstTabla.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(57, 19);
            label1.Name = "label1";
            label1.Size = new Size(146, 19);
            label1.TabIndex = 2;
            label1.Text = "Ingrese Un Numero : ";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(88, 284);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(91, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Clear";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // TablaMultiplicar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 314);
            Controls.Add(btnLimpiar);
            Controls.Add(label1);
            Controls.Add(lstTabla);
            Controls.Add(txtNumero);
            MaximizeBox = false;
            Name = "TablaMultiplicar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tabla Multiplicar";
            FormClosing += TablaMultiplicar_FormClosing;
            Load += TablaMultiplicar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private ListBox lstTabla;
        private Label label1;
        private Button btnLimpiar;
    }
}