int contador = 0;
int resta = 1;
Console.WriteLine("Ingrese un número: ");
Console.WriteLine();
int numero=int.Parse(Console.ReadLine());
int numeroreferencia = numero;
Console.WriteLine();
while (numero>=0)
{
    numero = numeroreferencia - resta;
    resta = resta * 10;
    if (numero>=0 || numero==-1)
    {
        contador = contador + 1;
    }
}

Console.WriteLine($"El número tiene {contador} dígitos");