namespace AlertaCasaPOO.Tests
{
    public class RegistroTemperaturaTests
    {
        [Fact]
        public void Crear_RegistraElValorCorrectamente()
        {
            var registro = RegistroTemperatura.Crear(22.5);

            Assert.Equal(22.5, registro.Valor);
        }

        [Fact]
        public void Crear_AsignaFechaYHora()
        {
            var registro = RegistroTemperatura.Crear(22.5);

            Assert.NotEqual(default(DateTime), registro.FechaHora);
        }
    }
}