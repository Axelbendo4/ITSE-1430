using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnLoad( EventArgs e)
        {
            base.OnLoad(e);

            _listContacts.DisplayMember = "Name";
            RefreshContacts();
        }

        private void OnFileExit_Click( object sender, EventArgs e )
        {
            if (MessageBox.Show("Do you want to exit ?", "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            Close();
        }

        private void OnHelpAbout_Click( object sender, EventArgs e )
        {
            MessageBox.Show(this, "Axel Gaucen Bendo\n ITSE 1430\n  Contact Manager ", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnaddContact_Click(object sender, EventArgs e)
        {
            var form = new ContactForm();

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            Database.Add(form.Contact);
            RefreshContacts();
        }
    }
}
