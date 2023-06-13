using System.ComponentModel.DataAnnotations;

namespace Starwarsgame.Core.Games.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        public string Titre { get; set; } = string.Empty;

        public DateTime CreationDate { get; set; }

        public bool EstEnSucces { get; set; }

        public IEnumerable<WookieSaveData> WookieSaveDatas { get; set; } = new List<WookieSaveData>();
    }
}
