using System;
using System.Threading.Tasks;

namespace PDSI.Mcp.AuthServer.Services
{
    public class SmsSender : ISmsSender
    {
        public Task SendSmsAsync(String number, String message)
        {
            return Task.CompletedTask;
        }
    }
}
