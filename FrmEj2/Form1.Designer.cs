namespace FrmEj2
{
    partial class FrmEjercicio2
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
            lbKms = new Label();
            lbLitros = new Label();
            txtKms = new TextBox();
            txtLiters = new TextBox();
            button1 = new Button();
            rtcMostrar = new RichTextBox();
            SuspendLayout();
            // 
            // lbKms
            // 
            lbKms.AutoSize = true;
            lbKms.Location = new Point(12, 36);
            lbKms.Name = "lbKms";
            lbKms.Size = new Size(64, 15);
            lbKms.TabIndex = 0;
            lbKms.Text = "Kilometros";
            // 
            // lbLitros
            // 
            lbLitros.AutoSize = true;
            lbLitros.Location = new Point(12, 109);
            lbLitros.Name = "lbLitros";
            lbLitros.Size = new Size(36, 15);
            lbLitros.TabIndex = 2;
            lbLitros.Text = "Litros";
            // 
            // txtKms
            // 
            txtKms.Location = new Point(28, 54);
            txtKms.Name = "txtKms";
            txtKms.Size = new Size(116, 23);
            txtKms.TabIndex = 3;
            // 
            // txtLiters
            // 
            txtLiters.Location = new Point(28, 127);
            txtLiters.Name = "txtLiters";
            txtLiters.Size = new Size(116, 23);
            txtLiters.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(12, 193);
            button1.Name = "button1";
            button1.Size = new Size(132, 28);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rtcMostrar
            // 
            rtcMostrar.Location = new Point(201, 12);
            rtcMostrar.Name = "rtcMostrar";
            rtcMostrar.Size = new Size(242, 200);
            rtcMostrar.TabIndex = 7;
            rtcMostrar.Text = "";
            // 
            // FrmEjercicio2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 224);
            Controls.Add(rtcMostrar);
            Controls.Add(button1);
            Controls.Add(txtLiters);
            Controls.Add(txtKms);
            Controls.Add(lbLitros);
            Controls.Add(lbKms);
            Name = "FrmEjercicio2";
            Text = "Km's and Liters";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbKms;
        private Label lbLitros;
        private TextBox txtKms;
        private TextBox txtLiters;
        private Button button1;
        private RichTextBox rtcMostrar;
    }
}
