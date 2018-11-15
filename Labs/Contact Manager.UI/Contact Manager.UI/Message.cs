using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = ContactManager;

namespace ContactManager.UI
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        public Contact Contact { get; internal set; }
        //public MessageForm Message { get; set; }
        private void OnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void MessageForm_Load(object sender, EventArgs e)
        {
            if (Contact != null)
            {
                _txtName.Text = Contact.Name;
                _txtEmailAddress.Text = Contact.EmailAddress;
            }

            if (Contact != null)
            {
                _txtName.Text = Contact.Name;
                _txtEmailAddress.Text = Contact.EmailAddress;
            }

            ValidateChildren();
        }


        private void OnButtonSend_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var contact = new Contact()
            {
                Name = Name.Text,
                  EmailAddress = _txtEmailAddress.Text,
                 Subject = _txtSubject.Text,
                ComposeMessage = _txtMessage.Text,
            };

            var results = ObjectValidator.Validate(contact);
            foreach (var result in results)
            {
                MessageBox.Show(this, result.ErrorMessage, "Validation Failed",
                               MessageBoxButtons.OK);
                return;
            };
            Contact = contact;
            DialogResult = DialogResult.OK;
            Close();
            {
                MessageBox.Show("Subject is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //var message = new Message()
            //{
            //    Name = Name.Text,
            //    EmailAddress = _txtEmailAddress.Text,
            //    Subject = _txtSubject.Text,
            //    ComposeMessage = _txtMessage.Text,
            //};



            //this.Message = this.Message;
            //DialogResult = DialogResult.OK;

            //Close();

        }

        private void OnValidatingSubject(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Subject is required");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");
        }
    }
}
