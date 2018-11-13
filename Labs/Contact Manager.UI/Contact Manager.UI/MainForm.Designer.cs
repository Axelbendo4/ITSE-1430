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
            this.contact = new System.Windows.Forms.ToolStripMenuItem();
            this.OnAddContact = new System.Windows.Forms.ToolStripMenuItem();
            this._SendMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.OnEditContact = new System.Windows.Forms.ToolStripMenuItem();
            this.OnDeleteContact = new System.Windows.Forms.ToolStripMenuItem();
            this.Onhelp = new System.Windows.Forms.ToolStripMenuItem();
            this.OnHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._listContacts = new System.Windows.Forms.ListBox();
            this._listMessages = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Contacts = new System.Windows.Forms.Label();
            this.SendMessage = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Onfile,
            this.contact,
            this.Onhelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
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
            this.OnFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.OnFileExit.Size = new System.Drawing.Size(134, 22);
            this.OnFileExit.Text = "Exit";
            this.OnFileExit.Click += new System.EventHandler(this.OnFileExit_Click);
            // 
            // contact
            // 
            this.contact.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnAddContact,
            this._SendMessage,
            this.OnEditContact,
            this.OnDeleteContact});
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(61, 20);
            this.contact.Text = "Contact";
            // 
            // OnAddContact
            // 
            this.OnAddContact.Name = "OnAddContact";
            this.OnAddContact.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.OnAddContact.Size = new System.Drawing.Size(180, 22);
            this.OnAddContact.Text = "Add";
            this.OnAddContact.Click += new System.EventHandler(this.OnaddContact_Click);
            // 
            // _SendMessage
            // 
            this._SendMessage.Name = "_SendMessage";
            this._SendMessage.Size = new System.Drawing.Size(180, 22);
            this._SendMessage.Text = "Send Message";
            this._SendMessage.Click += new System.EventHandler(this.OnSendMessage_Click);
            // 
            // OnEditContact
            // 
            this.OnEditContact.Name = "OnEditContact";
            this.OnEditContact.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OnEditContact.Size = new System.Drawing.Size(180, 22);
            this.OnEditContact.Text = "Edit";
            this.OnEditContact.Click += new System.EventHandler(this.OnEditContact_Click);
            // 
            // OnDeleteContact
            // 
            this.OnDeleteContact.Name = "OnDeleteContact";
            this.OnDeleteContact.Size = new System.Drawing.Size(180, 22);
            this.OnDeleteContact.Text = "Delete";
            this.OnDeleteContact.Click += new System.EventHandler(this.OnDeleteContact_Click);
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
            this._listContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listContacts.FormattingEnabled = true;
            this._listContacts.Location = new System.Drawing.Point(0, 0);
            this._listContacts.Name = "_listContacts";
            this._listContacts.Size = new System.Drawing.Size(334, 242);
            this._listContacts.TabIndex = 1;
            // 
            // _listMessages
            // 
            this._listMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listMessages.FormattingEnabled = true;
            this._listMessages.Location = new System.Drawing.Point(0, 0);
            this._listMessages.Name = "_listMessages";
            this._listMessages.Size = new System.Drawing.Size(364, 242);
            this._listMessages.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._listMessages);
            this.panel1.Location = new System.Drawing.Point(444, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 242);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._listContacts);
            this.panel2.Location = new System.Drawing.Point(12, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 242);
            this.panel2.TabIndex = 4;
            // 
            // Contacts
            // 
            this.Contacts.AutoSize = true;
            this.Contacts.Location = new System.Drawing.Point(108, 28);
            this.Contacts.Name = "Contacts";
            this.Contacts.Size = new System.Drawing.Size(49, 13);
            this.Contacts.TabIndex = 5;
            this.Contacts.Text = "Contacts";
            // 
            // SendMessage
            // 
            this.SendMessage.AutoSize = true;
            this.SendMessage.Location = new System.Drawing.Point(530, 28);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(80, 13);
            this.SendMessage.TabIndex = 6;
            this.SendMessage.Text = "Sent Messages";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 491);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.Contacts);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Contact Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Onfile;
        private System.Windows.Forms.ToolStripMenuItem OnFileExit;
        private System.Windows.Forms.ToolStripMenuItem Onhelp;
        private System.Windows.Forms.ToolStripMenuItem OnHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem contact;
        private System.Windows.Forms.ToolStripMenuItem OnAddContact;
        private System.Windows.Forms.ListBox _listContacts;
        private System.Windows.Forms.ToolStripMenuItem OnEditContact;
        private System.Windows.Forms.ToolStripMenuItem OnDeleteContact;
        private System.Windows.Forms.ToolStripMenuItem _SendMessage;
        private System.Windows.Forms.ListBox _listMessages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Contacts;
        private System.Windows.Forms.Label SendMessage;
    }
}

