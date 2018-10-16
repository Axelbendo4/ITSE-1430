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
            this._profession = new System.Windows.Forms.Label();
            this._race = new System.Windows.Forms.Label();
            this._strength = new System.Windows.Forms.Label();
            this._intelligence = new System.Windows.Forms.Label();
            this._agility = new System.Windows.Forms.Label();
            this.Constitution = new System.Windows.Forms.Label();
            this._charisma = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.profession = new System.Windows.Forms.ComboBox();
            this.race = new System.Windows.Forms.ComboBox();
            this.strength = new System.Windows.Forms.TextBox();
            this.intelligence = new System.Windows.Forms.TextBox();
            this.agility = new System.Windows.Forms.TextBox();
            this._constitution = new System.Windows.Forms.TextBox();
            this.charisma = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this._name = new System.Windows.Forms.Label();
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
            // _profession
            // 
            this._profession.AutoSize = true;
            this._profession.Location = new System.Drawing.Point(5, 80);
            this._profession.Name = "_profession";
            this._profession.Size = new System.Drawing.Size(55, 13);
            this._profession.TabIndex = 1;
            this._profession.Text = "profession";
            // 
            // _race
            // 
            this._race.AutoSize = true;
            this._race.Location = new System.Drawing.Point(5, 121);
            this._race.Name = "_race";
            this._race.Size = new System.Drawing.Size(33, 13);
            this._race.TabIndex = 2;
            this._race.Text = "Race";
            // 
            // _strength
            // 
            this._strength.AutoSize = true;
            this._strength.Location = new System.Drawing.Point(5, 156);
            this._strength.Name = "_strength";
            this._strength.Size = new System.Drawing.Size(47, 13);
            this._strength.TabIndex = 3;
            this._strength.Text = "Strength";
            // 
            // _intelligence
            // 
            this._intelligence.AutoSize = true;
            this._intelligence.Location = new System.Drawing.Point(5, 187);
            this._intelligence.Name = "_intelligence";
            this._intelligence.Size = new System.Drawing.Size(61, 13);
            this._intelligence.TabIndex = 4;
            this._intelligence.Text = "Intelligence";
            // 
            // _agility
            // 
            this._agility.AutoSize = true;
            this._agility.Location = new System.Drawing.Point(5, 219);
            this._agility.Name = "_agility";
            this._agility.Size = new System.Drawing.Size(34, 13);
            this._agility.TabIndex = 5;
            this._agility.Text = "Agility";
            // 
            // Constitution
            // 
            this.Constitution.AutoSize = true;
            this.Constitution.Location = new System.Drawing.Point(5, 262);
            this.Constitution.Name = "Constitution";
            this.Constitution.Size = new System.Drawing.Size(62, 13);
            this.Constitution.TabIndex = 6;
            this.Constitution.Text = "Constitution";
            // 
            // _charisma
            // 
            this._charisma.AutoSize = true;
            this._charisma.Location = new System.Drawing.Point(5, 302);
            this._charisma.Name = "_charisma";
            this._charisma.Size = new System.Drawing.Size(50, 13);
            this._charisma.TabIndex = 7;
            this._charisma.Text = "Charisma";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(5, 338);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 13);
            this.Description.TabIndex = 8;
            this.Description.Text = "Description";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(88, 27);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(158, 20);
            this.name.TabIndex = 9;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // profession
            // 
            this.profession.FormattingEnabled = true;
            this.profession.Location = new System.Drawing.Point(88, 77);
            this.profession.Name = "profession";
            this.profession.Size = new System.Drawing.Size(121, 21);
            this.profession.TabIndex = 10;
            this.profession.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // race
            // 
            this.race.FormattingEnabled = true;
            this.race.Location = new System.Drawing.Point(88, 112);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(121, 21);
            this.race.TabIndex = 11;
            this.race.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // strength
            // 
            this.strength.Location = new System.Drawing.Point(88, 156);
            this.strength.Name = "strength";
            this.strength.Size = new System.Drawing.Size(46, 20);
            this.strength.TabIndex = 12;
            // 
            // intelligence
            // 
            this.intelligence.Location = new System.Drawing.Point(88, 184);
            this.intelligence.Name = "intelligence";
            this.intelligence.Size = new System.Drawing.Size(46, 20);
            this.intelligence.TabIndex = 13;
            // 
            // agility
            // 
            this.agility.Location = new System.Drawing.Point(88, 216);
            this.agility.Name = "agility";
            this.agility.Size = new System.Drawing.Size(46, 20);
            this.agility.TabIndex = 14;
            // 
            // _constitution
            // 
            this._constitution.Location = new System.Drawing.Point(88, 259);
            this._constitution.Name = "_constitution";
            this._constitution.Size = new System.Drawing.Size(46, 20);
            this._constitution.TabIndex = 15;
            // 
            // charisma
            // 
            this.charisma.Location = new System.Drawing.Point(88, 302);
            this.charisma.Name = "charisma";
            this.charisma.Size = new System.Drawing.Size(46, 20);
            this.charisma.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(88, 338);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(217, 145);
            this.textBox7.TabIndex = 17;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // _name
            // 
            this._name.AutoSize = true;
            this._name.Location = new System.Drawing.Point(11, 34);
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(35, 13);
            this._name.TabIndex = 18;
            this._name.Text = "Name";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(134, 500);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 19;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(233, 500);
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
            this.Controls.Add(this._name);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.charisma);
            this.Controls.Add(this._constitution);
            this.Controls.Add(this.agility);
            this.Controls.Add(this.intelligence);
            this.Controls.Add(this.strength);
            this.Controls.Add(this.race);
            this.Controls.Add(this.profession);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Description);
            this.Controls.Add(this._charisma);
            this.Controls.Add(this.Constitution);
            this.Controls.Add(this._agility);
            this.Controls.Add(this._intelligence);
            this.Controls.Add(this._strength);
            this.Controls.Add(this._race);
            this.Controls.Add(this._profession);
            this.Controls.Add(this.label1);
            this.Name = "CharacterForm";
            this.Text = "CharacterForm";
            this.Load += new System.EventHandler(this.CharacterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _profession;
        private System.Windows.Forms.Label _race;
        private System.Windows.Forms.Label _strength;
        private System.Windows.Forms.Label _intelligence;
        private System.Windows.Forms.Label _agility;
        private System.Windows.Forms.Label Constitution;
        private System.Windows.Forms.Label _charisma;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox profession;
        private System.Windows.Forms.ComboBox race;
        private System.Windows.Forms.TextBox strength;
        private System.Windows.Forms.TextBox intelligence;
        private System.Windows.Forms.TextBox agility;
        private System.Windows.Forms.TextBox _constitution;
        private System.Windows.Forms.TextBox charisma;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label _name;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
    }
}