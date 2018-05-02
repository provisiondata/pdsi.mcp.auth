using System.ComponentModel.DataAnnotations;

namespace PDSI.Mcp.AuthServer.ViewModels.Manage
{
    public class VerifyPhoneNumberViewModel
    {
        [Required]
        public System.String Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public System.String PhoneNumber { get; set; }
    }
}
