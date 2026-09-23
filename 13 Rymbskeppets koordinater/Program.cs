Console.Write("Ange X-koordinat för skeppet (1-5): ");
int targetX = int.Parse(Console.ReadLine());
Console.Write("Ange Y-koordinat för skeppet (1-5): ");
int targetY = int.Parse(Console.ReadLine());

for (int y = 1; y <= 5; y++)
{
    for (int x = 1; x <= 5; x++)
    {
        if (x == targetX && y == targetY)
        {
            Console.Write("S ");
        }
        else
        { 
            Console.Write(". "); 
        }
    }
    Console.WriteLine();
}





#region Extrarader
Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey(); Console.WriteLine("Hello, World!");
#endregion