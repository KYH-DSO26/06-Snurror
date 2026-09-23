for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
    Thread.Sleep(1000);      // Lite fördröjning för effekt
}

Console.WriteLine("\n\nGott nytt år!");






Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();