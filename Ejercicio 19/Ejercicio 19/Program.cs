int multiplo = 1;
Console.WriteLine();
Console.WriteLine("Ingrese un número");
Console.WriteLine();
int numero=int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Tabla del {numero}");
Console.WriteLine();
while (multiplo<=10)
{
    Console.WriteLine($"{numero} X {multiplo} = {numero*multiplo}");
    multiplo++;
}