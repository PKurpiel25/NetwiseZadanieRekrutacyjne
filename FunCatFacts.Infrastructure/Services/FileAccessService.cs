using FunCatFacts.Application.Interfaces;

namespace FunCatFacts.Infrastructure.Services
{
    /// <summary>
    /// Handle reading and writing from/to text files.
    /// </summary>
    public class FileAccessService() : IFileAccessService
    {
        private readonly string fileName = "FunCatFacts.txt";

        /// <summary>
        /// Appends given string into a text file in an asynchronous operation.
        /// Creates text file if it doesn't exist.
        /// </summary>
        /// <param name="text">Text to be added to file.</param>
        public async Task WriteTextAsync(string text)
        {
            // Creates StreamWriter object with appending set to true
            using StreamWriter streamWriter = new(fileName, true);

            await streamWriter.WriteLineAsync(text);
        }

        /// <summary>
        /// Reads lines of characters from a file and returns the data as a list of strings.
        /// </summary>
        /// <param name="fileName">Name of the file to be read.</param>
        /// <returns>Lines of characters in a list.</returns>
        public List<string> ReadText()
        {
            List<string> text = [];

            using StreamReader streamReader = new(fileName);

            string? line;

            // Reads a line of text until there aren't any
            while ((line = streamReader.ReadLine()) != null)
            {
                text.Add(line);
            }

            return text;
        }
    }
}