using System.Net.Http.Json;
using FunCatFacts.Application.DTO;
using FunCatFacts.Application.Interfaces;

namespace FunCatFacts.Infrastructure.Services
{
    /// <summary>
    /// Handles sending requests to web APIs.
    /// </summary>
    /// <param name="httpClient">Handles HTTP requests and responses.</param>
    public class APIAccessService(HttpClient httpClient) : IAPIAccessService
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
                // Sends a GET request and deserializes the JSON response into a FunFact object
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