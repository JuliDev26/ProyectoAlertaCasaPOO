using System.ComponentModel.DataAnnotations;
using AlertaCasaPOO.Entidades;
namespace AlertaCasaPOO;

class Program
{
    static void Main(string[] args)
    {
        Temperatura temperatura = new(34.66, DateTime.Now, true);
        ESCSV.GuardarCSV("datos/temperaturas.csv", temperatura);
        ESCSV.LeerCSV("datos/temperaturas.csv");
    }
}
