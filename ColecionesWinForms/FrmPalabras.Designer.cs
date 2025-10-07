namespace ColecionesWinForms
{
    partial class FrmPalabras
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
            rtb = new RichTextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // rtb
            // 
            rtb.Location = new Point(12, 12);
            rtb.Name = "rtb";
            rtb.Size = new Size(374, 250);
            rtb.TabIndex = 0;
            rtb.Text = "";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(301, 268);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FrmPalabras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 295);
            Controls.Add(btnCalcular);
            Controls.Add(rtb);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPalabras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contador De Palabras";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb;
        private Button btnCalcular;
    }
}
