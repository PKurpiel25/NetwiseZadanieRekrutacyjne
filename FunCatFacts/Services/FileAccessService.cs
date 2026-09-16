using FunCatFacts.Interfaces;

namespace FunCatFacts.Services
{
    /// <summary>
    /// Handle reading and writing from/to text files.
    /// </summary>
    public class FileAccessService(string fileName) : IFileAccessService
    {
        /// <summary>
        /// Appends given string into a text file in an asynchronous operation.
        /// Creates text file if it doesn't exist.
        /// </summary>
        /// <param name="text">Text to be added to file.</param>
        /// <returns></returns>
        public async Task WriteTextAsync(string text)
        {
            // Creating StreamWriter object with appending set to true
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

            // Read a line of text until there arent' any
            while ((line = streamReader.ReadLine()) != null)
            {
                text.Add(line);
            }

            return text;
        }
    }
}