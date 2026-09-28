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
                        int contadorLinea2 = 0;
                        string [] registrosParaFiltrar = File.ReadAllLines(ficheroTemperaturas);
                        Console.WriteLine("Introduce la fecha a filtrar (formato: dd/MM/yyyy)");
                        string fechaFiltro = Console.ReadLine() ?? "";

                        Console.WriteLine($"Filtrando registros por fecha: {fechaFiltro}");

                        for (int i = 0; i < registrosParaFiltrar.Length; i++)
                        {
                            string[] camposCSV = registrosParaFiltrar[i].Split(';');
                            string fechaRegistro = camposCSV[0];

                            if (fechaRegistro.StartsWith(fechaFiltro)) // Forma para decirle que la fecha que introduce el usuario es la misma
                            {
                                contadorLinea2++;
                                Console.WriteLine($"{contadorLinea2} ==> {registrosParaFiltrar[i]}");
                            }
                        }
                        if (contadorLinea2 == 0) // Si el contador de la linea no devuelve nada, no ha encontrado registros
                        {
                            Console.WriteLine("No se encontraron registros para la fecha especificada.");
                           
                        }
                        break;

                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no valida, por favor introduce una opcion de la lista.");
                        break;
                        
                    
                }
            }
            
        }

        
    }
}

