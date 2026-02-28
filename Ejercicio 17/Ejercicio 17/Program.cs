int numero = 1;
int suma = 0;
Console.WriteLine("Presione 0 para terminar");
while (numero!=0)
{
    Console.WriteLine();
    Console.WriteLine("Ingrese un número");
    Console.WriteLine();
    numero=int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (numero>0)
    {
        suma += 1;
    }
}
Console.WriteLine();
Console.WriteLine("Usted salio");
Console.WriteLine();
Console.WriteLine($"La cantidad de números positivos que ingreso son {suma}");