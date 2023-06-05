namespace StarwarsGame.Core.Models
{
    public class Weapon
    {
        public Weapon() : this(0, "")
        {

        }

        public Weapon(int id, string label)
        {
            this.Id = id;
            this.Label = label;
        }

        public int Id { get; init; }

        public string Label { get; set; } = "";

        public bool IsMain { get; set; } = false;
    }
}
