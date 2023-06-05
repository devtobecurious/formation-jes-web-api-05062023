namespace StarwarsGame.Core.Models
{
    public abstract class Vehicle : IMoyenDeplacement
    {
        protected readonly Afficher afficher;

        //public Vehicle(Action<string?> afficher)
        public Vehicle(Afficher afficher)
        {
            this.afficher = afficher;
        }

        public int Id { get; init; }

        public string? Name { get; set; }

        protected void DetecterTrou()
        {
            this.afficher?.Invoke("Oops un trou");
        }

        public abstract void Deplacer();

        void IMoyenDeplacement.Freiner()
        {

        }
    }
}
