namespace FunCatFacts.Application.Interfaces
{
    public interface IFunFactService
    {
        /// <summary>
        /// Downloads, saves to a file and then returns a cat fact from an external API.
        /// </summary>
        /// <returns>Downloaded cat fact or null.</returns>
        public Task<string?> GetFunFactAsync();

        /// <summary>
        /// Prints to the console all saved cat facts.
        /// </summary>
        public void ReadFunFacts();
    }
}