using System.Net.Http.Json;
using FunCatFacts.DTO;

namespace FunCatFacts.Services
{
    public class APIAccessService(HttpClient httpClient)
    {
        public async Task<FunFact?> GetFunFactAsync(CancellationToken ct = default)
        {
            try
            {
                FunFact? response = await httpClient.GetFromJsonAsync<FunFact>("https://catfact.ninja/fact", ct);

                return response;
            }
            catch
            {
                throw;
            }
            
        }
    }
}