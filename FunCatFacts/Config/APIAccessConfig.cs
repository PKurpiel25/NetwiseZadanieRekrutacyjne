using FunCatFacts.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FunCatFacts.Config
{
    public static class APIAccessConfig
    {
        public static APIAccessService GetAPIAccessService()
        {
            // Creating service collection object
            ServiceCollection services = new();

            // Binding APIAccessService with HttpClient and registering it in the service collection
            services.AddHttpClient<APIAccessService>("FunCatFacts");

            // Creating service provider object
            var provider = services.BuildServiceProvider();

            // Using the service provider to get APIAccessService object
            return provider.GetRequiredService<APIAccessService>();
        }
    }
}