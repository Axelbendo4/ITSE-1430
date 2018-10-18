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
    public partial class    MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void fileToolStripMenuItem_Click(object sender , EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("you want to exit ?", "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            Close();
        }

       



        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CharacterForm();

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;


        }

        

        private void characterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Axel Gaucen Bendo\n ITSE 1430\n  Charactere Creator ", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _listCharacters.DisplayMember = "Name";
            RefreshCharacters();

        }

        private void OnCharacterAdd(object sender, EventArgs e)
        {
            var form = new CharacterForm();
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.Add(form.Characters);
            RefreshCharacters();

        }

        private void OnCharacterEdit(object sender, EventArgs e)
        {
            var item = GetSelectedCharacter();
            if (item == null)
                return;

            var form = new CharacterForm();
            form.Text = "Edit Character";
            form.Characters = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.Edit(item.Name, form.Characters);
            RefreshCharacters();

        }

        private void OnCharacterDelete(object sender, EventArgs e)
        {
            var item = GetSelectedCharacter();
            if (item == null)
                return;

            if (MessageBox.Show("Are you sure you want to Delete this Character?",
                      "Delete Character", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            _database.Remove(item.Name);
            RefreshCharacters();
        }

        private Character GetSelectedCharacter()
        {
            return _listCharacters.SelectedItem as Character;
        }

        private void RefreshCharacters()
        {
            var characters = _database.GetAll();

            _listCharacters.Items.Clear();
            _listCharacters.Items.AddRange(characters);
        }

        private DatabaseofCharacter _database = new DatabaseofCharacter();

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}