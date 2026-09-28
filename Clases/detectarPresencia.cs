namespace AlertaCasaPOO
{
    public class DetectarPresencia
    {
        public DetectarPresencia(DateTime fecha, string ubicacion)
        {
            Fecha = fecha;
            Ubicacion = ubicacion;
        }

        public DateTime Fecha { get; }
        public string Ubicacion { get; }
    }
}