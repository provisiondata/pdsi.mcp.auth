using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PDSI.Mcp.AuthServer.ViewModels.Authorization
{
    public class LogoutViewModel
    {
        [BindNever]
        public System.String RequestId { get; set; }
    }
}
