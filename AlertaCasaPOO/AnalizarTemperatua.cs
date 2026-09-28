namespace AlertaCasaPOO
{
    public static class AnalizarTemperatura
    {
        public static void CrearDirectorioCSV()
        {
            string nombreDirectorio = "temp_sensor"; 

            if (Directory.Exists(nombreDirectorio))
            {
                Console.WriteLine($"El directorio {nombreDirectorio} ya existe");
            }
            else
            {
                Directory.CreateDirectory("temp_sensor");
                Console.WriteLine($"Directorio {nombreDirectorio} creado con éxito");
            }
        }

        public static void historialTemperaturas()
        {
            int contadorLinea = 0;
            string ficheroTemperaturas = Path.Combine("temp_sensor", "temperaturas.csv");
            CrearDirectorioCSV();
            Console.WriteLine("=== HISTÓRICO DE TEMPERATURAS ===\n");

            string[] resgistros = File.ReadAllLines(ficheroTemperaturas);
            foreach(string registro in resgistros.Skip(1))
            {
                contadorLinea++;
                Console.WriteLine($"{contadorLinea} ==> {registro}");
            }
            
        }

        
    }
}

