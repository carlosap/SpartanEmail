using System;
using System.Threading.Tasks;

namespace SpartanEmail
{

    public class EmailMessageEvent
    {
        public event EventHandler<EmailMessageEventArgs> EmailMsgSendEvent;
        public async void Send(EmailMessage email)
        {
            await Task.Run(() =>
            {
                //Raise the Event
                OnEmailMsgSendEvent(email);
            });
        }

        protected virtual void OnEmailMsgSendEvent(EmailMessage email)
        {
            EmailMsgSendEvent?.Invoke(this, new EmailMessageEventArgs { EmailMsg = email });
        }

    }
}
