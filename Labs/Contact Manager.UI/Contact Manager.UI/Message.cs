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
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        public Contact Contact { get; internal set; }
        public MessageForm Message { get; private set; }

        private void Message_Load(object sender, EventArgs e)
        {
            if (Contact != null)
            {
                Name.Text = Contact.Name;
                EmailAddress.Text = Contact.EmailAddress;
            }

            if (Message != null)
            {
                Name.Text = Message.Name;
                _txtEmailAddress.Text = Message.txtEmailAddress;
            }

            ValidateChildren();
        }

        private void OnCancel_Click(object sender, EventArgs e)
        {
            Close();
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
                Message = _txtMessage.Text,
            };


            Message = message;
            DialogResult = DialogResult.OK;

            Close();

        }

        

    }
}
