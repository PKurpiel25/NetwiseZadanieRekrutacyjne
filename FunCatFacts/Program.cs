using FunCatFacts.DTO;
using FunCatFacts.Services;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new();

services.AddHttpClient<APIAccessService>("FunCatFacts");

var provider = services.BuildServiceProvider();

var apiAccess = provider.GetRequiredService<APIAccessService>();

FunFact? funFact = await apiAccess.GetFunFactAsync();

if(funFact != null)
{
    Console.WriteLine(funFact);

    await FileWriterService.WriteTextToFileAsync(funFact.ToString());
}
else
{
    Console.WriteLine("No fun fact to show!");
}

Console.WriteLine("Press any key to close.");
    
Console.ReadKey();