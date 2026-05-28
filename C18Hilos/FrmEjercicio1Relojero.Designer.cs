namespace C18Hilos
{
    partial class FrmEjercicio1Relojero
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
            lbHora = new Label();
            btnIniciar = new Button();
            btnParar = new Button();
            SuspendLayout();
            // 
            // lbHora
            // 
            lbHora.AutoSize = true;
            lbHora.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            lbHora.Location = new Point(171, 71);
            lbHora.Name = "lbHora";
            lbHora.Size = new Size(64, 20);
            lbHora.TabIndex = 0;
            lbHora.Text = "Horario";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(50, 159);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(161, 40);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnParar
            // 
            btnParar.Location = new Point(235, 159);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(165, 40);
            btnParar.TabIndex = 2;
            btnParar.Text = "Parar";
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Click += btnParar_Click;
            // 
            // FrmEjercicio1Relojero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 264);
            Controls.Add(btnParar);
            Controls.Add(btnIniciar);
            Controls.Add(lbHora);
            Name = "FrmEjercicio1Relojero";
            Text = "FrmEjercicio1Relojero";
            FormClosing += FrmEjercicio1Relojero_FormClosing;
            Load += FrmEjercicio1Relojero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHora;
        private Button btnIniciar;
        private Button btnParar;
    }
}