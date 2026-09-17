using FunCatFacts.Application.DTO;
using FunCatFacts.Application.Interfaces;

namespace FunCatFacts.Infrastructure.Services
{
    /// <summary>
    /// Handles downloading, saving to and reading from a file, cat facts from an external API.
    /// </summary>
    /// <param name="apiAccessService">Service that handles accessing the external API.</param>
    /// <param name="fileAccessService">Service that handles reading and writing data from/to text files.</param>
    public class FunFactService(IAPIAccessService apiAccessService,
    IFileAccessService fileAccessService) : IFunFactService
    {
        /// <summary>
        /// Downloads, saves to a file and then returns a cat fact from an external API.
        /// </summary>
        /// <returns>Downloaded cat fact or null.</returns>
        public async Task<string?> GetFunFactAsync()
        {
            FunFact? funFact = await apiAccessService.GetFunFactAsync();

            if(funFact != null)
            {
                var result = funFact.ToString();

                await fileAccessService.WriteTextAsync(result);

                return result;
            }
            else
            {
                Console.WriteLine("Download failed!");

                return null;
            }
        }

        /// <summary>
        /// Prints to the console all saved cat facts.
        /// </summary>
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