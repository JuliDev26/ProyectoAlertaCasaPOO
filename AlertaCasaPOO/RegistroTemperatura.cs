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

    // MÉTODO NUEVO: recibe el valor y crea el registro con la hora actual
    public static RegistroTemperatura Crear(double valor, string unidad = "°C")
    {
        return new RegistroTemperatura(valor, DateTime.Now, unidad);
    }
}
