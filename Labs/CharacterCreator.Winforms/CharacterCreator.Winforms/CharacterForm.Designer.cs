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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._name = new System.Windows.Forms.TextBox();
            this._proffession = new System.Windows.Forms.ComboBox();
            this._race = new System.Windows.Forms.ComboBox();
            this._strength = new System.Windows.Forms.TextBox();
            this._intelligence = new System.Windows.Forms.TextBox();
            this._agility = new System.Windows.Forms.TextBox();
            this._constitution = new System.Windows.Forms.TextBox();
            this._charisma = new System.Windows.Forms.TextBox();
            this._Description = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profession";
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
            // _name
            // 
            this._name.Location = new System.Drawing.Point(88, 27);
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(158, 20);
            this._name.TabIndex = 9;
            this._name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // _proffession
            // 
            this._proffession.FormattingEnabled = true;
            this._proffession.Location = new System.Drawing.Point(88, 77);
            this._proffession.Name = "_proffession";
            this._proffession.Size = new System.Drawing.Size(100, 21);
            this._proffession.TabIndex = 10;
            this._proffession.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // _race
            // 
            this._race.FormattingEnabled = true;
            this._race.Location = new System.Drawing.Point(88, 112);
            this._race.Name = "_race";
            this._race.Size = new System.Drawing.Size(100, 21);
            this._race.TabIndex = 11;
            this._race.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // _strength
            // 
            this._strength.Location = new System.Drawing.Point(88, 153);
            this._strength.Name = "_strength";
            this._strength.Size = new System.Drawing.Size(60, 20);
            this._strength.TabIndex = 12;
            // 
            // _intelligence
            // 
            this._intelligence.Location = new System.Drawing.Point(88, 180);
            this._intelligence.Name = "_intelligence";
            this._intelligence.Size = new System.Drawing.Size(60, 20);
            this._intelligence.TabIndex = 13;
            // 
            // _agility
            // 
            this._agility.Location = new System.Drawing.Point(88, 212);
            this._agility.Name = "_agility";
            this._agility.Size = new System.Drawing.Size(60, 20);
            this._agility.TabIndex = 14;
            // 
            // _constitution
            // 
            this._constitution.Location = new System.Drawing.Point(88, 255);
            this._constitution.Name = "_constitution";
            this._constitution.Size = new System.Drawing.Size(60, 20);
            this._constitution.TabIndex = 15;
            // 
            // _charisma
            // 
            this._charisma.Location = new System.Drawing.Point(88, 295);
            this._charisma.Name = "_charisma";
            this._charisma.Size = new System.Drawing.Size(60, 20);
            this._charisma.TabIndex = 16;
            // 
            // _Description
            // 
            this._Description.Location = new System.Drawing.Point(88, 338);
            this._Description.Multiline = true;
            this._Description.Name = "_Description";
            this._Description.Size = new System.Drawing.Size(217, 145);
            this._Description.TabIndex = 17;
            this._Description.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
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
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 523);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label10);
            this.Controls.Add(this._Description);
            this.Controls.Add(this._charisma);
            this.Controls.Add(this._constitution);
            this.Controls.Add(this._agility);
            this.Controls.Add(this._intelligence);
            this.Controls.Add(this._strength);
            this.Controls.Add(this._race);
            this.Controls.Add(this._proffession);
            this.Controls.Add(this._name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CharacterForm";
            this.Text = "CharacterForm";
            this.Load += new System.EventHandler(this.CharacterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _name;
        private System.Windows.Forms.ComboBox _proffession;
        private System.Windows.Forms.ComboBox _race;
        private System.Windows.Forms.TextBox _strength;
        private System.Windows.Forms.TextBox _intelligence;
        private System.Windows.Forms.TextBox _agility;
        private System.Windows.Forms.TextBox _constitution;
        private System.Windows.Forms.TextBox _charisma;
        private System.Windows.Forms.TextBox _Description;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
    }
}