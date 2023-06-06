using RappelStructDecouverteRecord;

// C'est class :D
//Position2DC positionC1 = new() { X = 1, Y = 1 };
//Position2DC positionC2 = new() { X = 1, Y = 1 };
//Position2DC positionC3 = positionC1;

// C'est struct
//Position2DS positionC1 = new() { X = 1, Y = 1 };
//Position2DS positionC2 = new() { X = 1, Y = 1 };
//Position2DS positionC3 = positionC1;

// C'est record
Position2DR positionC1 = new(1, 1);
Position2DR positionC2 = new(1, 1);
Position2DR positionC3 = positionC1;



// positionC3.X = 2;

bool exact = positionC1 == positionC2;

Console.WriteLine(positionC1.X);
Console.WriteLine(positionC2.X);
Console.WriteLine(positionC3.X);

Console.WriteLine("FIN DU JEU");