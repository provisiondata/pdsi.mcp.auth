using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace PDSI.Mcp.AuthServer
{
    public class Program
    {
        public static void Main(System.String[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(System.String[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
