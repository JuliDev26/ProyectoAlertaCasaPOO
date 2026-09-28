public class Program
{
    public static void Main()
    {
        // Creamos un registro con la temperatura y la hora actual
        var registro = new RegistroTemperatura(22.5, DateTime.Now);

        // Lo mostramos por pantalla
        Console.WriteLine("=== Registro de Temperatura ===");
        Console.WriteLine($"Valor: {registro.Valor}°C");
        Console.WriteLine($"Fecha y hora: {registro.FechaHora}");

        // Probamos con otra temperatura
        var registro2 = new RegistroTemperatura(18.3, DateTime.Now);
        Console.WriteLine("\n=== Otro registro ===");
        Console.WriteLine($"Valor: {registro2.Valor}°C");
        Console.WriteLine($"Fecha y hora: {registro2.FechaHora}");
    }
}
