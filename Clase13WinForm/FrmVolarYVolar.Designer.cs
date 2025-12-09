namespace Clase13WinForm
{
    partial class FrmVolarYVolar
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
            SuspendLayout();
            // 
            // rtbMessage
            // 
            rtbMessage.Location = new Point(227, 3);
            rtbMessage.Name = "rtbMessage";
            rtbMessage.Size = new Size(245, 287);
            rtbMessage.TabIndex = 0;
            rtbMessage.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(43, 251);
            button1.Name = "button1";
            button1.Size = new Size(148, 29);
            button1.TabIndex = 1;
            button1.Text = "Go To Fly!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(30, 24);
            button2.Name = "button2";
            button2.Size = new Size(122, 32);
            button2.TabIndex = 3;
            button2.Text = "Add BuzzLightyear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(30, 79);
            button3.Name = "button3";
            button3.Size = new Size(122, 31);
            button3.TabIndex = 5;
            button3.Text = "Add Pato";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(30, 134);
            button4.Name = "button4";
            button4.Size = new Size(122, 31);
            button4.TabIndex = 7;
            button4.TabStop = false;
            button4.Text = "Add Boing747";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FrmVolarYVolar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 292);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(rtbMessage);
            Name = "FrmVolarYVolar";
            Text = "FrmVolarYVolar";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbMessage;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}