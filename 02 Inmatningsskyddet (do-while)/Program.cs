string lösenord;
do
{
    Console.Write("Ange lösenord: ");
    lösenord = Console.ReadLine();
    if (lösenord != "hemligt")
    {
        Console.WriteLine("Fel lösenord! Försök igen.");
    }
}
while (lösenord != "hemligt");

Console.WriteLine("Rätt! Du är inloggad.");





Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();