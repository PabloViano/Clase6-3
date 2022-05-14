using Logica;

Logica.Class1 logica = Logica.Class1.Instance;
logica.AccionCompletada += AccionEventHandler;
Console.WriteLine("Que desea hacer (1 = Continuar, 2 = salir del programa): ");
int valor = int.Parse(Console.ReadLine());
while (valor == 1)
{
    Console.WriteLine("Desea 3 = Dar de alta, 4 = Dar de baja, 5 = Modificar");
    int accion = int.Parse(Console.ReadLine());
    switch (accion)
    {
        case 3:
            {
                Console.WriteLine("Procesador (INTEL o AMD): ");
                string proce = Console.ReadLine();
                Console.WriteLine("Placa de video (NVDIA o AMD): ");
                string placa = Console.ReadLine();
                Console.WriteLine("Tamaño memoria RAM: ");
                decimal tamañoRAM = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Tamaño disco duro: ");
                decimal tamañoDiscoDuro = decimal.Parse(Console.ReadLine());
                logica.Alta(proce, placa, tamañoRAM, tamañoDiscoDuro);
            }
            break;
        case 4:
            {
                Console.WriteLine("Ingrese la ID de la computadora a eliminar; ");
                int id = int.Parse(Console.ReadLine());
                logica.Baja(id);
            }
            break;
        case 5:
            {
                Console.WriteLine("Ingrese la ID de la computadora a eliminar; ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Procesador (INTEL o AMD): ");
                string proce = Console.ReadLine();
                Console.WriteLine("Placa de video (NVDIA o AMD): ");
                string placa = Console.ReadLine();
                Console.WriteLine("Tamaño memoria RAM: ");
                decimal tamañoRAM = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Tamaño disco duro: ");
                decimal tamañoDiscoDuro = decimal.Parse(Console.ReadLine());
                logica.Modificacion(id,proce, placa, tamañoRAM, tamañoDiscoDuro);
            }
            break;
        default:
            {
                Console.WriteLine("Numero incorrecto");
            }
            break;
    }
    Console.WriteLine("Que desea hacer (1 = Continuar, 2 = salir del programa): ");
    valor = int.Parse(Console.ReadLine());

}
static void AccionEventHandler(object? sender, ArgumentosEventos.Class1.AccionComputadoraEventArgs e)
{
    Console.WriteLine($"La computadora fue {e.Accion} con exito!");
}
