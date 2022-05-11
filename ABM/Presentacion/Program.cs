using Logica;

Console.WriteLine("Que desea hacer (1 = cargar nueva computadora, 2 = salir del programa): ");
int valor = int.Parse(Console.ReadLine());
while (valor == 1)
{
    Console.WriteLine("Procesador (INTEL o AMD): ");
    string proce = Console.ReadLine();
    Console.WriteLine("Placa de video (NVDIA o AMD): ");
    string placa = Console.ReadLine();
    Console.WriteLine("Tamaño memoria RAM: ");
    decimal tamañoRAM = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Tamaño disco duro: ");
    decimal tamañoDiscoDuro = decimal.Parse(Console.ReadLine());
}
