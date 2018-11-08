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

        protected override void OnLoad( EventArgs e)
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
        private Database _database = new Database();
        private void OnaddContact_Click(object sender, EventArgs e)
        {
            var form = new ContactForm();

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.Add(form.contact);
            RefreshContacts();



        }

        private void RefreshContacts()
        {
            var contacts = from m in  _database.GetAll()
                           orderby m.Name
                           select m;

            _listContacts.Items.Clear();
            _listContacts.Items.AddRange(contacts.ToArray());

        }

        private void OnEditContact_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        private void EditContact()
        {


            var item = GetSelectedContact();
            if (item == null)
                return;

            var form = new ContactForm();
            form.contact = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.EditContact(item.Name, form.contact);
            RefreshContacts();



        }
        private void OnContactDoubleClick(object sender, EventArgs e)
        {
            EditContact();
        }
        private Contact GetSelectedContact()
        {
            return _listContacts.SelectedItem as Contact;
        }

        private void OnDeleteContact_Click(object sender, EventArgs e)
        {
           

            if (MessageBox.Show("Are you sure you want to Delete this Contact?",
                     "Delete Contact", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DeleteContact();
           
        }

        private void DeleteContact()
        {

            var item = GetSelectedContact();
            if (item == null)
                return;

            _database.RemoveContact(item.Name);
            RefreshContacts();


        }

        private void OnSendMessage_Click(object sender, EventArgs e)
        {
            var item = GetSelectedContact();
            if (item == null)
                return;

            var form = new MessageForm();
            form.Contact = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;
        }
    }

}
