int giltigtTal = 0;
//bool lyckades = false;
bool lyckades;

do
//while (lyckades == false)
//while (!lyckades)
{
    Console.Write("Ange ett heltal: ");
    string inmatning = Console.ReadLine();

    if (int.TryParse(inmatning, out giltigtTal))
    {
        lyckades = true;
    }
    else
    {
        Console.WriteLine("Felaktig inmatning. Det där var inte ett heltal!");
        lyckades = false;
    }
}
while (!lyckades);

Console.WriteLine($"Tack! Du matade in talet: {giltigtTal}");






#region Extrarader
Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey(); Console.WriteLine("Hello, World!");
#endregion