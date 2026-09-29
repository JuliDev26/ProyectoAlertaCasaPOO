

namespace AlertaCasaPOO.AlertaPresenciaAusencia

{
    public class AlertaPresencia
    {
         public static  void presenciaAusencia(bool presencia, string ubicacion)
         {
                if (presencia == true)
                {
                DateTime hora = DateTime.Now;
                string horastring= hora.ToString("hh;mm;ss");
                Dictionary<string,string> DetectPresencia=new Dictionary<string,string>();
                DetectPresencia.Add(ubicacion, horastring);

                    Console.WriteLine($"Se ha detectado presencia en {ubicacion} a las {DetectPresencia.Values}");

                }
                else
                {
                    Console.Write("No hay nadie en el interior del recinto");
                }
         }
    }
}

