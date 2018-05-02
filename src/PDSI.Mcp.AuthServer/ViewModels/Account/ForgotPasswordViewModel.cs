using System.ComponentModel.DataAnnotations;

namespace PDSI.Mcp.AuthServer.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public System.String Email { get; set; }
    }
}
