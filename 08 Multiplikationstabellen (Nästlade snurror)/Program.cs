for (int i = 1; i <= 5 ; i++)
{
    for (int j = 1; j <= 5; j++)
    {
        // Trimma och snygga till formateringen
        Console.Write((i * j).ToString().PadLeft(6));
        //Console.Write((i * j)+ "\t");
    }
    Console.WriteLine();    // Ny rad efter varje rad i tabellen
}






Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey(); Console.WriteLine("Hello, World!");
