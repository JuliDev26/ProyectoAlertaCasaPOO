using AlertaCasaPOO.AlertaPresenciaAusencia;
using AlertaCasaPOO.RegistroApertura;
using AlertaCasaPOO.RegistroAperturaNoAutorizada;

namespace AlertaPresenciaAusencia
{
    public class Program
    {
        public void Main(string[] args)
        {
            //Determinación de presencia/ausencia
            bool presencia = false;
            string ubicacion = "";
            AlertaPresencia.presenciaAusencia(presencia, ubicacion);
            DateTime hora;
            bool Tienenpermiso = false;
            bool abierta = false;
            string pin = "";
            bool autorizado = UsuariosAutorizados.autorizados(Tienenpermiso, pin);
            SensorPuerta puerta = new SensorPuerta();

            var (nombre, apertura, time) = puerta.Sensorpuertas();
            if (presencia == true && apertura == true)
            {

                if (autorizado = false)
                {

                    Console.WriteLine("ALERTA acceso de persona no autorizada");
                    Console.WriteLine($"Se ha abierto la puerta {ubicacion} a las {time} horas");
                }
            }

        }
    }
    }