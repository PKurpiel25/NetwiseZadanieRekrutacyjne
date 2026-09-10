using FunCatFacts.DTO;
using FunCatFacts.Services;
using Microsoft.Extensions.DependencyInjection;

// Creating service collection object
ServiceCollection services = new();

// Binding APIAccessService with HttpClient and registering it in the service collection
services.AddHttpClient<APIAccessService>("FunCatFacts");

// Creating service provider object
var provider = services.BuildServiceProvider();

// Using the service provider to get APIAccessService object
var apiAccess = provider.GetRequiredService<APIAccessService>();

// Fecthing data from external API
FunFact? funFact = await apiAccess.GetFunFactAsync();

if(funFact != null)
{
    Console.WriteLine(funFact);

    // Saving data in a text file
    await FileWriterService.WriteTextToFileAsync(funFact.ToString());
}
else
{
    Console.WriteLine("No fun fact to show!");
}

Console.WriteLine("Press any key to close.");
    
Console.ReadKey();