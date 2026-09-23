string[] ryggsäck = { "Rep", "Ficklampa", "Guld", "Karta", "Kompass" };

foreach (var sak in ryggsäck)
{
    Console.WriteLine($"Tittar på: {sak}");
    if (sak == "Guld")
    {
        Console.WriteLine("Hittade guld!");
        break;      // Avbryter loopen omedelbart
        //continue;     // Fortsätter med nästa varv i loopen
    }
}




Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey(); Console.WriteLine("Hello, World!");
