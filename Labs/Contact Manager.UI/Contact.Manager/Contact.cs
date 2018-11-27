using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Contact : IValidatableObject
    {

        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }
        private string _name;

        public string ContactEmailAdress
        {
            get => _contactEmailAdress ?? "";
            set => _contactEmailAdress = value;
        }
        private string _contactEmailAdress = "";

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (String.IsNullOrEmpty(Name))
                yield return new ValidationResult("Name is required.", new[] { nameof(Name) });

            if (String.IsNullOrEmpty(ContactEmailAdress))
                yield return new ValidationResult("Email is required.", new[] { nameof(Name) });
           
        }

        
    }
}


    

