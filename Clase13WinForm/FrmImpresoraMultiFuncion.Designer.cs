namespace Clase13WinForm
{
    partial class FrmImpresoraMultiFuncion
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
            rtbMessage = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // rtbMessage
            // 
            rtbMessage.Location = new Point(276, 5);
            rtbMessage.Name = "rtbMessage";
            rtbMessage.Size = new Size(194, 278);
            rtbMessage.TabIndex = 0;
            rtbMessage.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(12, 21);
            button1.Name = "button1";
            button1.Size = new Size(139, 36);
            button1.TabIndex = 3;
            button1.Text = "Create Printer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 124);
            button2.Name = "button2";
            button2.Size = new Size(122, 23);
            button2.TabIndex = 5;
            button2.Text = "Add Picture\r\n\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 84);
            button3.Name = "button3";
            button3.Size = new Size(122, 24);
            button3.TabIndex = 7;
            button3.Text = "Add Document";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 166);
            button4.Name = "button4";
            button4.Size = new Size(122, 23);
            button4.TabIndex = 9;
            button4.Text = "Add Contrat";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            button5.Location = new Point(48, 248);
            button5.Name = "button5";
            button5.Size = new Size(177, 35);
            button5.TabIndex = 11;
            button5.Text = "Print All";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // ImpresoraMultiFuncion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 285);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(rtbMessage);
            Name = "ImpresoraMultiFuncion";
            Text = "Impresora MultiFuncion";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbMessage;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}