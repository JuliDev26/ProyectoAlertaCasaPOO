using System;
using System.Collections.Generic;
using System.Text;

namespace AlertaCasaPOO.Entidades
{
    public class Evento
    {
        public DateTime FechaHora { get; set; }


        public Evento()
        {
            FechaHora = DateTime.Now;
        }
    }
}
