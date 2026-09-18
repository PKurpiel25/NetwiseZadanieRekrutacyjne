using FunCatFacts.Application.Interfaces;
using FunCatFacts.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FunCatFacts.Main.Config
{
    /// <summary>
    /// Extension class for configurating services.
    /// </summary>
    public static class ServiceConfig
    {
        extension(IServiceCollection services)
        {
            /// <summary>
            /// Registers services in the service collection.
            /// </summary>
            public void ConfigureServices()
            {
                // Registers APIAccessService as a service that uses HTTPClient
                services.AddHttpClient<IAPIAccessService, APIAccessService>("FunCatFacts");

                services.AddScoped<IFileAccessService, FileAccessService>();

                services.AddScoped<IFunFactService, FunFactService>();
            }
        }
    }
}