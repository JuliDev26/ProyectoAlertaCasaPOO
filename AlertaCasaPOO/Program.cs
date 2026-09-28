using System;

public class Program
{
    public static void Main()
    {
        // Creamos un registro con la temperatura y la hora actual
        var registro = new RegistroTemperatura(22.5, DateTime.Now, "°C");

        // Lo mostramos por pantalla
        Console.WriteLine("=== Registro de Temperatura ===");
        Console.WriteLine($"Valor: {registro.Valor} {registro.Unidad}");
        Console.WriteLine($"Fecha y hora: {registro.FechaHora}");

        // Probamos con otra temperatura
        var registro2 = new RegistroTemperatura(18.3, DateTime.Now, "°C");
        Console.WriteLine("\n=== Otro registro ===");
        Console.WriteLine($"Valor: {registro2.Valor} {registro2.Unidad}");
        Console.WriteLine($"Fecha y hora: {registro2.FechaHora}");

        // Llamada al método
        var registroTemp = RegistroTemperatura.Crear(22.5);

        // Mostrarlo por pantalla
        Console.WriteLine($"Valor: {registroTemp.Valor} {registroTemp.Unidad}");
        Console.WriteLine($"Fecha y hora: {registroTemp.FechaHora}");

        //Thiago -almacenamiento
        RegistroTemperatura.Crear(22.5);
        RegistroTemperatura.Crear(18.3);
        RegistroTemperatura.Crear(30);

        Console.WriteLine("Total registros: " + RegistroTemperatura.Registros.Count);
    }
}
