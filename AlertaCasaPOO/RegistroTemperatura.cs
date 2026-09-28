using System;

public class RegistroTemperatura
{
    public double Valor { get; set; }
    public DateTime FechaHora { get; set; }
    public string Unidad { get; set; }

    public RegistroTemperatura(double valor, DateTime fechaHora, string unidad)
    {
        Valor = valor;
        FechaHora = fechaHora;
        Unidad = unidad;
    }
}
