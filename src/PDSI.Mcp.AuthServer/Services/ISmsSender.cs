using System.Threading.Tasks;

namespace PDSI.Mcp.AuthServer.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(System.String number, System.String message);
    }
}
