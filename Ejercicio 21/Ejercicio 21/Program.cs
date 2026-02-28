int suma = 0;
while (suma<=100)
{
    Console.WriteLine("Ingrese un número para sumar: ");
    Console.WriteLine();
    int numero=int.Parse(Console.ReadLine());
    Console.WriteLine();
    suma += numero;
}
Console.WriteLine("La suma llegó al límite de 100");