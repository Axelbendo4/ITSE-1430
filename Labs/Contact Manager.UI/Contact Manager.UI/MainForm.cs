
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
    public partial class MainForm : Form, IMessageServices
    {
        public MainForm()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);



            _listContacts.DisplayMember = "Name";
            _listMessages.DisplayMember = "EmailAddress";
            RefreshContacts();
            Sent();


        }


        private ContactDatabase _database = new ContactDatabase();

        private void OnFileExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit ?", "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            Close();
        }


        private void OnHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Axel Gaucen Bendo\n ITSE 1430\n  Contact Manager ", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private Contact GetSelectedContact() => _listContacts.SelectedItem as Contact;
        private Message GetSelectedMessage() => _listMessages.SelectedItem as Message;
        private void OnaddContact_Click(object sender, EventArgs e)
        {
            var form = new ContactForm();

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;
            if (_database.ExistingContact(form.Contact))
            {
                MessageBox.Show(this, "Contact already exists", "Duplicate Contact", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                _database.Add(form.Contact);
                RefreshContacts();
            };


        }
        private void OnContactEdit(object sender, EventArgs e) => EditContact();

        private void EditContact()
        {

            var item = GetSelectedContact();
            if (item == null)
                return;

            var form = new ContactForm();
            form.Text = "Edit Contact";
            form.Contact = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.Edit(item.Name, form.Contact);
            RefreshContacts();



        }
        private void RefreshContacts()
        {
            var contacts = from c in _database.GetAll()
                           orderby c.Name
                           select c;

            _listContacts.Items.Clear();
            _listContacts.Items.AddRange(contacts.ToArray());




        }
        private void OnEditContact_Click(object sender, EventArgs e)
        {
            EditContact();
        }


        private void OnContactDoubleClick(object sender, EventArgs e)
        {
            EditContact();
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

            _database.Delete(item.Name);
            RefreshContacts();


        }

        private void OnSendMessage_Click(object sender, EventArgs e) => SendMessage();


        private void SendMessage()
        {
            var item = GetSelectedContact();
            if (item == null)
                return;

            var form = new MessageForm();
            form.Contact = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;
            _database.Add(form.Message);
            Sent();



        }
        public void Sent()
        {
            var messages = from e in _database.GetMessages()
                           orderby e.ComposeMessage
                           select e;


            _listMessages.Items.Clear();
            _listMessages.Items.AddRange(messages.ToArray());
        }
      

        

        private void OnViewMessage_Click(object sender, EventArgs e)
        {
            var item = GetSelectedMessage();
            if (item == null)
                return;

            MessageBox.Show(this, $"Email Address: {item.ComposeMessage}\nSubject: {item.Subject}\nMessage: {item._Message}", "Sent Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

  
}

