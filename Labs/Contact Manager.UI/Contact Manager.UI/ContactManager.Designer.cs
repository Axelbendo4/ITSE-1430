namespace Contact_Manager.UI
{
    partial class ContactManager
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
            this.Onsave = new System.Windows.Forms.Button();
            this.OnCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.OnName = new System.Windows.Forms.Label();
            this.OnEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Onsave
            // 
            this.Onsave.Location = new System.Drawing.Point(55, 257);
            this.Onsave.Name = "Onsave";
            this.Onsave.Size = new System.Drawing.Size(75, 23);
            this.Onsave.TabIndex = 0;
            this.Onsave.Text = "Save";
            this.Onsave.UseVisualStyleBackColor = true;
            // 
            // OnCancel
            // 
            this.OnCancel.Location = new System.Drawing.Point(207, 257);
            this.OnCancel.Name = "OnCancel";
            this.OnCancel.Size = new System.Drawing.Size(75, 23);
            this.OnCancel.TabIndex = 1;
            this.OnCancel.Text = "Cancel";
            this.OnCancel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // OnName
            // 
            this.OnName.AutoSize = true;
            this.OnName.Location = new System.Drawing.Point(41, 43);
            this.OnName.Name = "OnName";
            this.OnName.Size = new System.Drawing.Size(35, 13);
            this.OnName.TabIndex = 4;
            this.OnName.Text = "Name";
            // 
            // OnEmail
            // 
            this.OnEmail.AutoSize = true;
            this.OnEmail.Location = new System.Drawing.Point(44, 131);
            this.OnEmail.Name = "OnEmail";
            this.OnEmail.Size = new System.Drawing.Size(32, 13);
            this.OnEmail.TabIndex = 5;
            this.OnEmail.Text = "Email";
            // 
            // ContactManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 292);
            this.Controls.Add(this.OnEmail);
            this.Controls.Add(this.OnName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OnCancel);
            this.Controls.Add(this.Onsave);
            this.Name = "ContactManager";
            this.Text = "ContactManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Onsave;
        private System.Windows.Forms.Button OnCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label OnName;
        private System.Windows.Forms.Label OnEmail;
    }
}