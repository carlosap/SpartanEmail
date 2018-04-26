
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
namespace SpartanEmail
{
    public class Email : IEmail
    {
        private string _key;
        public Email(string sendGridKey)
        {
            _key = sendGridKey;
        }

        public async Task Send(EmailMessage email)
        {
            if (!string.IsNullOrWhiteSpace(_key))
            {
                var sg = new SendGridClient(_key);
                var from = new EmailAddress(email.FromEmail, email.FromEmailName);
                var to = new EmailAddress(email.EmailAddress, email.Name);
                var plainTextContent = email.Message;
                var subject = email.Subject;
                var htmlContent = "";
                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                await sg.SendEmailAsync(msg);
            }

        }
    }
}
