while (true)
{
    Console.WriteLine("\n--- MENY ---");
    Console.WriteLine("1. Visa profil");
    Console.WriteLine("2. Ändra inställningar");
    Console.WriteLine("3. Avsluta");
    Console.Write("Ange ett alternativ: ");

    var val = Console.ReadLine();
    if (val == "1") Console.WriteLine("Visar profil...");
    else if (val == "2") Console.WriteLine("Öppnar inställningar");
    else if (val == "3")
    {
        Console.WriteLine("Aavslutar programmet...");
        break;      // Bryter oss ur den oändliga loopen
    }
    else Console.WriteLine("Ogiltigt val, försök igen.");
}







Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey(); Console.WriteLine("Hello, World!");
