using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AlertaCasaPOO.Entidades
{
    public class Temperatura
    {

        public double TemperaturaRegistrada { get; set; }
        public DataType FechaHora { get; set; }

        public Guid IDTemperatura { get; set; }

        public bool TemperaturaCorrecta { get; set; }

        public Temperatura(double TemperaturaRegistrada, DataType FechaHora, Guid IDTemperatura, bool TemperaturaCorrecta)
        {
            this.TemperaturaCorrecta = TemperaturaCorrecta;
            this.FechaHora = FechaHora;
            this.IDTemperatura = IDTemperatura;
            this.TemperaturaCorrecta &= TemperaturaCorrecta;
        }

        public void ValidarTemperatura()
        {
            if (TemperaturaRegistrada >= 0 && TemperaturaRegistrada <= 40)
            {
                TemperaturaCorrecta = true;
            }
            else
            {
                TemperaturaCorrecta = false;
            }
        }

    }
}
