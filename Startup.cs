using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

/// <summary>
/// Configures the services and the application's request pipeline.
/// </summary>
public class Startup
{
    /// <summary>
    /// Configures the services that the application will use.
    /// </summary>
    /// <param name="services">The service collection to add services to.</param>
    public void ConfigureServices(IServiceCollection services)
    {
        // Registration of Services
        services.AddControllers();
        services.AddSingleton<IItemService, ItemService>();
        services.AddSingleton<IProductService, ProductService>();
    }

    /// <summary>
    /// Configures the HTTP request pipeline.
    /// </summary>
    /// <param name="app">An IApplicationBuilder instance used to configure the request pipeline.</param>
    /// <param name="env">Provides information about the web hosting environment.</param>
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            // Maps controller routes
            endpoints.MapControllers();
        });
    }
}
