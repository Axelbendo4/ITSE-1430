namespace Itse1430.MovieLib.UI
{
    partial class _txtDescription
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
            this.label1 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this._txtRelease = new System.Windows.Forms.Label();
            this._txtRunLenght = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._txtName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(43, 66);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 13);
            this.Description.TabIndex = 3;
            this.Description.Text = "Description";
            // 
            // _txtRelease
            // 
            this._txtRelease.AutoSize = true;
            this._txtRelease.Location = new System.Drawing.Point(43, 115);
            this._txtRelease.Name = "_txtRelease";
            this._txtRelease.Size = new System.Drawing.Size(46, 13);
            this._txtRelease.TabIndex = 4;
            this._txtRelease.Text = "Release";
            // 
            // _txtRunLenght
            // 
            this._txtRunLenght.AutoSize = true;
            this._txtRunLenght.Location = new System.Drawing.Point(43, 175);
            this._txtRunLenght.Name = "_txtRunLenght";
            this._txtRunLenght.Size = new System.Drawing.Size(63, 13);
            this._txtRunLenght.TabIndex = 5;
            this._txtRunLenght.Text = "Run Lenght";
            this._txtRunLenght.Click += new System.EventHandler(this.label4_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(117, 32);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 168);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(117, 254);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 10;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(274, 254);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 11;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _txtName
            // 
            this._txtName.AutoSize = true;
            this._txtName.Location = new System.Drawing.Point(42, 27);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(35, 13);
            this._txtName.TabIndex = 12;
            this._txtName.Text = "Name";
            this._txtName.Click += new System.EventHandler(this.label5_Click);
            // 
            // _txtDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 496);
            this.ControlBox = false;
            this.Controls.Add(this._txtName);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textName);
            this.Controls.Add(this._txtRunLenght);
            this.Controls.Add(this._txtRelease);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label1);
            this.Name = "_txtDescription";
            this.ShowInTaskbar = false;
            this.Text = "Movie Details";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label _txtRelease;
        private System.Windows.Forms.Label _txtRunLenght;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Label _txtName;
    }
}