using AlertaCasaPOO.Entidades;
namespace AlertaCasaPOO;

public class ESCSV
{
    public static void GuardarCSV(string archivo, Temperatura temperatura)
    {
        string? carpeta = Path.GetDirectoryName(archivo);
        if (!string.IsNullOrEmpty(carpeta)) Directory.CreateDirectory(carpeta);
        File.AppendAllText(archivo, $"{temperatura.FechaHora:dd/MM/yyyy HH:mm};{temperatura.TemperaturaRegistrada}{Environment.NewLine}");
    }
    public static void LeerCSV(string archivo)
    {
        try
        {
            foreach (string linea in File.ReadLines(archivo))
            {
                string[] datos = linea.Split(';');
                if (datos.Length == 2 && double.TryParse(datos[0], out double temperatura) && DateTime.TryParseExact(datos[1], "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime fechaHora)) Console.WriteLine($"{fechaHora:dd/MM/yyyy HH:mm}: {temperatura:F2}ºC");
            }
        }
        catch (Exception e) when (e is DirectoryNotFoundException || e is FileNotFoundException)
        {
            Console.WriteLine("Archivo no encontrado");
        }
    }
}
