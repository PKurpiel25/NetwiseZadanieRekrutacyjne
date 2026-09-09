using System.Net.Http.Json;

namespace FunCatFacts
{
    public class APIAccess(HttpClient httpClient)
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