namespace FunCatFacts.Application.Interfaces
{
    public interface IFileAccessService
    {
        /// <summary>
        /// Appends given string into a text file in an asynchronous operation.
        /// Creates text file if it doesn't exist.
        /// </summary>
        /// <param name="text">Text to be added to file.</param>
        public Task WriteTextAsync(string text);

        /// <summary>
        /// Reads lines of characters from a file and returns the data as a list of strings.
        /// </summary>
        /// <param name="fileName">Name of the file to be read.</param>
        /// <returns>Lines of characters in a list.</returns>
        public List<string> ReadText();
    }
}