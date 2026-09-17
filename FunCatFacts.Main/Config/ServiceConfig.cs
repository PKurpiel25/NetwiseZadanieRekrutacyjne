using FunCatFacts.Application.Interfaces;
using FunCatFacts.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FunCatFacts.Main.Config
{
    public static class ServiceConfig
    {
        extension(IServiceCollection services)
        {
            public void ConfigureServices()
            {
                // Binding APIAccessService with HttpClient and registering it in the service collection
                services.AddHttpClient<IAPIAccessService, APIAccessService>("FunCatFacts");

                services.AddScoped<IFileAccessService, FileAccessService>();

                services.AddScoped<IFunFactService, FunFactService>();
            }
        }
    }
}