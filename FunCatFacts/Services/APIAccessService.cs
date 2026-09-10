using System.Net.Http.Json;
using FunCatFacts.DTO;

namespace FunCatFacts.Services
{
    /// <summary>
    /// Class that handles sending requests to web APIs.
    /// </summary>
    /// <param name="httpClient">Handles HTTP requests and responses. Created by dependency injection.</param>
    public class APIAccessService(HttpClient httpClient)
    {
        /// <summary>
        /// Fetches data from the Cat Fact API in an asychronous operation.
        /// </summary>
        /// <param name="ct">Propagates notification that operations should be canceled.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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