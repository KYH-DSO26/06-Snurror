// Simulerar bit-flaggor: Bit 0 = Ström, Bit 1 = Motor igång, Bit 2 = Varning
byte statusFlaggor = 0b0000_0101; // Ström (1) och Varning (4) är aktiva

for (int bit = 0; bit < 8; bit++)
{
    // Kontrollera om biten är satt med bitvis AND (&) och skift-operator (<<)
    int mask = 1 << bit;
    bool ärSatt = (statusFlaggor & mask) != 0;
    if (!ärSatt) continue; // Hoppa över om flaggan inte är aktiv
    Console.WriteLine($"Status: Flagga på bit-position {bit} är AKTIV.");
}






#region Extrarader
Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
#endregion