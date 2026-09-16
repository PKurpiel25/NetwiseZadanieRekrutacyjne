using FunCatFacts.DTO;

namespace FunCatFacts.Interfaces
{
    public interface IAPIAccessService
    {
        public Task<FunFact?> GetFunFactAsync(CancellationToken ct = default);
    }
}