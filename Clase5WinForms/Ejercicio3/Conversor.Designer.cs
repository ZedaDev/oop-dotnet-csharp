namespace Clase5WinForms.Ejercicio3
{
    partial class Conversor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conversor));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEuro = new TextBox();
            txtDolar = new TextBox();
            btnConvertEuro = new Button();
            btnConvertDolar = new Button();
            btnConvertPeso = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPeso = new TextBox();
            txtPesoAEuro = new TextBox();
            txtDolarAEuro = new TextBox();
            txtEuroAEuro = new TextBox();
            txtEuroADolar = new TextBox();
            txtDolarADolar = new TextBox();
            txtPesoADolar = new TextBox();
            txtDolarAPeso = new TextBox();
            txtPesoAPeso = new TextBox();
            txtEuroAPeso = new TextBox();
            imageList1 = new ImageList(components);
            pBoxCandado = new PictureBox();
            txtCotizEuro = new TextBox();
            txtCotizPeso = new TextBox();
            txtCotizDolar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pBoxCandado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(19, 103);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "EURO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(11, 132);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "DOLAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(22, 161);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "PESO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(88, 56);
            label4.Name = "label4";
            label4.Size = new Size(95, 19);
            label4.TabIndex = 6;
            label4.Text = "COTIZACION";
            // 
            // txtEuro
            // 
            txtEuro.Location = new Point(64, 100);
            txtEuro.Name = "txtEuro";
            txtEuro.Size = new Size(100, 23);
            txtEuro.TabIndex = 7;
            txtEuro.Tag = "cotiz";
            txtEuro.Leave += txtCotizEuro_Leave_1;
            // 
            // txtDolar
            // 
            txtDolar.Location = new Point(64, 132);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(100, 23);
            txtDolar.TabIndex = 8;
            txtDolar.Tag = "cotiz";
            txtDolar.Leave += txtCotizEuro_Leave_1;
            // 
            // btnConvertEuro
            // 
            btnConvertEuro.Font = new Font("Shrikhand", 9F, FontStyle.Italic);
            btnConvertEuro.Location = new Point(180, 100);
            btnConvertEuro.Name = "btnConvertEuro";
            btnConvertEuro.Size = new Size(75, 23);
            btnConvertEuro.TabIndex = 10;
            btnConvertEuro.Text = "->";
            btnConvertEuro.UseVisualStyleBackColor = true;
            btnConvertEuro.Click += btnConvertEuro_Click;
            // 
            // btnConvertDolar
            // 
            btnConvertDolar.Font = new Font("Shrikhand", 9F, FontStyle.Italic);
            btnConvertDolar.Location = new Point(180, 128);
            btnConvertDolar.Name = "btnConvertDolar";
            btnConvertDolar.Size = new Size(75, 23);
            btnConvertDolar.TabIndex = 12;
            btnConvertDolar.Text = "->";
            btnConvertDolar.UseVisualStyleBackColor = true;
            btnConvertDolar.Click += btnConvertDolar_Click;
            // 
            // btnConvertPeso
            // 
            btnConvertPeso.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic);
            btnConvertPeso.Location = new Point(180, 157);
            btnConvertPeso.Name = "btnConvertPeso";
            btnConvertPeso.Size = new Size(75, 23);
            btnConvertPeso.TabIndex = 14;
            btnConvertPeso.Text = "->";
            btnConvertPeso.UseVisualStyleBackColor = true;
            btnConvertPeso.Click += btnConvertPeso_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(303, 85);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 15;
            label5.Text = "EURO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(403, 85);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 16;
            label6.Text = "DOLAR";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(514, 85);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 17;
            label7.Text = "PESO";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(64, 158);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 18;
            txtPeso.Tag = "cotiz";
            txtPeso.Leave += txtCotizEuro_Leave_1;
            // 
            // txtPesoAEuro
            // 
            txtPesoAEuro.Location = new Point(271, 161);
            txtPesoAEuro.Name = "txtPesoAEuro";
            txtPesoAEuro.Size = new Size(100, 23);
            txtPesoAEuro.TabIndex = 19;
            txtPesoAEuro.Tag = "convert";
            // 
            // txtDolarAEuro
            // 
            txtDolarAEuro.Location = new Point(271, 132);
            txtDolarAEuro.Name = "txtDolarAEuro";
            txtDolarAEuro.Size = new Size(100, 23);
            txtDolarAEuro.TabIndex = 20;
            txtDolarAEuro.Tag = "convert";
            // 
            // txtEuroAEuro
            // 
            txtEuroAEuro.Location = new Point(271, 103);
            txtEuroAEuro.Name = "txtEuroAEuro";
            txtEuroAEuro.Size = new Size(100, 23);
            txtEuroAEuro.TabIndex = 21;
            txtEuroAEuro.Tag = "convert";
            // 
            // txtEuroADolar
            // 
            txtEuroADolar.Location = new Point(377, 103);
            txtEuroADolar.Name = "txtEuroADolar";
            txtEuroADolar.Size = new Size(100, 23);
            txtEuroADolar.TabIndex = 22;
            txtEuroADolar.Tag = "convert";
            // 
            // txtDolarADolar
            // 
            txtDolarADolar.Location = new Point(377, 132);
            txtDolarADolar.Name = "txtDolarADolar";
            txtDolarADolar.Size = new Size(100, 23);
            txtDolarADolar.TabIndex = 23;
            txtDolarADolar.Tag = "convert";
            // 
            // txtPesoADolar
            // 
            txtPesoADolar.Location = new Point(377, 161);
            txtPesoADolar.Name = "txtPesoADolar";
            txtPesoADolar.Size = new Size(100, 23);
            txtPesoADolar.TabIndex = 24;
            txtPesoADolar.Tag = "convert";
            // 
            // txtDolarAPeso
            // 
            txtDolarAPeso.Location = new Point(483, 132);
            txtDolarAPeso.Name = "txtDolarAPeso";
            txtDolarAPeso.Size = new Size(100, 23);
            txtDolarAPeso.TabIndex = 25;
            txtDolarAPeso.Tag = "convert";
            // 
            // txtPesoAPeso
            // 
            txtPesoAPeso.Location = new Point(483, 161);
            txtPesoAPeso.Name = "txtPesoAPeso";
            txtPesoAPeso.Size = new Size(100, 23);
            txtPesoAPeso.TabIndex = 26;
            txtPesoAPeso.Tag = "convert";
            // 
            // txtEuroAPeso
            // 
            txtEuroAPeso.Location = new Point(483, 103);
            txtEuroAPeso.Name = "txtEuroAPeso";
            txtEuroAPeso.Size = new Size(100, 23);
            txtEuroAPeso.TabIndex = 27;
            txtEuroAPeso.Tag = "convert";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "candado-cerrado");
            imageList1.Images.SetKeyName(1, "candado-abierto");
            // 
            // pBoxCandado
            // 
            pBoxCandado.Location = new Point(220, 55);
            pBoxCandado.Name = "pBoxCandado";
            pBoxCandado.Size = new Size(35, 25);
            pBoxCandado.TabIndex = 28;
            pBoxCandado.TabStop = false;
            pBoxCandado.Click += pBoxCandado_Click;
            // 
            // txtCotizEuro
            // 
            txtCotizEuro.Location = new Point(271, 56);
            txtCotizEuro.Name = "txtCotizEuro";
            txtCotizEuro.Size = new Size(100, 23);
            txtCotizEuro.TabIndex = 29;
            txtCotizEuro.Tag = "cotiz";
            txtCotizEuro.Leave += txtCotizEuro_Leave_1;
            // 
            // txtCotizPeso
            // 
            txtCotizPeso.Location = new Point(483, 56);
            txtCotizPeso.Name = "txtCotizPeso";
            txtCotizPeso.Size = new Size(100, 23);
            txtCotizPeso.TabIndex = 30;
            txtCotizPeso.Tag = "cotiz";
            txtCotizPeso.Leave += txtCotizEuro_Leave_1;
            // 
            // txtCotizDolar
            // 
            txtCotizDolar.Location = new Point(377, 56);
            txtCotizDolar.Name = "txtCotizDolar";
            txtCotizDolar.Size = new Size(100, 23);
            txtCotizDolar.TabIndex = 31;
            txtCotizDolar.Tag = "cotiz";
            txtCotizDolar.Leave += txtCotizEuro_Leave_1;
            // 
            // Conversor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 190);
            Controls.Add(txtCotizDolar);
            Controls.Add(txtCotizPeso);
            Controls.Add(txtCotizEuro);
            Controls.Add(pBoxCandado);
            Controls.Add(txtEuroAPeso);
            Controls.Add(txtPesoAPeso);
            Controls.Add(txtDolarAPeso);
            Controls.Add(txtPesoADolar);
            Controls.Add(txtDolarADolar);
            Controls.Add(txtEuroADolar);
            Controls.Add(txtEuroAEuro);
            Controls.Add(txtDolarAEuro);
            Controls.Add(txtPesoAEuro);
            Controls.Add(txtPeso);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnConvertPeso);
            Controls.Add(btnConvertDolar);
            Controls.Add(btnConvertEuro);
            Controls.Add(txtDolar);
            Controls.Add(txtEuro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "Conversor";
            Text = "Conversor";
            Load += Conversor_Load;
            ((System.ComponentModel.ISupportInitialize)pBoxCandado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEuro;
        private TextBox txtDolar;
        private Button btnConvertEuro;
        private Button btnConvertDolar;
        private Button btnConvertPeso;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPeso;
        private TextBox txtPesoAEuro;
        private TextBox txtDolarAEuro;
        private TextBox txtEuroAEuro;
        private TextBox txtEuroADolar;
        private TextBox txtDolarADolar;
        private TextBox txtPesoADolar;
        private TextBox txtDolarAPeso;
        private TextBox txtPesoAPeso;
        private TextBox txtEuroAPeso;
        private ImageList imageList1;
        private PictureBox pBoxCandado;
        private TextBox txtCotizEuro;
        private TextBox txtCotizPeso;
        private TextBox txtCotizDolar;
    }
}