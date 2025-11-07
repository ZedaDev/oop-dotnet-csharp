namespace FrmLogin
{
    partial class FrmLogin
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
            txtNickName = new TextBox();
            txtPw = new TextBox();
            btnRegistrarse = new Button();
            btnIngreso = new Button();
            lbMessage = new Label();
            cbPass = new CheckBox();
            SuspendLayout();
            // 
            // txtNickName
            // 
            txtNickName.Location = new Point(289, 212);
            txtNickName.Name = "txtNickName";
            txtNickName.PlaceholderText = "Nombre Usuario";
            txtNickName.Size = new Size(239, 23);
            txtNickName.TabIndex = 0;
            // 
            // txtPw
            // 
            txtPw.Location = new Point(289, 253);
            txtPw.Name = "txtPw";
            txtPw.PasswordChar = '*';
            txtPw.PlaceholderText = "Password";
            txtPw.Size = new Size(239, 23);
            txtPw.TabIndex = 1;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(289, 310);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(89, 29);
            btnRegistrarse.TabIndex = 2;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            // 
            // btnIngreso
            // 
            btnIngreso.Location = new Point(439, 310);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(89, 29);
            btnIngreso.TabIndex = 3;
            btnIngreso.Text = "Ingresar";
            btnIngreso.UseVisualStyleBackColor = true;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.Location = new Point(289, 279);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(51, 15);
            lbMessage.TabIndex = 4;
            lbMessage.Text = "Mensaje";
            // 
            // cbPass
            // 
            cbPass.AutoSize = true;
            cbPass.Location = new Point(539, 258);
            cbPass.Name = "cbPass";
            cbPass.Size = new Size(77, 19);
            cbPass.TabIndex = 5;
            cbPass.Text = "View Pass";
            cbPass.UseVisualStyleBackColor = true;
            cbPass.CheckedChanged += cbPass_CheckedChanged;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbPass);
            Controls.Add(lbMessage);
            Controls.Add(btnIngreso);
            Controls.Add(btnRegistrarse);
            Controls.Add(txtPw);
            Controls.Add(txtNickName);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNickName;
        private TextBox txtPw;
        private Button btnRegistrarse;
        private Button btnIngreso;
        private Label lMesagge;
        private Label lbMessage;
        private CheckBox cbPass;
    }
}
