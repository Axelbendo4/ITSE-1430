using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }
        
        private void CharacterForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            var character = new Character();
            character.Name = _name.Text;
            character.Profession = _profession.Text;
            character.Race = _race.Text;
            character.Strength = GetInt32(strength);
            character.Intelligence = GetInt32(intelligence);
            character.Agility = GetInt32(agility);
            character.Constitution = GetInt32(_constitution);
            character.Charisma = GetInt32(charisma);
            character.Description = Description.Text;

            Character = character;
            DialogResult = DialogResult.OK;
            Close();
        }
        private int GetInt32(TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
                return 0;

            if (Int32.TryParse(textBox.Text, out var value))
                return value;

            return -1;

        }
        public Character Character { get; set; }
        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
