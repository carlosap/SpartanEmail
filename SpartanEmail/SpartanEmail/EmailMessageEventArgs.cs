using System;

namespace SpartanEmail
{
    public class EmailMessageEventArgs : EventArgs
    {
        public EmailMessage EmailMsg { get; set; }
    }
}
