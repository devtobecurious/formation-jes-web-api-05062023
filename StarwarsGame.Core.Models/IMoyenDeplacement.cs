namespace StarwarsGame.Core.Models
{
    public interface IMoyenDeplacement
    {
        void Deplacer();

        void Freiner()
        {
            Console.WriteLine("Je freine");
        }
    }
}
