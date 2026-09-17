using FunCatFacts.Config;
using FunCatFacts.Interfaces;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new();

services.ConfigureServices();

// Creating service provider object
var provider = services.BuildServiceProvider();

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

            if(fact != null)
            {
                Console.WriteLine(fact);
            }
            
            break;
        case "2":
            funFactService.ReadFunFacts();
            break;
        case "3":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Wrong input! Return to begin.");
            break;
    }
}
