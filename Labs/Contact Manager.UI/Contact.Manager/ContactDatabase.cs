using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ContactManager
{
    public class ContactDatabase
    {
        private List<Contact> _contacts = new List<Contact>();
        private List<Message> _messages = new List<Message>();


        public void Add(Message message)
        {
            if (message == null)
                return;
            MessageAdd(message);


        }

        protected void MessageAdd(Message message) => _messages.Add(message);
        public IEnumerable<Message> GetMessages() => GetAllMessages();
        protected IEnumerable<Message> GetAllMessages()
        {
            return from e in _messages
                   select new Message()
                   {
                       ComposeMessage = e.ComposeMessage,
                       Subject = e.Subject,
                       _Message = e._Message
                   };


        }


        public void Add(Contact contact)
        {
            if (contact == null)
                return;

            ContactAdd(contact);

        }

        public void Delete(string name) => DeleteContact(name);

        protected void DeleteContact(string name)
        {
            var contact = FindByName(name);
            if (contact != null)
                _contacts.Remove(contact);
        }


        public void Edit(string name, Contact contact)
        {
            ObjectValidator.Validate(contact);
            var existingContact = FindByName(name);

            EditContact(existingContact, contact);
        }

        protected void EditContact(Contact oldContact, Contact newContact)
        {
            _contacts.Remove(oldContact);

            _contacts.Add(newContact);
        }


        protected void ContactAdd(Contact contact) => _contacts.Add(contact);

        public bool ExistingContact(Contact contact) => CheckExistingContact(contact);

        protected bool CheckExistingContact(Contact contact)
        {

            foreach (var item in _contacts)
            {

                if ((contact.Name == item.Name) && (contact.ContactEmailAdress == item.ContactEmailAdress))
                    return true;
            }

            return false;

        }
        protected Contact FindByName(string name)
        {
            return (from c in _contacts
                    where String.Compare(name, c.Name, true) == 0
                    select c).FirstOrDefault();
        }


        public IEnumerable<Contact> GetAll() => GetAllContacts();

        protected IEnumerable<Contact> GetAllContacts()
        {
            return from c in _contacts
                   select new Contact()
                   {
                       Name = c.Name,
                       ContactEmailAdress = c.ContactEmailAdress
                   };
        }
    }
}


         


   
    
          
           
        

       


        






      





