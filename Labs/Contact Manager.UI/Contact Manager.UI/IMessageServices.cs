using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.UI
{
    interface IMessageServices
    {
        void SendMessage( string message, string subject, string emailAddress );

    }
}
