using System.Threading.Tasks;

namespace PDSI.Mcp.AuthServer.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(System.String email, System.String subject, System.String message)
        {
            return Task.CompletedTask;
        }
    }
}
