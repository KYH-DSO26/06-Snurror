string[] filer = { ".config", "index.html", ".git", "styles.css", "main.cs" };

foreach (var fil in filer)
{
    if (fil.StartsWith("."))
    {
        continue;   // Hoppar direkt till nästa fil i loopen
    }
    Console.WriteLine($"Synlig fil: {fil}");
}







Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey(); Console.WriteLine("Hello, World!");
