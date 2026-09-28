namespace AlertaCasaPOO;

public class Ausencia
{
    public static bool ComprobarAusencia(string rutaArchivo)
    {
        DateTime ahora = DateTime.Now;
        bool ausencia = false;
        if (File.Exists(rutaArchivo))
        {
            string contenido = File.ReadAllText(rutaArchivo);
            if (DateTime.TryParse(contenido, out DateTime anterior))
            {
                TimeSpan diferencia = ahora - anterior;
                if (diferencia > TimeSpan.FromHours(2))
                {
                    ausencia = true;
                    Console.WriteLine("Ausencia detectada");
                }
            }
        }
        File.WriteAllText(rutaArchivo, ahora.ToString("O"));
        return ausencia;
    }
}