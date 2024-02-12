namespace DLWMS.WindForms.P5___Prijava
{
    partial class frmGlavna
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            studentiToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            krajRadaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(483, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentiToolStripMenuItem, toolStripSeparator1, krajRadaToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // studentiToolStripMenuItem
            // 
            studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            studentiToolStripMenuItem.Size = new Size(180, 22);
            studentiToolStripMenuItem.Text = "Studenti";
            studentiToolStripMenuItem.Click += studentiToolStripMenuItem_Click_1;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // krajRadaToolStripMenuItem
            // 
            krajRadaToolStripMenuItem.Name = "krajRadaToolStripMenuItem";
            krajRadaToolStripMenuItem.Size = new Size(180, 22);
            krajRadaToolStripMenuItem.Text = "Kraj Rada";
            krajRadaToolStripMenuItem.Click += krajRadaToolStripMenuItem_Click;
            // 
            // frmGlavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 279);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmGlavna";
            Text = "frmGlavna";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem studentiToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem krajRadaToolStripMenuItem;
    }
}
