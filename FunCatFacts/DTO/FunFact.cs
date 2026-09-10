namespace FunCatFacts.DTO
{
    public sealed class FunFact()
    {
        public string Fact { get; set; } = string.Empty;

        public int Length { get; set; }

        public override string ToString()
        {
            return $"{nameof(Fact)}: {Fact} {nameof(Length)}: {Length}";
        }
    }
}