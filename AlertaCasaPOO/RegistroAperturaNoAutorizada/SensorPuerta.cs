


namespace AlertaCasaPOO.RegistroApertura
{
    // 1. Definición del Sensor de la Puerta
    public class SensorPuerta
    {
        public string Nombre { get; set; }

        public bool EstaAbierta { get; set; }
        public DateTime horaApertura;
        string nombre;
        
        
       
        public  (string ubicacion,bool EstaAbierta, DateTime horaApertura) Sensorpuertas() 
        {
            
            
                return (nombre, EstaAbierta, horaApertura);

            
            
            
         
        }
    }
    
}




//public class RegistroApertura
//{
//    public static void registrarAperturaPuerta(bool Apertura, string quien)
//    {
//        if (presencia == true)
//        {

//            Console.WriteLine($"Se ha detectado presencia en {ubicacion}");

//        }
//        else
//        {
//            Console.Write("No hay nadie en el interior del recinto");
//        }
//    }
//}

