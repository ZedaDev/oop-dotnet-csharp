namespace Clase5WinForms
{
    partial class ConversorB
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNumBinario = new TextBox();
            txtNumDecimal = new TextBox();
            txtBaD = new TextBox();
            txtDaB = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.Location = new Point(235, 16);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 0;
            button1.Text = "->";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.Location = new Point(234, 61);
            button2.Name = "button2";
            button2.Size = new Size(75, 28);
            button2.TabIndex = 2;
            button2.Text = "->";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 3;
            label1.Text = "Binario A Decimal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 5;
            label2.Text = "Decimal A Binario";
            // 
            // txtNumBinario
            // 
            txtNumBinario.Location = new Point(129, 22);
            txtNumBinario.Name = "txtNumBinario";
            txtNumBinario.Size = new Size(100, 23);
            txtNumBinario.TabIndex = 6;
            txtNumBinario.Tag = "number";
            txtNumBinario.Leave += textBox1_Leave;
            // 
            // txtNumDecimal
            // 
            txtNumDecimal.Location = new Point(128, 66);
            txtNumDecimal.Name = "txtNumDecimal";
            txtNumDecimal.Size = new Size(100, 23);
            txtNumDecimal.TabIndex = 8;
            txtNumDecimal.Tag = "number";
            txtNumDecimal.Leave += textBox1_Leave;
            // 
            // txtBaD
            // 
            txtBaD.Location = new Point(316, 22);
            txtBaD.Name = "txtBaD";
            txtBaD.Size = new Size(100, 23);
            txtBaD.TabIndex = 10;
            txtBaD.Tag = "convert";
            // 
            // txtDaB
            // 
            txtDaB.Location = new Point(315, 66);
            txtDaB.Name = "txtDaB";
            txtDaB.Size = new Size(100, 23);
            txtDaB.TabIndex = 12;
            txtDaB.Tag = "convert";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 10);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 13;
            // 
            // ConversorB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 99);
            Controls.Add(label3);
            Controls.Add(txtDaB);
            Controls.Add(txtBaD);
            Controls.Add(txtNumDecimal);
            Controls.Add(txtNumBinario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ConversorB";
            Text = "Conversor";
            Load += ConversorB_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox txtNumBinario;
        private TextBox txtNumDecimal;
        private TextBox txtBaD;
        private TextBox txtDaB;
        private Label label3;
    }
}