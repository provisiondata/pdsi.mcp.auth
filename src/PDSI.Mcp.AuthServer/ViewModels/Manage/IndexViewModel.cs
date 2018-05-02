using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace PDSI.Mcp.AuthServer.ViewModels.Manage
{
    public class IndexViewModel
    {
        public System.Boolean HasPassword { get; set; }

        public IList<UserLoginInfo> Logins { get; set; }

        public System.String PhoneNumber { get; set; }

        public System.Boolean TwoFactor { get; set; }

        public System.Boolean BrowserRemembered { get; set; }
    }
}
