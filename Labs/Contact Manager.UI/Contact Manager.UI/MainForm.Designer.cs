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
        protected override void Dispose( bool disposing )
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
            this.Onfile = new System.Windows.Forms.ToolStripMenuItem();
            this.OnFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Contact = new System.Windows.Forms.ToolStripMenuItem();
            this.OnaddContact = new System.Windows.Forms.ToolStripMenuItem();
            this.Onhelp = new System.Windows.Forms.ToolStripMenuItem();
            this.OnHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._listContacts = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Onfile,
            this.Contact,
            this.Onhelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(240, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Onfile
            // 
            this.Onfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnFileExit});
            this.Onfile.Name = "Onfile";
            this.Onfile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.Onfile.Size = new System.Drawing.Size(37, 20);
            this.Onfile.Text = "File";
            // 
            // OnFileExit
            // 
            this.OnFileExit.Name = "OnFileExit";
            this.OnFileExit.Size = new System.Drawing.Size(92, 22);
            this.OnFileExit.Text = "Exit";
            this.OnFileExit.Click += new System.EventHandler(this.OnFileExit_Click);
            // 
            // Contact
            // 
            this.Contact.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnaddContact});
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(61, 20);
            this.Contact.Text = "Contact";
            // 
            // OnaddContact
            // 
            this.OnaddContact.Name = "OnaddContact";
            this.OnaddContact.Size = new System.Drawing.Size(96, 22);
            this.OnaddContact.Text = "Add";
            this.OnaddContact.Click += new System.EventHandler(this.OnaddContact_Click);
            // 
            // Onhelp
            // 
            this.Onhelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnHelpAbout});
            this.Onhelp.Name = "Onhelp";
            this.Onhelp.Size = new System.Drawing.Size(44, 20);
            this.Onhelp.Text = "Help";
            // 
            // OnHelpAbout
            // 
            this.OnHelpAbout.Name = "OnHelpAbout";
            this.OnHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.OnHelpAbout.Size = new System.Drawing.Size(126, 22);
            this.OnHelpAbout.Text = "About";
            this.OnHelpAbout.Click += new System.EventHandler(this.OnHelpAbout_Click);
            // 
            // _listContacts
            // 
            this._listContacts.FormattingEnabled = true;
            this._listContacts.Location = new System.Drawing.Point(0, 27);
            this._listContacts.Name = "_listContacts";
            this._listContacts.Size = new System.Drawing.Size(120, 95);
            this._listContacts.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 258);
            this.Controls.Add(this._listContacts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Contact Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Onfile;
        private System.Windows.Forms.ToolStripMenuItem OnFileExit;
        private System.Windows.Forms.ToolStripMenuItem Onhelp;
        private System.Windows.Forms.ToolStripMenuItem OnHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem Contact;
        private System.Windows.Forms.ToolStripMenuItem OnaddContact;
        private System.Windows.Forms.ListBox _listContacts;
    }
}

