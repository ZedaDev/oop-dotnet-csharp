namespace Clase5WinForms
{
    partial class Registro
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericEdad = new NumericUpDown();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            CheckBoxGenero = new GroupBox();
            rbOtro = new RadioButton();
            rBFemale = new RadioButton();
            rBMale = new RadioButton();
            groupBCursos = new GroupBox();
            checkBCMas = new CheckBox();
            checkBJs = new CheckBox();
            checkBCSharp = new CheckBox();
            listBoxPais = new ListBox();
            label4 = new Label();
            btnIngresar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericEdad).BeginInit();
            CheckBoxGenero.SuspendLayout();
            groupBCursos.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericEdad);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(17, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(234, 197);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles Del Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(15, 145);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 6;
            label3.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(15, 73);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 5;
            label2.Text = "Direccion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(15, 17);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // numericEdad
            // 
            numericEdad.Location = new Point(21, 168);
            numericEdad.Name = "numericEdad";
            numericEdad.Size = new Size(120, 23);
            numericEdad.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(21, 96);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion";
            txtDireccion.Size = new Size(186, 23);
            txtDireccion.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(21, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(204, 23);
            txtNombre.TabIndex = 1;
            // 
            // CheckBoxGenero
            // 
            CheckBoxGenero.Controls.Add(rbOtro);
            CheckBoxGenero.Controls.Add(rBFemale);
            CheckBoxGenero.Controls.Add(rBMale);
            CheckBoxGenero.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CheckBoxGenero.Location = new Point(17, 233);
            CheckBoxGenero.Name = "CheckBoxGenero";
            CheckBoxGenero.Size = new Size(262, 46);
            CheckBoxGenero.TabIndex = 1;
            CheckBoxGenero.TabStop = false;
            CheckBoxGenero.Text = "Genero";
            // 
            // rbOtro
            // 
            rbOtro.AutoSize = true;
            rbOtro.Location = new Point(195, 21);
            rbOtro.Name = "rbOtro";
            rbOtro.Size = new Size(51, 19);
            rbOtro.TabIndex = 4;
            rbOtro.TabStop = true;
            rbOtro.Text = "Otro";
            rbOtro.UseVisualStyleBackColor = true;
            // 
            // rBFemale
            // 
            rBFemale.AutoSize = true;
            rBFemale.Location = new Point(99, 22);
            rBFemale.Name = "rBFemale";
            rBFemale.Size = new Size(65, 19);
            rBFemale.TabIndex = 6;
            rBFemale.TabStop = true;
            rBFemale.Text = "Female";
            rBFemale.UseVisualStyleBackColor = true;
            // 
            // rBMale
            // 
            rBMale.AutoSize = true;
            rBMale.Location = new Point(6, 22);
            rBMale.Name = "rBMale";
            rBMale.Size = new Size(52, 19);
            rBMale.TabIndex = 2;
            rBMale.TabStop = true;
            rBMale.Text = "Male";
            rBMale.UseVisualStyleBackColor = true;
            // 
            // groupBCursos
            // 
            groupBCursos.Controls.Add(checkBCMas);
            groupBCursos.Controls.Add(checkBJs);
            groupBCursos.Controls.Add(checkBCSharp);
            groupBCursos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBCursos.Location = new Point(318, 30);
            groupBCursos.Name = "groupBCursos";
            groupBCursos.Size = new Size(116, 102);
            groupBCursos.TabIndex = 2;
            groupBCursos.TabStop = false;
            groupBCursos.Text = "Cursos";
            // 
            // checkBCMas
            // 
            checkBCMas.AutoSize = true;
            checkBCMas.Location = new Point(15, 72);
            checkBCMas.Name = "checkBCMas";
            checkBCMas.Size = new Size(49, 19);
            checkBCMas.TabIndex = 9;
            checkBCMas.Text = "C++";
            checkBCMas.UseVisualStyleBackColor = true;
            // 
            // checkBJs
            // 
            checkBJs.AutoSize = true;
            checkBJs.Location = new Point(15, 47);
            checkBJs.Name = "checkBJs";
            checkBJs.Size = new Size(83, 19);
            checkBJs.TabIndex = 8;
            checkBJs.Text = "JavaScript";
            checkBJs.UseVisualStyleBackColor = true;
            // 
            // checkBCSharp
            // 
            checkBCSharp.AutoSize = true;
            checkBCSharp.Location = new Point(15, 22);
            checkBCSharp.Name = "checkBCSharp";
            checkBCSharp.Size = new Size(40, 19);
            checkBCSharp.TabIndex = 7;
            checkBCSharp.Text = "C#";
            checkBCSharp.UseVisualStyleBackColor = true;
            // 
            // listBoxPais
            // 
            listBoxPais.FormattingEnabled = true;
            listBoxPais.ItemHeight = 15;
            listBoxPais.Items.AddRange(new object[] { "Argentina", "Colombia", "Uruguay" });
            listBoxPais.Location = new Point(318, 163);
            listBoxPais.Name = "listBoxPais";
            listBoxPais.Size = new Size(120, 64);
            listBoxPais.TabIndex = 8;
            listBoxPais.Tag = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(318, 141);
            label4.Name = "label4";
            label4.Size = new Size(36, 19);
            label4.TabIndex = 9;
            label4.Text = "Pais";
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnIngresar.Location = new Point(360, 256);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(102, 23);
            btnIngresar.TabIndex = 10;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 295);
            Controls.Add(btnIngresar);
            Controls.Add(label4);
            Controls.Add(listBoxPais);
            Controls.Add(groupBCursos);
            Controls.Add(CheckBoxGenero);
            Controls.Add(groupBox1);
            Name = "Registro";
            Text = "Registro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericEdad).EndInit();
            CheckBoxGenero.ResumeLayout(false);
            CheckBoxGenero.PerformLayout();
            groupBCursos.ResumeLayout(false);
            groupBCursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numericEdad;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private GroupBox CheckBoxGenero;
        private RadioButton rbOtro;
        private RadioButton rBFemale;
        private RadioButton rBMale;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBCursos;
        private CheckBox checkBCMas;
        private CheckBox checkBJs;
        private CheckBox checkBCSharp;
        private ListBox listBoxPais;
        private Label label4;
        private Button btnIngresar;
    }
}