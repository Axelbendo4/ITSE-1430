using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Message : IValidatableObject
    {

        public string _Message
        {
            get => _message ?? "";
            set => _message = value;
        }
        private string _message = "";

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
            get => __composeMessage ?? "";
            set => __composeMessage = value;
        }
        private string __composeMessage = "";

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            if (String.IsNullOrEmpty(Subject))
                yield return new ValidationResult("Subject is required.",
                                new[] { nameof(Subject) });




        }

    


    }
}
