namespace FunCatFacts.Interfaces
{
    public interface IFileAccessService
    {
        public Task WriteTextAsync(string text);
        public List<string> ReadText();
    }
}