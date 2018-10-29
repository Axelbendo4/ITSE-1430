namespace ContactManager.UI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Onexit = new System.Windows.Forms.ToolStripMenuItem();
            this.Onhelp = new System.Windows.Forms.ToolStripMenuItem();
            this.Onabout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnFile,
            this.Onhelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OnFile
            // 
            this.OnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Onexit});
            this.OnFile.Name = "OnFile";
            this.OnFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.OnFile.Size = new System.Drawing.Size(37, 20);
            this.OnFile.Text = "File";
            // 
            // Onexit
            // 
            this.Onexit.Name = "Onexit";
            this.Onexit.Size = new System.Drawing.Size(152, 22);
            this.Onexit.Text = "Exit";
            this.Onexit.Click += new System.EventHandler(this.Onexit_Click);
            // 
            // Onhelp
            // 
            this.Onhelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Onabout});
            this.Onhelp.Name = "Onhelp";
            this.Onhelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.Onhelp.Size = new System.Drawing.Size(44, 20);
            this.Onhelp.Text = "Help";
            // 
            // Onabout
            // 
            this.Onabout.Name = "Onabout";
            this.Onabout.Size = new System.Drawing.Size(152, 22);
            this.Onabout.Text = "About";
            this.Onabout.Click += new System.EventHandler(this.Onabout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Contact Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OnFile;
        private System.Windows.Forms.ToolStripMenuItem Onexit;
        private System.Windows.Forms.ToolStripMenuItem Onhelp;
        private System.Windows.Forms.ToolStripMenuItem Onabout;
    }
}

