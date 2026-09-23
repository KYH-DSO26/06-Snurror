string input = "AAABBBCCDAA";
if (string.IsNullOrEmpty(input)) return;

string resultat = "";
int antal = 1;

for (int i = 0; i < input.Length; i++)
{
    // Om nästa tecken är samma, öka räknaren
    if (i + 1 < input.Length && input[i] == input[i + 1])
    {
        antal++;
    }
    else
    {
        // Annars, lägg till tecken och antal i resultatet och nollställ räknaren
        resultat += input[i].ToString() + antal;
        antal = 1;
    }
}
Console.WriteLine($"Komprimerad text: {resultat}");







#region Extrarader
Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
#endregion