using FunCatFacts.Application.DTO;

namespace FunCatFacts.Application.Interfaces
{
    public interface IAPIAccessService
    {
        public Task<FunFact?> GetFunFactAsync(CancellationToken ct = default);
    }
}