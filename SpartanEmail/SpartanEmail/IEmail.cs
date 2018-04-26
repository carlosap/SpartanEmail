using System.Threading.Tasks;
namespace SpartanEmail
{
    public interface IEmail
    {
        Task Send(EmailMessage email);
    }
}
