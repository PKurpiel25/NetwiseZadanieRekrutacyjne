namespace FunCatFacts.Application.DTO
{
    /// <summary>
    /// Data Transfer Object used to map JSON data from the Cat Fact API.
    /// </summary>
    public class FunFact()
    {
        /// <summary>
        /// Contents of the fact.
        /// </summary>
        public string Fact { get; set; } = string.Empty;

        /// <summary>
        /// Amount of character making up the fact.
        /// </summary>
        public int Length { get; set; }

        public override string ToString()
        {
            return $"{nameof(Fact)}: {Fact} {nameof(Length)}: {Length}";
        }
    }
}