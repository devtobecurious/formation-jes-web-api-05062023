namespace Starwarsgame.Core.Games.Models
{
    public class WookieSaveData
    {
        public int Id { get; set; }

        public int LifePoint { get; set; }

        public Game? Game { get; set; }

        public int WookieId { get; set; }
    }
}
