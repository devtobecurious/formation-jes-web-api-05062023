namespace StarwarsGame.Core.Models;

public class MotoJet : Vehicle
{
    public MotoJet(Afficher afficher) : base(afficher)
    {
    }

    public override void Deplacer()
    {

        // Afficher
        this.afficher("Vroom je suis une moto");
    }
}

public class Leia : IMoyenDeplacement
{
    public void Deplacer()
    {
        Console.WriteLine("Je vole Fuck yeah (SW 8)");
    }
}

