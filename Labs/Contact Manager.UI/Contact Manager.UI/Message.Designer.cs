namespace ContactManager.UI
{
    partial class MessageForm
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
            this.components = new System.ComponentModel.Container();
            this.Subject = new System.Windows.Forms.Label();
            this._Message = new System.Windows.Forms.Label();
            this._txtSubject = new System.Windows.Forms.TextBox();
            this._txtMessage = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this._txtEmailAddress = new System.Windows.Forms.TextBox();
            this._txtName = new System.Windows.Forms.TextBox();
            this.OnButtonSend = new System.Windows.Forms.Button();
            this.OnCancel = new System.Windows.Forms.Button();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Location = new System.Drawing.Point(56, 238);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(43, 13);
            this.Subject.TabIndex = 0;
            this.Subject.Text = "Subject";
            // 
            // _Message
            // 
            this._Message.AutoSize = true;
            this._Message.Location = new System.Drawing.Point(56, 283);
            this._Message.Name = "_Message";
            this._Message.Size = new System.Drawing.Size(50, 13);
            this._Message.TabIndex = 1;
            this._Message.Text = "Message";
            // 
            // _txtSubject
            // 
            this._txtSubject.Location = new System.Drawing.Point(160, 238);
            this._txtSubject.Multiline = true;
            this._txtSubject.Name = "_txtSubject";
            this._txtSubject.Size = new System.Drawing.Size(100, 20);
            this._txtSubject.TabIndex = 2;
            // 
            // _txtMessage
            // 
            this._txtMessage.Location = new System.Drawing.Point(160, 276);
            this._txtMessage.Multiline = true;
            this._txtMessage.Name = "_txtMessage";
            this._txtMessage.Size = new System.Drawing.Size(100, 20);
            this._txtMessage.TabIndex = 3;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.AutoSize = true;
            this.txtEmailAddress.Location = new System.Drawing.Point(59, 171);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(70, 13);
            this.txtEmailAddress.TabIndex = 4;
            this.txtEmailAddress.Text = "EmailAddress";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(59, 122);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 5;
            this.Name.Text = "Name";
            // 
            // _txtEmailAddress
            // 
            this._txtEmailAddress.Location = new System.Drawing.Point(160, 164);
            this._txtEmailAddress.Name = "_txtEmailAddress";
            this._txtEmailAddress.Size = new System.Drawing.Size(100, 20);
            this._txtEmailAddress.TabIndex = 6;
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(160, 115);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(100, 20);
            this._txtName.TabIndex = 7;
            // 
            // OnButtonSend
            // 
            this.OnButtonSend.Location = new System.Drawing.Point(160, 373);
            this.OnButtonSend.Name = "OnButtonSend";
            this.OnButtonSend.Size = new System.Drawing.Size(75, 23);
            this.OnButtonSend.TabIndex = 8;
            this.OnButtonSend.Text = "Send";
            this.OnButtonSend.UseVisualStyleBackColor = true;
            this.OnButtonSend.Click += new System.EventHandler(this.OnButtonSend_Click);
            // 
            // OnCancel
            // 
            this.OnCancel.Location = new System.Drawing.Point(407, 373);
            this.OnCancel.Name = "OnCancel";
            this.OnCancel.Size = new System.Drawing.Size(75, 23);
            this.OnCancel.TabIndex = 9;
            this.OnCancel.Text = "Cancel";
            this.OnCancel.UseVisualStyleBackColor = true;
            this.OnCancel.Click += new System.EventHandler(this.OnCancel_Click);
            // 
            // _errors
            // 
            this._errors.ContainerControl = this;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OnCancel);
            this.Controls.Add(this.OnButtonSend);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this._txtEmailAddress);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this._txtMessage);
            this.Controls.Add(this._txtSubject);
            this.Controls.Add(this._Message);
            this.Controls.Add(this.Subject);
            //this.Name = "MessageForm";
            this.Text = "Message";
            this.Load += new System.EventHandler(this.Message_Load);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.Label _Message;
        private System.Windows.Forms.TextBox _txtSubject;
        private System.Windows.Forms.TextBox _txtMessage;
        private System.Windows.Forms.Label txtEmailAddress;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox _txtEmailAddress;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Button OnButtonSend;
        private System.Windows.Forms.Button OnCancel;
        private System.Windows.Forms.ErrorProvider _errors;
    }
}