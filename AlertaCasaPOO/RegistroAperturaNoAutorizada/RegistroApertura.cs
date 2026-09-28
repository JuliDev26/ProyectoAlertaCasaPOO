using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;

namespace AlertaCasaPOO.RegistroApertura
{
    // 1. Definición del Sensor de la Puerta
    public class SensorPuerta
    {
        public string Nombre { get; set; }

        public bool EstaAbierta { get; set; }
        public DateTime horaApertura;




        //        // Almacena cuándo se abrió
        //        //Almacenamiento de datos
        //        public static void HistoricoApertura(string horaApertura, string nombre)
        //        {
        //            Dictionary<string, string> Historico = new Dictionary<string, string>();
        //            Historico.Add(nombre, horaApertura);
        //        }

        //        // Evento para notificar al sistema domótico
        //        public event Action<string> OnCambioEstado;

        //        public SensorPuerta(string nombre)
        //        {
        //            Nombre = nombre;
        //            EstaAbierta = false;
        //            horaApertura = DateTime.Now;
        //        }

        //        // Método para simular la apertura
        //        public void Abrir()
        //        {
        //            if (!EstaAbierta)
        //            {
        //                EstaAbierta = true;
        //                horaApertura = DateTime.Now;
        //                OnCambioEstado?.Invoke($"[ALERTA] {Nombre} se ha ABIERTO a las {horaApertura.ToString("HH:mm:ss")}.");
        //            }
        //            HistoricoApertura(Nombre, horaApertura.ToString("HH:mm:ss"));
        //        }
        //        // Método para simular el cierre y calcular la duración

        //        public void HistoricoCierre(string nombre, string horaCierre)
        //        {
        //            Dictionary<string, string> HistoricoCierre = new Dictionary<string, string>();
        //            HistoricoCierre.Add(nombre, horaCierre);
        //        }
        //        public void Cerrar()
        //        {
        //            HistoricoCierre(nombre, horaCierre.ToString("HH:mm:ss"));
        //            if (EstaAbierta)
        //            {
        //                EstaAbierta = false;
        //                DateTime horaCierre = DateTime.Now;

        //                // Calcular cuánto tiempo estuvo abierta
        //                TimeSpan tiempoAbierta = (horaCierre - horaApertura);

        //                OnCambioEstado?.Invoke($"[INFO] {Nombre} se ha CERRADO a las {horaCierre.ToString("HH:mm:ss")}. Estuvo abierta durante {tiempoAbierta.TotalSeconds:F2} segundos.");

        //                horaCierre = null;
        //            }
        //        }
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

