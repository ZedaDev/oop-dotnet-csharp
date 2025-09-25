
namespace Clase5WinForms
{
    partial class Form1
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
            btn1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Cursor = Cursors.Hand;
            btn1.FlatAppearance.MouseOverBackColor = Color.Azure;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Location = new Point(186, 131);
            btn1.Name = "btn1";
            btn1.Size = new Size(157, 34);
            btn1.TabIndex = 0;
            btn1.Text = "Saludar!";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 32);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nombre";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(29, 81);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Apellido";
            textBox2.Size = new Size(205, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 58);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(283, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(283, 9);
            label3.Name = "label3";
            label3.Size = new Size(130, 19);
            label3.TabIndex = 6;
            label3.Text = "Materia Favorita";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 177);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btn1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "¡Hola, Windows Forms!";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btn1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
    }
}
