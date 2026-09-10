namespace FunCatFacts.Services
{
    public static class FileWriterService
    {
        public static async Task WriteTextToFileAsync(string text, CancellationToken ct = default)
        {
            using StreamWriter streamWriter = new("FunCatFacts.txt", true);

            await streamWriter.WriteLineAsync(text);
        }
    }
}