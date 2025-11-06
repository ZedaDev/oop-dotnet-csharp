namespace Centralita
{
    partial class FrmMenu
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
            btnGenerarLlamada = new Button();
            btnFTotal = new Button();
            btnFLocal = new Button();
            btnFProv = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnGenerarLlamada
            // 
            btnGenerarLlamada.BackColor = SystemColors.ControlLight;
            btnGenerarLlamada.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            btnGenerarLlamada.ForeColor = SystemColors.InfoText;
            btnGenerarLlamada.Location = new Point(3, 12);
            btnGenerarLlamada.Name = "btnGenerarLlamada";
            btnGenerarLlamada.Size = new Size(263, 42);
            btnGenerarLlamada.TabIndex = 0;
            btnGenerarLlamada.Text = "Generar Llamada";
            btnGenerarLlamada.UseVisualStyleBackColor = false;
            btnGenerarLlamada.Click += btnGenerarLlamada_Click;
            // 
            // btnFTotal
            // 
            btnFTotal.BackColor = SystemColors.ControlLight;
            btnFTotal.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            btnFTotal.ForeColor = SystemColors.InfoText;
            btnFTotal.Location = new Point(3, 60);
            btnFTotal.Name = "btnFTotal";
            btnFTotal.Size = new Size(263, 42);
            btnFTotal.TabIndex = 1;
            btnFTotal.Text = "Facturacion Total";
            btnFTotal.UseVisualStyleBackColor = false;
            btnFTotal.Click += btnFTotal_Click;
            // 
            // btnFLocal
            // 
            btnFLocal.BackColor = SystemColors.ControlLight;
            btnFLocal.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            btnFLocal.ForeColor = SystemColors.InfoText;
            btnFLocal.Location = new Point(2, 108);
            btnFLocal.Name = "btnFLocal";
            btnFLocal.Size = new Size(263, 42);
            btnFLocal.TabIndex = 2;
            btnFLocal.Text = "Facturacion Local";
            btnFLocal.UseVisualStyleBackColor = false;
            btnFLocal.Click += btnFTotal_Click;
            // 
            // btnFProv
            // 
            btnFProv.BackColor = SystemColors.ControlLight;
            btnFProv.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            btnFProv.ForeColor = SystemColors.InfoText;
            btnFProv.Location = new Point(3, 156);
            btnFProv.Name = "btnFProv";
            btnFProv.Size = new Size(263, 42);
            btnFProv.TabIndex = 3;
            btnFProv.Text = "Facturacion Provincial";
            btnFProv.UseVisualStyleBackColor = false;
            btnFProv.Click += btnFTotal_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlLight;
            btnSalir.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            btnSalir.ForeColor = SystemColors.InfoText;
            btnSalir.Location = new Point(2, 204);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(263, 42);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 257);
            Controls.Add(btnSalir);
            Controls.Add(btnFProv);
            Controls.Add(btnFLocal);
            Controls.Add(btnFTotal);
            Controls.Add(btnGenerarLlamada);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Central Telefonica";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerarLlamada;
        private Button btnFTotal;
        private Button btnFLocal;
        private Button btnFProv;
        private Button btnSalir;
    }
}
