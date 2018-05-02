using System.Threading.Tasks;

namespace PDSI.Mcp.AuthServer.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(System.String email, System.String subject, System.String message);
    }
}
