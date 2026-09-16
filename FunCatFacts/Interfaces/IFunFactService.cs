namespace FunCatFacts.Interfaces
{
    public interface IFunFactService
    {
        public Task DownloadFunFactAsync();
        public void ReadFunFacts();
    }
}