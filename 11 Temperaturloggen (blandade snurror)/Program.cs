double[] temperaturer = { 12.5, 14.2, 18.9, 15.1, 11.4, 9.8, -7.2, -11.6, 25.0 };
double summa = 0;
double högsta = temperaturer[0];
int antalVärden = temperaturer.Length;
//int räknare = 1;

foreach (var temp in temperaturer)
{
    summa += temp;
    //räknare++;
    if (temp > högsta)
    {
        högsta = temp;
    }
}

double medelVärde = summa / antalVärden;

Console.WriteLine($"Medeltemperatur: {medelVärde:F1} grader");
Console.WriteLine($"Högsta temperatur: {högsta:F1} grader");








Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey(); Console.WriteLine("Hello, World!");
