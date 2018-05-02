using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PDSI.Mcp.AuthServer.ViewModels.Authorization
{
    public class AuthorizeViewModel
    {
        [Display(Name = "Application")]
        public System.String ApplicationName { get; set; }

        [BindNever]
        public System.String RequestId { get; set; }

        [Display(Name = "Scope")]
        public System.String Scope { get; set; }
    }
}
