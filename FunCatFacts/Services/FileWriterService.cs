namespace FunCatFacts.Services
{
    public static class FileWriterService
    {
        /// <summary>
        /// Appends given string into a text file in an asynchronous operation.
        /// Creates text file if it doesn't exist.
        /// </summary>
        /// <param name="text">Text to be added to file.</param>
        /// <returns></returns>
        public static async Task WriteTextToFileAsync(string text)
        {
            // Creating StreamWriter object with appending set to true
            using StreamWriter streamWriter = new("FunCatFacts.txt", true);

            await streamWriter.WriteLineAsync(text);
        }
    }
}