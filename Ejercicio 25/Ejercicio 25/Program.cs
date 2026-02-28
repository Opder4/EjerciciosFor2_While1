int opcion = 0;
while (opcion!=3)
{
    Console.WriteLine(" Menú ");
    Console.WriteLine();
    Console.WriteLine("1. Salduo");
    Console.WriteLine("2. Consejo");
    Console.WriteLine("3. Salir");
    Console.WriteLine();
    opcion = int.Parse(Console.ReadLine());
    Console.WriteLine();
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Hola");
            break;
        case 2:
            Console.WriteLine("Sigue adelante");
            break;
        case 3:
                Console.WriteLine("Saliendo");
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }
    Console.WriteLine();
    Console.ReadLine();
    Console.Clear();
}
Console.WriteLine("Programa finalizado");