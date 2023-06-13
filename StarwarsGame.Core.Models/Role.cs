namespace StarwarsGame.Core.Models
{
    public record Role
    {
        public int Id { get; set; }

        public string? Label { get; set; }

        public List<Wookiee> Wookiees { get; set; } = new();
    }
}
