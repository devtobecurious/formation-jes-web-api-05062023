// See https://aka.ms/new-console-template for more information
using StarwarsGame.Core.Models;

Console.WriteLine($"Hello, World! {args[0]}");

var wookiee = new Wookiee("Chewie", 10000000);
Wookiee wookiee1 = new();


List<Wookiee> list = new()
{
    wookiee,
    new(),
    new("Chemmia", 0)
};

//

// Delegue rappels
Afficher afficher = Console.WriteLine;
afficher("Coucou");

void Calculer(Afficher afficher)
{
    afficher($"{1} + {2} = {3}");
}

Calculer(Console.WriteLine);
Calculer(afficher);

void AfficherEnVert(string? mess)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(mess);
    Console.ForegroundColor = ConsoleColor.White;
}

Calculer(AfficherEnVert);

Calculer(messageuuuh =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(messageuuuh);
    Console.ForegroundColor = ConsoleColor.White;
});
var afficherL = (string? messageuuuh) =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(messageuuuh);
    Console.ForegroundColor = ConsoleColor.White;
};

// Calculer(afficherL);

