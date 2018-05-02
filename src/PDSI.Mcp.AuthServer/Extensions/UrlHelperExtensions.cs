using PDSI.Mcp.AuthServer.Controllers;

namespace Microsoft.AspNetCore.Mvc
{
    public static class UrlHelperExtensions
    {
        public static System.String EmailConfirmationLink(this IUrlHelper urlHelper, System.String userId, System.String code, System.String scheme)
        {
            return urlHelper.Action(
                action: nameof(AccountController.ConfirmEmail),
                controller: "Account",
                values: new { userId, code },
                protocol: scheme);
        }

        public static System.String ResetPasswordCallbackLink(this IUrlHelper urlHelper, System.String userId, System.String code, System.String scheme)
        {
            return urlHelper.Action(
                action: nameof(AccountController.ResetPassword),
                controller: "Account",
                values: new { userId, code },
                protocol: scheme);
        }
    }
}
