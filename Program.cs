using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


/// <summary>
/// The entry point of the application.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method, the entry point of the application.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    /// <summary>
    /// Creates and configures the host builder.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    /// <returns>An IHostBuilder configured for the application.</returns>
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}
