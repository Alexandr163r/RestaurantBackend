namespace RestaurantBackend.Web
{
    using System.IO;
    using System.Text;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Hosting;
    
    public class Program
    {
        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(
                (hostingContext, builder) =>
                {
                    builder
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", false, true)
                        .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", true,
                            true)
                        .AddEnvironmentVariables();
                    
                    builder.AddEnvironmentVariables();
                    if (hostingContext.HostingEnvironment.IsDevelopment() &&
                        hostingContext.HostingEnvironment.EnvironmentName != "SUT")
                    {
                        // builder.AddUserSecrets<Program>();
                    }
                })
            .ConfigureWebHostDefaults(
                webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseUrls(new[] { "http://localhost:5000" });
                    webBuilder.ConfigureKestrel(
                        options => { options.AddServerHeader = false; });
                });

        public static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            CreateHostBuilder(args).Build().Run();
        }
    }
}