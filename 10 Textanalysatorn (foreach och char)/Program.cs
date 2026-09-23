Console.Write("Skriv en mening: ");
var mening = Console.ReadLine();
int mellanslagRäknare = 0;

// Snurra igenom hela strängen, ett tecken i taget
foreach (var tecken in mening)
{
    if (tecken == ' ')
    {
        mellanslagRäknare++;
    }
}

Console.WriteLine($"Meningen innehåller {mellanslagRäknare} stycken mellanslag");







Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey(); Console.WriteLine("Hello, World!");
