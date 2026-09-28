public class RegistroTemperatura
{
    public double Valor { get; set; }
    public DateTime FechaHora { get; set; }

    public RegistroTemperatura(double valor, DateTime fechaHora)
    {
        Valor = valor;
        FechaHora = fechaHora;
    }
}
