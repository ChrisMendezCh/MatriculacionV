using System;
class Program
{
    static void Main()
    {
        // Crear instancias de Automovil y Camioneta
        Automovil automovil = new Automovil("Toyota", "Corolla", 2022, 4);
        Camioneta camioneta = new Camioneta("Ford", "Ranger", 2021, 1000.5);

        // Mostrar información específica de cada vehículo
        Console.WriteLine("Información del Automóvil:");
        Console.WriteLine(automovil.GetInformation());
        Console.WriteLine();

        Console.WriteLine("Información de la Camioneta:");
        Console.WriteLine(camioneta.GetInformation());
        Console.WriteLine();

        // Realizar acciones específicas de cada vehículo
        Console.WriteLine("Acción del Automóvil:");
        Console.WriteLine(automovil.RunAction());
        Console.WriteLine();

        Console.WriteLine("Acción de la Camioneta:");
        Console.WriteLine(camioneta.RunAction());
    }
}