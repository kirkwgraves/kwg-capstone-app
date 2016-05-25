using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

public class Startup
{
    //public static IConfigurationRoot Configuration { get; set; }

    //public Startup(IHostingEnvironment env)
    //{
    //    // Set up configuration sources.

    //    var builder = new ConfigurationBuilder()
    //        .AddJsonFile("appsettings.json")
    //        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
    //        .AddEnvironmentVariables();

    //    if (env.IsDevelopment())
    //    {
    //        // For more details on using the user secret store see /*http://go.microsoft.com/fwlink/?LinkID=532709*/
    //builder.AddUserSecrets();

    //        // This will push telemetry data through Application Insights pipeline faster, allowing you to view results immediately.
    //        builder.AddApplicationInsightsSettings(developerMode: true);
    //    }

    //    builder.AddEnvironmentVariables();
    //    Configuration = builder.Build();
    //}


    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();

    }


    public static void Main(string[] args) => WebApplication.Run(args);
}
