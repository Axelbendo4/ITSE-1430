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
        public Message Message { get; set; }
        public Contact Contact { get;  set; }
       
        private void OnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void MessageForm_Load(object sender, EventArgs e)
        {
            if (Contact != null)
            {
                _txtName.Text = Contact.Name;
                _txtEmailAddress.Text = Contact.ContactEmailAdress;
            }

           
        }
        private void OnValidatingSubject(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Subject is required");
                e.Cancel = true;
            }
           
        }

        private void OnButtonSend_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var messsage = new Message()
            {
               
                _Message= _txtMessage.Text,
                Subject = _txtSubject.Text,
                ComposeMessage = _txtEmailAddress.Text,
            };

            var results = ObjectValidator.Validate(messsage);
            foreach (var result in results)
            {
                MessageBox.Show(this, result.ErrorMessage, "Validation Failed",
                               MessageBoxButtons.OK);
                return;
            };
            Message = Message;
            DialogResult = DialogResult.OK;
            Close();


        }


        private void OnvalidateMessage(object sender , CancelEventArgs e)
        {

            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "You must send a Valid Email.");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");


        }


        private void OnValidateSubject(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "There must be a subject for the email.");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");


        }





    }
}
