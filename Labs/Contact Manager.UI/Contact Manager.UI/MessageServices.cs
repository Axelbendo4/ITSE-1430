using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactManager;
using ContactManager.UI;

namespace ContactManager.UI
{


    public class MessageServices : IMessageServices
    {
        public void Send(Message message)
        {

        }

        public void Send(string emailAddress, string subject, string message)
        {
            throw new NotImplementedException();
        }

        public void Add(Contact contact)
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get => _name ?? "";
            set => _name = value;
        }
        private string _name = "";

        public string EmailAddress
        {
            get => _emailAddress ?? "";
            set => _emailAddress = value;
        }
        private string _emailAddress = "";

        public string Subject
        {
            get => _subject ?? "";
            set => _subject = value;
        }
        private string _subject = "";

        public string ComposeMessage
        {
            get => _composeMessage ?? "";
            set => _composeMessage = value;
        }
        private string _composeMessage = "";

    }
}