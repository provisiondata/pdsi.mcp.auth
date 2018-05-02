using System.ComponentModel.DataAnnotations;

namespace PDSI.Mcp.AuthServer.ViewModels.Account
{
    public class VerifyCodeViewModel
    {
        [Required]
        public System.String Provider { get; set; }

        [Required]
        public System.String Code { get; set; }

        public System.String ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public System.Boolean RememberBrowser { get; set; }

        [Display(Name = "Remember me?")]
        public System.Boolean RememberMe { get; set; }
    }
}
