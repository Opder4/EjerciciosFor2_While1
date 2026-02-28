int numero = 0;
for (int i=1; i<=3; i++)
{
    Console.Write("|");
    for (int z=1;z<=3;z++)
    {
        Console.Write($" {z+numero }");
    }
    Console.WriteLine(" |");
    numero += 3;
}