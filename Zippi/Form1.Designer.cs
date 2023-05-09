namespace Zippi
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
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            pakowanieToolStripMenuItem = new ToolStripMenuItem();
            plikToolStripMenuItem = new ToolStripMenuItem();
            folderToolStripMenuItem = new ToolStripMenuItem();
            rozpakujToolStripMenuItem = new ToolStripMenuItem();
            folderBrowserDialog1 = new FolderBrowserDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(38, 75);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(700, 334);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { pakowanieToolStripMenuItem, rozpakujToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // pakowanieToolStripMenuItem
            // 
            pakowanieToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { plikToolStripMenuItem, folderToolStripMenuItem });
            pakowanieToolStripMenuItem.Name = "pakowanieToolStripMenuItem";
            pakowanieToolStripMenuItem.Size = new Size(54, 20);
            pakowanieToolStripMenuItem.Text = "Spakuj";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(180, 22);
            plikToolStripMenuItem.Text = "Plik";
            plikToolStripMenuItem.Click += plikToolStripMenuItem_Click;
            // 
            // folderToolStripMenuItem
            // 
            folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            folderToolStripMenuItem.Size = new Size(180, 22);
            folderToolStripMenuItem.Text = "Folder";
            folderToolStripMenuItem.Click += folderToolStripMenuItem_Click;
            // 
            // rozpakujToolStripMenuItem
            // 
            rozpakujToolStripMenuItem.Name = "rozpakujToolStripMenuItem";
            rozpakujToolStripMenuItem.Size = new Size(67, 20);
            rozpakujToolStripMenuItem.Text = "Rozpakuj";
            rozpakujToolStripMenuItem.Click += rozpakujToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem pakowanieToolStripMenuItem;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem folderToolStripMenuItem;
        private ToolStripMenuItem rozpakujToolStripMenuItem;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}