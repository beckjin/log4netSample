using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureLogging((logging) =>
            {
                logging.AddFilter("System", LogLevel.Warning);
                logging.AddFilter("Microsoft", LogLevel.Warning);
                logging.AddLog4Net();
            })
            .UseStartup<Startup>();
    }
}
