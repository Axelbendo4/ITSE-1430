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

        public Character Characters { get; set; }




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
        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private int GetInt32(TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
                return -1;
            if (Int32.TryParse(textBox.Text, out var value))
                return value;

            return -1;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                return;

            var character = new Character();
            character.Name = _txtName.Text;
            character.Profession = _txtProfession.Text;
            character.Race = _txtrace.Text;
            character.Strength = GetInt32(_txtstrength);
            character.Intelligence = GetInt32(_txtintelligence);
            character.Agility = GetInt32(_txtagility);
            character.Constitution = GetInt32(_txtconstitution);
            character.Charisma = GetInt32(_txtcharisma);
            character.Description = _txtDescription.Text;

            Characters = character;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CharacterForm_Load(object sender, EventArgs e)
        {
            _txtProffession.SelectedIndex = 0;
            _txtrace.SelectedIndex = 0;
            _txtProffession.Items.Add("fighter");

            if (Characters != null)
            {
                _txtName.Text = Characters.Name;
                _txtProfession.Text = Characters.Profession;
                _txtrace.Text = Characters.Race;
                _txtstrength.Text = Characters.Strength.ToString();
                _txtintelligence.Text = Characters.Intelligence.ToString();
                _txtagility.Text = Characters.Agility.ToString();
                _txtconstitution.Text = Characters.Constitution.ToString();
                _txtcharisma.Text = Characters.Charisma.ToString();
                _txtDescription.Text = Characters.Description;
            };

            ValidateChildren();
        }




        private void OnValidateName(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Name is resquired");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");

        }

        private void OnValidateStrength(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            var result = GetInt32(control);
            if (result < 0)
            {
                _errors.SetError(control, "Must be between 1-100");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");
        }

        private void OnValidateIntelligence(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            var result = GetInt32(control);
            if (result < 0)
            {
                _errors.SetError(control, "Must be between 1-100");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");

        }

        private void OnValidateAgility(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            var result = GetInt32(control);
            if (result < 0)
            {
                _errors.SetError(control, "Must be between 1-100");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");
        }

        private void OnValidateConstitution(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            var result = GetInt32(control);
            if (result < 0)
            {
                _errors.SetError(control, "Must be between 1-100");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");
        }

        private void OnValidateCharisma(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            var result = GetInt32(control);
            if (result < 0)
            {
                _errors.SetError(control, "Must be between 1-100");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");
        }
    }
}
