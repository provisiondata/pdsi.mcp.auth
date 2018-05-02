using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PDSI.Mcp.AuthServer.ViewModels.Manage
{
    public class ConfigureTwoFactorViewModel
    {
        public System.String SelectedProvider { get; set; }

        public ICollection<SelectListItem> Providers { get; set; }
    }
}
