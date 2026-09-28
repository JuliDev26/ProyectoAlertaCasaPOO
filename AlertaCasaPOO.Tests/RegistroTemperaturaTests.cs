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

        [Fact]
        public void Crear_AlmacenaElRegistroEnLaColeccion()
        {
            RegistroTemperatura.Registros.Clear();

            var registro = RegistroTemperatura.Crear(22.5);

            Assert.Contains(registro, RegistroTemperatura.Registros);
        }

        [Fact]
        public void Crear_AlmacenaVariosRegistros()
        {
            RegistroTemperatura.Registros.Clear();

            RegistroTemperatura.Crear(20.0);
            RegistroTemperatura.Crear(21.5);
            RegistroTemperatura.Crear(23.0);

            Assert.Equal(3, RegistroTemperatura.Registros.Count);
        }
    }
}