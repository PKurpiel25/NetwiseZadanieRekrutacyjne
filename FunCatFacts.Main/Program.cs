using FunCatFacts.Application.Interfaces;
using FunCatFacts.Main.Config;
using Microsoft.Extensions.DependencyInjection;

// Creates a service collection object
ServiceCollection services = new();

services.ConfigureServices();

// Creates a service provider object
var provider = services.BuildServiceProvider();

// Gets concrete implementation of IFunFactService
var funFactService = provider.GetRequiredService<IFunFactService>();

while(true)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("1) Download fun cat fact.");
    Console.WriteLine("2) See downloaded facts.");
    Console.WriteLine("3) End program.");

    var choice = Console.ReadLine();

    switch(choice)
    {
        case "1":
            var fact = await funFactService.GetFunFactAsync();

            // Writes the returned fact to the console if it exists
            if(fact != null)
            {
                Console.WriteLine(fact);
            }
            
            break;
        case "2":
            funFactService.ReadFunFacts();
            break;
        case "3":
            // Safely closes the application.
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Wrong input! Return to begin.");
            break;
    }
}
