using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = ContactManager.MessageSendDatabase;

namespace ContactManager.UI
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        public Contact Contact { get; internal set; }
        public MessageForm Message { get; private set; }
        private void OnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Message_Load(object sender, EventArgs e)
        {
            if (Contact != null)
            {
                _txtName.Text = Contact.Name;
                _txtEmailAddress.Text = Contact.EmailAddress;
            }

            if (Message != null)
            {
                _txtName.Text = Message.Name.Text;
                _txtEmailAddress.Text = Message.txtEmailAddress.Text;
            }

            ValidateChildren();
        }

        

        private void OnButtonSend_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_txtSubject.Text))
            {
                MessageBox.Show("Subject is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var message = new Message()
            {
                Name = Name.Text,
                EmailAddress = _txtEmailAddress.Text,
                Subject = _txtSubject.Text,
                ComposeMessage = _txtMessage.Text,
            };


            Message = Message;
            DialogResult = DialogResult.OK;

            Close();

        }

       
    }
}
