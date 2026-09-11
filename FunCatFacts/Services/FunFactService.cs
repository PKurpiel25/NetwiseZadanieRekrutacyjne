using FunCatFacts.Config;
using FunCatFacts.DTO;

namespace FunCatFacts.Services
{
    public class FunFactService()
    {
        private readonly APIAccessService APIAccess =
        APIAccessConfig.GetAPIAccessService();

        private readonly FileAccessService fileAccessService =
        new("FunCatFacts.txt");

        public async Task DownloadFunFactAsync()
        {
            // Fetching data from external API
            FunFact? funFact = await APIAccess.GetFunFactAsync();

            if(funFact != null)
            {
                // Saving data in a text file
                await fileAccessService.WriteTextAsync(funFact.ToString());

                Console.WriteLine("Download complete.");
            }
            else
            {
                Console.WriteLine("Download failed!");
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