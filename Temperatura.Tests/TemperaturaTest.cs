using FluentAssertions;
using AlertaCasaPOO.Entidades;
using System;


namespace AlertaCasaPOO.Tests
{

    public class TemperaturaTest
    {
        [Fact]
        public void Constructor_Temperaturas_CrearTemperaturaCorrectamente()
        {
            Temperatura temperatura = new Temperatura(22.5, true);
            temperatura.TemperaturaRegistrada.Should().Be(22.5);
            temperatura.TemperaturaCorrecta.Should().Be(true);
        }
    }
}
