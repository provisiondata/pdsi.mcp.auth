using System.ComponentModel.DataAnnotations;

namespace PDSI.Mcp.AuthServer.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public System.String Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public System.String Password { get; set; }

        [Display(Name = "Remember me?")]
        public System.Boolean RememberMe { get; set; }
    }
}
