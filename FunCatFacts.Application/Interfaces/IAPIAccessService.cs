using FunCatFacts.Application.DTO;

namespace FunCatFacts.Application.Interfaces
{
    public interface IAPIAccessService
    {
        /// <summary>
        /// Fetches data from the Cat Fact API in an asychronous operation.
        /// </summary>
        /// <param name="ct">Propagates notification that operations should be canceled.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<FunFact?> GetFunFactAsync(CancellationToken ct = default);
    }
}