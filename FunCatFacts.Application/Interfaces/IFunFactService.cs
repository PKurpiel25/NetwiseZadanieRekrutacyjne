namespace FunCatFacts.Application.Interfaces
{
    public interface IFunFactService
    {
        public Task<string?> GetFunFactAsync();
        public void ReadFunFacts();
    }
}