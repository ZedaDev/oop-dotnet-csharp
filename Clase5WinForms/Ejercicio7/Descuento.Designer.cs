namespace Clase5WinForms.Ejercicio7
{
    partial class Descuento
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
            btnCalcular = new Button();
            btnLimpiar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCostoInicial = new TextBox();
            txtDescuento = new TextBox();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(200, 231);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(87, 32);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(35, 231);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(85, 32);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(44, 44);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 3;
            label1.Text = "Costo Inicial  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(65, 98);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 5;
            label2.Text = "Descuento : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(35, 161);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 7;
            label3.Text = "Total A Pagar : ";
            // 
            // txtCostoInicial
            // 
            txtCostoInicial.Location = new Point(187, 41);
            txtCostoInicial.Name = "txtCostoInicial";
            txtCostoInicial.Size = new Size(100, 23);
            txtCostoInicial.TabIndex = 8;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(187, 98);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 9;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(187, 162);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 10;
            // 
            // Descuento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 286);
            Controls.Add(txtTotal);
            Controls.Add(txtDescuento);
            Controls.Add(txtCostoInicial);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Name = "Descuento";
            Text = "Descuento";
            FormClosing += Descuento_FormClosing;
            Load += Descuento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Button btnLimpiar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCostoInicial;
        private TextBox txtDescuento;
        private TextBox txtTotal;
    }
}