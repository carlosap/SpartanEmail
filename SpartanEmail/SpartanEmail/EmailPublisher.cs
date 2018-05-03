
namespace SpartanEmail
{
    public class EmailPublisher
    {
        public static EmailMessageEvent EmailMessageEvent { get; set; }
        private static EmailMessageService EmailMessageService { get; set; }
        public static Config Config { get; set; }
        public EmailPublisher()
        {
            Config = new Config();
            EmailMessageEvent = new EmailMessageEvent();
            EmailMessageService = new EmailMessageService();
            
            //Reg. Subscribers
            EmailMessageEvent.EmailMsgSendEvent += EmailMessageService.OnSendEmailEvent;

        }
    }
}
