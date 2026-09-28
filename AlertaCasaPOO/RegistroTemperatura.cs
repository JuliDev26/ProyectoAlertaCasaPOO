using System;
using System.Collections.Generic;
public class RegistroTemperatura
{
    public double Valor { get; set; }
    public DateTime FechaHora { get; set; }
    public string Unidad { get; set; }

    // Colección donde se guardan todos los registros
    public static List<RegistroTemperatura> Registros { get; set; }
        = new List<RegistroTemperatura>();
    public RegistroTemperatura(double valor, DateTime fechaHora, string unidad)
    {
        Valor = valor;
        FechaHora = fechaHora;
        Unidad = unidad;
    }
    public static RegistroTemperatura Crear(double valor)
    {
        var registro = new RegistroTemperatura(
            valor,
            DateTime.Now,
            "°C"
        );

        Registros.Add(registro);

        return registro;
    }
    public static RegistroTemperatura? ObtenerUltimoRegistro()
    {
        if (Registros.Count == 0)
        {
        return null;
        }
         
        return Registros[Registros.Count - 1];
    }


}