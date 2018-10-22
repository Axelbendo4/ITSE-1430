namespace CharacterCreator.Winforms
{
    partial class CharacterForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this._txtProfession = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtProffession = new System.Windows.Forms.ComboBox();
            this._txtrace = new System.Windows.Forms.ComboBox();
            this._txtstrength = new System.Windows.Forms.TextBox();
            this._txtintelligence = new System.Windows.Forms.TextBox();
            this._txtagility = new System.Windows.Forms.TextBox();
            this._txtconstitution = new System.Windows.Forms.TextBox();
            this._txtcharisma = new System.Windows.Forms.TextBox();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // _txtProfession
            // 
            this._txtProfession.AutoSize = true;
            this._txtProfession.Location = new System.Drawing.Point(5, 80);
            this._txtProfession.Name = "_txtProfession";
            this._txtProfession.Size = new System.Drawing.Size(56, 13);
            this._txtProfession.TabIndex = 1;
            this._txtProfession.Text = "Profession";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Race";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Strenght";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Intelligence";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Agility";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Constitution";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Charisma";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Description";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(88, 27);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(158, 20);
            this._txtName.TabIndex = 9;
            this._txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateName);
            // 
            // _txtProffession
            // 
            this._txtProffession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._txtProffession.FormattingEnabled = true;
            this._txtProffession.Items.AddRange(new object[] {
            "",
            "hunter",
            "Preist",
            "Rogue",
            "Wizard"});
            this._txtProffession.Location = new System.Drawing.Point(88, 77);
            this._txtProffession.Name = "_txtProffession";
            this._txtProffession.Size = new System.Drawing.Size(100, 21);
            this._txtProffession.TabIndex = 10;
            this._txtProffession.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // _txtrace
            // 
            this._txtrace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._txtrace.FormattingEnabled = true;
            this._txtrace.Items.AddRange(new object[] {
            "",
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
            this._txtrace.Location = new System.Drawing.Point(88, 112);
            this._txtrace.Name = "_txtrace";
            this._txtrace.Size = new System.Drawing.Size(100, 21);
            this._txtrace.TabIndex = 11;
            this._txtrace.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // _txtstrength
            // 
            this._txtstrength.Location = new System.Drawing.Point(88, 153);
            this._txtstrength.Name = "_txtstrength";
            this._txtstrength.Size = new System.Drawing.Size(60, 20);
            this._txtstrength.TabIndex = 12;
            this._txtstrength.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateStrength);
            // 
            // _txtintelligence
            // 
            this._txtintelligence.Location = new System.Drawing.Point(88, 180);
            this._txtintelligence.Name = "_txtintelligence";
            this._txtintelligence.Size = new System.Drawing.Size(60, 20);
            this._txtintelligence.TabIndex = 13;
            this._txtintelligence.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateIntelligence);
            // 
            // _txtagility
            // 
            this._txtagility.Location = new System.Drawing.Point(88, 212);
            this._txtagility.Name = "_txtagility";
            this._txtagility.Size = new System.Drawing.Size(60, 20);
            this._txtagility.TabIndex = 14;
            this._txtagility.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateAgility);
            // 
            // _txtconstitution
            // 
            this._txtconstitution.Location = new System.Drawing.Point(88, 255);
            this._txtconstitution.Name = "_txtconstitution";
            this._txtconstitution.Size = new System.Drawing.Size(60, 20);
            this._txtconstitution.TabIndex = 15;
            this._txtconstitution.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateConstitution);
            // 
            // _txtcharisma
            // 
            this._txtcharisma.Location = new System.Drawing.Point(88, 295);
            this._txtcharisma.Name = "_txtcharisma";
            this._txtcharisma.Size = new System.Drawing.Size(60, 20);
            this._txtcharisma.TabIndex = 16;
            this._txtcharisma.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateCharisma);
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(88, 338);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(217, 145);
            this._txtDescription.TabIndex = 17;
            this._txtDescription.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Name";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(88, 489);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 19;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(212, 489);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 20;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // _errors
            // 
            this._errors.ContainerControl = this;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(320, 523);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label10);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this._txtcharisma);
            this.Controls.Add(this._txtconstitution);
            this.Controls.Add(this._txtagility);
            this.Controls.Add(this._txtintelligence);
            this.Controls.Add(this._txtstrength);
            this.Controls.Add(this._txtrace);
            this.Controls.Add(this._txtProffession);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtProfession);
            this.Controls.Add(this.label1);
            this.Name = "CharacterForm";
            this.Text = "CharacterForm";
            this.Load += new System.EventHandler(this.CharacterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _txtProfession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.ComboBox _txtProffession;
        private System.Windows.Forms.ComboBox _txtrace;
        private System.Windows.Forms.TextBox _txtstrength;
        private System.Windows.Forms.TextBox _txtintelligence;
        private System.Windows.Forms.TextBox _txtagility;
        private System.Windows.Forms.TextBox _txtconstitution;
        private System.Windows.Forms.TextBox _txtcharisma;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ErrorProvider _errors;
    }
}