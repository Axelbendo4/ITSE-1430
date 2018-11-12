using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
   public abstract class Database : IContactDatabase
    {

        private List<Contact> _items = new List<Contact>();
        public void Add(Contact contact)
        {
            if (contact == null)
                return;

            ContactAdd(contact);
        }

        protected void ContactAdd(Contact contact) => _items.Add(contact);

        protected Contact FindByName(string name)
        {
            return (from c in _items
                    where String.Compare(name, c.Name, true) == 0
                    select c).FirstOrDefault();
        }

        public IEnumerable<Contact> GetAll() => GetAllContacts();

        protected IEnumerable<Contact> GetAllContacts()
        {
            return from c in _items
                   select new Contact()
                   {
                       Name = c.Name,
                       EmailAddress = c.EmailAddress
                   };
        }
        public void RemoveContact(string name)
        {
            var contact = FindByName(name);
            if (contact != null)
                _items.Remove(contact);
        }
        public void EditContact(string name, Contact contact)
        {
            RemoveContact(name);
            Add(contact);
        }

        public void Edit(string name, Contact contact)
        {
            throw new NotImplementedException();
        }

        public void Remove(string name)
        {
            throw new NotImplementedException();
        }
    }



}

