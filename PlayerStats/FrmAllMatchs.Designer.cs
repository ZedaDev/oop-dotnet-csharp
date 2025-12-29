namespace PlayerStats
{
    partial class FrmAllMatchs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAllMatchs));
            richTextBox1 = new RichTextBox();
            listBox1 = new ListBox();
            toolStrip1 = new ToolStrip();
            menuStripOption = new ToolStripDropDownButton();
            añoToolStripMenuItem = new ToolStripMenuItem();
            clubToolStripMenuItem = new ToolStripMenuItem();
            mVPToolStripMenuItem = new ToolStripMenuItem();
            golesToolStripMenuItem = new ToolStripMenuItem();
            hatTrickToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(574, 34);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(291, 114);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 154);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(869, 304);
            listBox1.TabIndex = 4;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { menuStripOption });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(877, 25);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // menuStripOption
            // 
            menuStripOption.DisplayStyle = ToolStripItemDisplayStyle.Text;
            menuStripOption.DropDownItems.AddRange(new ToolStripItem[] { añoToolStripMenuItem, clubToolStripMenuItem, mVPToolStripMenuItem, golesToolStripMenuItem, hatTrickToolStripMenuItem });
            menuStripOption.Image = (Image)resources.GetObject("menuStripOption.Image");
            menuStripOption.ImageTransparentColor = Color.Magenta;
            menuStripOption.Name = "menuStripOption";
            menuStripOption.Size = new Size(84, 22);
            menuStripOption.Text = "Ordenar Por";
            // 
            // añoToolStripMenuItem
            // 
            añoToolStripMenuItem.Name = "añoToolStripMenuItem";
            añoToolStripMenuItem.Size = new Size(122, 22);
            añoToolStripMenuItem.Text = "Año";
            // 
            // clubToolStripMenuItem
            // 
            clubToolStripMenuItem.Name = "clubToolStripMenuItem";
            clubToolStripMenuItem.Size = new Size(122, 22);
            clubToolStripMenuItem.Text = "Club";
            // 
            // mVPToolStripMenuItem
            // 
            mVPToolStripMenuItem.Name = "mVPToolStripMenuItem";
            mVPToolStripMenuItem.Size = new Size(122, 22);
            mVPToolStripMenuItem.Text = "MVP";
            // 
            // golesToolStripMenuItem
            // 
            golesToolStripMenuItem.Name = "golesToolStripMenuItem";
            golesToolStripMenuItem.Size = new Size(122, 22);
            golesToolStripMenuItem.Text = "Goles";
            // 
            // hatTrickToolStripMenuItem
            // 
            hatTrickToolStripMenuItem.Name = "hatTrickToolStripMenuItem";
            hatTrickToolStripMenuItem.Size = new Size(122, 22);
            hatTrickToolStripMenuItem.Text = "Hat-Trick";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FrmAllMatchs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 466);
            Controls.Add(toolStrip1);
            Controls.Add(listBox1);
            Controls.Add(richTextBox1);
            Name = "FrmAllMatchs";
            Text = "FrmAllMatchs";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private ListBox listBox1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton menuStripOption;
        private ToolStripMenuItem añoToolStripMenuItem;
        private ToolStripMenuItem clubToolStripMenuItem;
        private ToolStripMenuItem mVPToolStripMenuItem;
        private ToolStripMenuItem golesToolStripMenuItem;
        private ToolStripMenuItem hatTrickToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
    }
}