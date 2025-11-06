namespace Centralita
{
    partial class FrmLlamador
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
            txtNroDestino = new TextBox();
            button12 = new Button();
            btnNumeral = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btn1 = new Button();
            btnLlamar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            txtNroOrigen = new TextBox();
            cbmFranja = new ComboBox();
            gbNumbers = new GroupBox();
            gbNumbers.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 83);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // txtNroDestino
            // 
            txtNroDestino.Font = new Font("Segoe UI", 16F);
            txtNroDestino.Location = new Point(12, 12);
            txtNroDestino.Name = "txtNroDestino";
            txtNroDestino.PlaceholderText = "Nro. Destino";
            txtNroDestino.Size = new Size(372, 36);
            txtNroDestino.TabIndex = 1;
            txtNroDestino.Tag = "false";
            txtNroDestino.Enter += txtNroOrigen_Enter;
            txtNroDestino.Leave += txtNroDestino_Leave;
            // 
            // button12
            // 
            button12.Location = new Point(6, 208);
            button12.Name = "button12";
            button12.Size = new Size(55, 51);
            button12.TabIndex = 14;
            button12.Text = "*";
            button12.UseVisualStyleBackColor = true;
            button12.Click += btn1_Click;
            // 
            // btnNumeral
            // 
            btnNumeral.Location = new Point(158, 208);
            btnNumeral.Name = "btnNumeral";
            btnNumeral.Size = new Size(55, 51);
            btnNumeral.TabIndex = 13;
            btnNumeral.Text = "#";
            btnNumeral.UseVisualStyleBackColor = true;
            btnNumeral.Click += btn1_Click;
            // 
            // button10
            // 
            button10.Location = new Point(81, 208);
            button10.Name = "button10";
            button10.Size = new Size(55, 51);
            button10.TabIndex = 12;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += btn1_Click;
            // 
            // button9
            // 
            button9.Location = new Point(158, 144);
            button9.Name = "button9";
            button9.Size = new Size(55, 51);
            button9.TabIndex = 11;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btn1_Click;
            // 
            // button8
            // 
            button8.Location = new Point(81, 146);
            button8.Name = "button8";
            button8.Size = new Size(55, 51);
            button8.TabIndex = 10;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btn1_Click;
            // 
            // button7
            // 
            button7.Location = new Point(6, 146);
            button7.Name = "button7";
            button7.Size = new Size(55, 51);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btn1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(158, 87);
            button6.Name = "button6";
            button6.Size = new Size(55, 51);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btn1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(81, 87);
            button5.Name = "button5";
            button5.Size = new Size(55, 51);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btn1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(6, 87);
            button4.Name = "button4";
            button4.Size = new Size(55, 51);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btn1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(158, 22);
            button3.Name = "button3";
            button3.Size = new Size(55, 51);
            button3.TabIndex = 5;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btn1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(81, 22);
            button2.Name = "button2";
            button2.Size = new Size(55, 51);
            button2.TabIndex = 4;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn1_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(6, 22);
            btn1.Name = "btn1";
            btn1.Size = new Size(55, 51);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnLlamar
            // 
            btnLlamar.Location = new Point(234, 101);
            btnLlamar.Name = "btnLlamar";
            btnLlamar.Size = new Size(185, 34);
            btnLlamar.TabIndex = 4;
            btnLlamar.Text = "Llamar";
            btnLlamar.UseVisualStyleBackColor = true;
            btnLlamar.Click += btnLlamar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(234, 141);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(185, 34);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(237, 268);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(185, 51);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtNroOrigen
            // 
            txtNroOrigen.Font = new Font("Segoe UI", 16F);
            txtNroOrigen.Location = new Point(234, 191);
            txtNroOrigen.Name = "txtNroOrigen";
            txtNroOrigen.PlaceholderText = "Nro. Origen";
            txtNroOrigen.Size = new Size(188, 36);
            txtNroOrigen.TabIndex = 7;
            txtNroOrigen.Tag = "false";
            txtNroOrigen.Enter += txtNroOrigen_Enter;
            txtNroOrigen.Leave += txtNroDestino_Leave;
            // 
            // cbmFranja
            // 
            cbmFranja.FormattingEnabled = true;
            cbmFranja.Items.AddRange(new object[] { "Franja 1", "Franja 2", "Franja 3" });
            cbmFranja.Location = new Point(12, 342);
            cbmFranja.Name = "cbmFranja";
            cbmFranja.Size = new Size(407, 23);
            cbmFranja.TabIndex = 8;
            cbmFranja.SelectedIndexChanged += cbmFranja_SelectedIndexChanged;
            // 
            // gbNumbers
            // 
            gbNumbers.Controls.Add(btnNumeral);
            gbNumbers.Controls.Add(button12);
            gbNumbers.Controls.Add(button10);
            gbNumbers.Controls.Add(btn1);
            gbNumbers.Controls.Add(button2);
            gbNumbers.Controls.Add(button3);
            gbNumbers.Controls.Add(button9);
            gbNumbers.Controls.Add(button4);
            gbNumbers.Controls.Add(button8);
            gbNumbers.Controls.Add(button5);
            gbNumbers.Controls.Add(button7);
            gbNumbers.Controls.Add(button6);
            gbNumbers.Location = new Point(9, 71);
            gbNumbers.Name = "gbNumbers";
            gbNumbers.Size = new Size(219, 265);
            gbNumbers.TabIndex = 9;
            gbNumbers.TabStop = false;
            gbNumbers.Text = "Panel";
            // 
            // FrmLlamador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 392);
            Controls.Add(gbNumbers);
            Controls.Add(cbmFranja);
            Controls.Add(txtNroOrigen);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnLlamar);
            Controls.Add(txtNroDestino);
            Controls.Add(label1);
            Name = "FrmLlamador";
            Text = "FrmLlamador";
            Load += FrmLlamador_Load;
            gbNumbers.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNroDestino;
        private Button button12;
        private Button btnNumeral;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btn1;
        private Button btnLlamar;
        private Button btnLimpiar;
        private Button btnSalir;
        private TextBox txtNroOrigen;
        private ComboBox cbmFranja;
        private GroupBox gbNumbers;
    }
}