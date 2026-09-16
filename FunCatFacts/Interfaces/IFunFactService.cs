namespace FunCatFacts.Interfaces
{
    public interface IFunFactService
    {
        public Task<string?> GetFunFactAsync();
        public void ReadFunFacts();
    }
}