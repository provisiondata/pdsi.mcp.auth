using System.ComponentModel.DataAnnotations;

namespace PDSI.Mcp.AuthServer.ViewModels.Shared
{
    public class ErrorViewModel
    {
        [Display(Name = "Error")]
        public System.String Error { get; set; }

        [Display(Name = "Description")]
        public System.String ErrorDescription { get; set; }
    }
}
