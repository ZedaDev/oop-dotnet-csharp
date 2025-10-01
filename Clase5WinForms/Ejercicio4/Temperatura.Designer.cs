namespace Clase5WinForms
{
    partial class Temperatura
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
            lbFarenheit = new Label();
            lbCelcius = new Label();
            lbKelvin = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtFahrenheit = new TextBox();
            txtKelvin = new TextBox();
            txtCelsius = new TextBox();
            lbFaF = new TextBox();
            lbCaF = new TextBox();
            lbKaF = new TextBox();
            lbFaC = new TextBox();
            lbCaC = new TextBox();
            lbKaC = new TextBox();
            lbFaK = new TextBox();
            lbCaK = new TextBox();
            lbKaK = new TextBox();
            SuspendLayout();
            // 
            // lbFarenheit
            // 
            lbFarenheit.AutoSize = true;
            lbFarenheit.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            lbFarenheit.Location = new Point(15, 46);
            lbFarenheit.Name = "lbFarenheit";
            lbFarenheit.Size = new Size(69, 19);
            lbFarenheit.TabIndex = 0;
            lbFarenheit.Text = "Farenheit";
            // 
            // lbCelcius
            // 
            lbCelcius.AutoSize = true;
            lbCelcius.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            lbCelcius.Location = new Point(20, 83);
            lbCelcius.Name = "lbCelcius";
            lbCelcius.Size = new Size(53, 19);
            lbCelcius.TabIndex = 2;
            lbCelcius.Text = "Celsius";
            // 
            // lbKelvin
            // 
            lbKelvin.AutoSize = true;
            lbKelvin.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            lbKelvin.Location = new Point(20, 119);
            lbKelvin.Name = "lbKelvin";
            lbKelvin.Size = new Size(48, 19);
            lbKelvin.TabIndex = 4;
            lbKelvin.Text = "Kelvin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(317, 25);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Farenheit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(440, 25);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 8;
            label5.Text = "Celsius";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(554, 25);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 10;
            label6.Text = "Kelvin";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(204, 39);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 11;
            button1.Text = "->";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(204, 73);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 13;
            button2.Text = "->";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(204, 110);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 15;
            button3.Text = "->";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.Location = new Point(90, 45);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.Size = new Size(108, 23);
            txtFahrenheit.TabIndex = 16;
            txtFahrenheit.Tag = "temp";
            txtFahrenheit.Leave += textBox1_Leave;
            // 
            // txtKelvin
            // 
            txtKelvin.Location = new Point(90, 115);
            txtKelvin.Name = "txtKelvin";
            txtKelvin.Size = new Size(108, 23);
            txtKelvin.TabIndex = 18;
            txtKelvin.Tag = "temp";
            txtKelvin.Leave += textBox1_Leave;
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(90, 79);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(108, 23);
            txtCelsius.TabIndex = 20;
            txtCelsius.Tag = "temp";
            txtCelsius.Leave += textBox1_Leave;
            // 
            // lbFaF
            // 
            lbFaF.Location = new Point(297, 44);
            lbFaF.Name = "lbFaF";
            lbFaF.Size = new Size(100, 23);
            lbFaF.TabIndex = 22;
            lbFaF.Tag = "convert";
            // 
            // lbCaF
            // 
            lbCaF.Location = new Point(297, 79);
            lbCaF.Name = "lbCaF";
            lbCaF.Size = new Size(100, 23);
            lbCaF.TabIndex = 24;
            lbCaF.Tag = "convert";
            // 
            // lbKaF
            // 
            lbKaF.Location = new Point(297, 115);
            lbKaF.Name = "lbKaF";
            lbKaF.Size = new Size(100, 23);
            lbKaF.TabIndex = 26;
            lbKaF.Tag = "convert";
            // 
            // lbFaC
            // 
            lbFaC.Location = new Point(413, 43);
            lbFaC.Name = "lbFaC";
            lbFaC.Size = new Size(100, 23);
            lbFaC.TabIndex = 28;
            lbFaC.Tag = "convert";
            // 
            // lbCaC
            // 
            lbCaC.Location = new Point(413, 79);
            lbCaC.Name = "lbCaC";
            lbCaC.Size = new Size(100, 23);
            lbCaC.TabIndex = 30;
            lbCaC.Tag = "convert";
            // 
            // lbKaC
            // 
            lbKaC.Location = new Point(413, 115);
            lbKaC.Name = "lbKaC";
            lbKaC.Size = new Size(100, 23);
            lbKaC.TabIndex = 32;
            lbKaC.Tag = "convert";
            // 
            // lbFaK
            // 
            lbFaK.Location = new Point(525, 43);
            lbFaK.Name = "lbFaK";
            lbFaK.Size = new Size(100, 23);
            lbFaK.TabIndex = 34;
            lbFaK.Tag = "convert";
            // 
            // lbCaK
            // 
            lbCaK.Location = new Point(525, 78);
            lbCaK.Name = "lbCaK";
            lbCaK.Size = new Size(100, 23);
            lbCaK.TabIndex = 36;
            lbCaK.Tag = "convert";
            // 
            // lbKaK
            // 
            lbKaK.Location = new Point(525, 115);
            lbKaK.Name = "lbKaK";
            lbKaK.Size = new Size(100, 23);
            lbKaK.TabIndex = 38;
            lbKaK.Tag = "convert";
            // 
            // Temperatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 146);
            Controls.Add(lbKaK);
            Controls.Add(lbCaK);
            Controls.Add(lbFaK);
            Controls.Add(lbKaC);
            Controls.Add(lbCaC);
            Controls.Add(lbFaC);
            Controls.Add(lbKaF);
            Controls.Add(lbCaF);
            Controls.Add(lbFaF);
            Controls.Add(txtCelsius);
            Controls.Add(txtKelvin);
            Controls.Add(txtFahrenheit);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbKelvin);
            Controls.Add(lbCelcius);
            Controls.Add(lbFarenheit);
            Name = "Temperatura";
            Text = "Temperatura";
            Load += Temperatura_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbFarenheit;
        private Label lbCelcius;
        private Label lbKelvin;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtFahrenheit;
        private TextBox txtKelvin;
        private TextBox txtCelsius;
        private TextBox lbFaF;
        private TextBox lbCaF;
        private TextBox lbKaF;
        private TextBox lbFaC;
        private TextBox lbCaC;
        private TextBox lbKaC;
        private TextBox lbFaK;
        private TextBox lbCaK;
        private TextBox lbKaK;
    }
}