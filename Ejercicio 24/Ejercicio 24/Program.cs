Console.WriteLine("Ingrese un número. ");
Console.WriteLine();
int numero=int.Parse(Console.ReadLine());
Console.WriteLine();
while (numero<=100)
{
    Console.Write($"{numero} ");
    numero += 5;
}
Console.WriteLine();
