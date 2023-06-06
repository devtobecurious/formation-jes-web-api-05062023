namespace StarwarsGame.Core.Models.Enemies
{
    public enum TypeEnemy
    {
        Mechanimal,
        Droide,
        Mecha
    }

    /// <summary>
    /// Un ennemi
    /// </summary>
    public class Enemy
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public TypeEnemy Type { get; set; }

        public Position2D Position { get; set; } = new(0, 0);

        public Weapon? Weapon { get; set; }
    }
}