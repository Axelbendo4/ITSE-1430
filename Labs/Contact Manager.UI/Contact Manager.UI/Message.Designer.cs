namespace ContactManager.UI
{
    partial class Message
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
            this.Subject = new System.Windows.Forms.Label();
            this.OnMessage = new System.Windows.Forms.Label();
            this.OnSubject = new System.Windows.Forms.TextBox();
            this._txtMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Location = new System.Drawing.Point(63, 95);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(43, 13);
            this.Subject.TabIndex = 0;
            this.Subject.Text = "Subject";
            // 
            // OnMessage
            // 
            this.OnMessage.AutoSize = true;
            this.OnMessage.Location = new System.Drawing.Point(66, 161);
            this.OnMessage.Name = "OnMessage";
            this.OnMessage.Size = new System.Drawing.Size(50, 13);
            this.OnMessage.TabIndex = 1;
            this.OnMessage.Text = "Message";
            // 
            // OnSubject
            // 
            this.OnSubject.Location = new System.Drawing.Point(192, 87);
            this.OnSubject.Multiline = true;
            this.OnSubject.Name = "OnSubject";
            this.OnSubject.Size = new System.Drawing.Size(100, 20);
            this.OnSubject.TabIndex = 2;
            // 
            // _txtMessage
            // 
            this._txtMessage.Location = new System.Drawing.Point(192, 161);
            this._txtMessage.Multiline = true;
            this._txtMessage.Name = "_txtMessage";
            this._txtMessage.Size = new System.Drawing.Size(100, 20);
            this._txtMessage.TabIndex = 3;
           
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._txtMessage);
            this.Controls.Add(this.OnSubject);
            this.Controls.Add(this.OnMessage);
            this.Controls.Add(this.Subject);
            this.Name = "Message";
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.Label OnMessage;
        private System.Windows.Forms.TextBox OnSubject;
        private System.Windows.Forms.TextBox _txtMessage;
    }
}