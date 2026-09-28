namespace AlertaCasaPOO
{
    public static class AnalizarTemperatura
    {
        

        public static void historialTemperaturas()
        {
            int opcionUsuario = 0;
            string ficheroTemperaturas = Path.Combine("temp_sensor", "temperaturas.csv");
            while (opcionUsuario != 3)
            {
                Console.WriteLine("=== HISTORIAL DE TEMPERATURAS - ALERTACASA\n");
                Console.WriteLine("1. Mostrar el histórico completo de temperaturas\n2. Filtrar por fecha\n3. Salir");
                Console.WriteLine("Tu opción: ");
                opcionUsuario = int.Parse(Console.ReadLine() ?? "");


                switch(opcionUsuario)
                {
                    case 1:
                        int contadorLinea = 0;

                        string [] registros = File.ReadAllLines(ficheroTemperaturas);
                        foreach (string registro in registros.Skip(1))
                        {
                            contadorLinea++;
                            Console.WriteLine($"{contadorLinea} ==> {registro}");
                        }
                        break;

                    case 2:
                        bool registroEncontrado = false;
                        string[] fechasRegistros = File.ReadAllLines(ficheroTemperaturas);

                        Console.WriteLine("Introduce la fecha de registro: ");
                        string fechaFiltrada = Console.ReadLine() ?? "";

                        for (int i = 0; i < fechasRegistros.Length; i++)
                        {
                            if (fechaFiltrada == fechasRegistros[i])
                            {
                                Console.WriteLine($"Resultado de la búsqueda: {fechasRegistros[i]} ");
                                registroEncontrado = true;
                            }
                        }

                        if (!registroEncontrado)
                        {
                            Console.WriteLine($"No hay datos para esta fecha: {fechaFiltrada}");
                        }
                        break;
                        
                        
                   

                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                        
                    
                }
            }
            
        }

        
    }
}

