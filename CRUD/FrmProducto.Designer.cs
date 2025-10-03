namespace WinFormCRUD
{
    partial class FrmProducto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCode = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label1.Location = new Point(27, 27);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label2.Location = new Point(27, 96);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label3.Location = new Point(27, 164);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Precio";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(45, 45);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(149, 23);
            txtCode.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(45, 114);
            txtName.Name = "txtName";
            txtName.Size = new Size(149, 23);
            txtName.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(45, 182);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(149, 23);
            txtPrice.TabIndex = 9;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 224);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(145, 224);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(82, 23);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 250);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProducto";
            Text = "FrmProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCode;
        private TextBox txtName;
        private TextBox txtPrice;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}