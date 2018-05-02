using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PDSI.Mcp.AuthServer.ViewModels.Account
{
    public class SendCodeViewModel
    {
        public System.String SelectedProvider { get; set; }

        public ICollection<SelectListItem> Providers { get; set; }

        public System.String ReturnUrl { get; set; }

        public System.Boolean RememberMe { get; set; }
    }
}
