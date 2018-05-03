using System;
using System.Threading.Tasks;

namespace SpartanEmail
{
    public class EmailMessageService
    {
        private Email _email;
        public EmailMessageService()
        {
            _email = new Email();
        }

        public async void OnSendEmailEvent(object source, EmailMessageEventArgs e)
        {
            await Task.Run(async () =>
            {
                if(EmailPublisher.Config.Enabled)
                {
                    //await Email.SendGrid.SendContactInfo(e.EmailMsg);
                    await _email.Send(e.EmailMsg);
                }
                else
                {
                    Console.WriteLine($"SendGrid Services is not Enable. No Email was sent.");
                }

            });
        }
    }
}
