int numero = 0;
for (int i = 1; i <= 4; i++)
{
    for (int z=1; z<=4; z++)
    {
        Console.Write($" {z+numero}");
    }
    Console.WriteLine();
    numero += 1;
}