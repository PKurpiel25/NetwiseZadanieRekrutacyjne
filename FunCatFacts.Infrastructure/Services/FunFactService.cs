using FunCatFacts.Application.DTO;
using FunCatFacts.Application.Interfaces;

namespace FunCatFacts.Infrastructure.Services
{
    public class FunFactService(IAPIAccessService apiAccessService,
    IFileAccessService fileAccessService) : IFunFactService
    {
        public async Task<string?> GetFunFactAsync()
        {
            // Fetching data from external API
            FunFact? funFact = await apiAccessService.GetFunFactAsync();

            if(funFact != null)
            {
                var result = funFact.ToString();

                // Saving data in a text file
                await fileAccessService.WriteTextAsync(result);

                return result;
            }
            else
            {
                Console.WriteLine("Download failed!");

                return null;
            }
        }

        public void ReadFunFacts()
        {
            var facts = fileAccessService.ReadText();

            if(facts.Count > 0)
            {
                foreach (var fact in facts)
                {
                    Console.WriteLine(fact);
                }
            }
        }
    }
}