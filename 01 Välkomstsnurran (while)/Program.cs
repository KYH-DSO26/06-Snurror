string svar = "ja";
while (svar.ToLower() == "ja" || svar.ToLower() == "j")
{
    Console.WriteLine("Snurrar vidare...");
    Console.Write("Vill du fortsätta? (ja/nej): ");
    svar = Console.ReadLine();
    if (svar.ToLower() != "ja" && svar.ToLower() != "nej")
    {
        Console.WriteLine("Svara ja eller nej!");
        svar = "ja";
    }

}

Console.WriteLine("Programmet avslutat. Hejdå!");







Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();