using System.Numerics;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;
int cambiante = 1;
Console.WriteLine();
Console.WriteLine("Ingrese un número");
Console.WriteLine();
int numero = int.Parse(Console.ReadLine());
int numeroreferencia = numero;
Console.WriteLine();
while (numero>0 && cambiante<numeroreferencia)
{
    numero = numero*(numeroreferencia - cambiante);
    cambiante++;
}
Console.WriteLine($"El factorial es {numero}");