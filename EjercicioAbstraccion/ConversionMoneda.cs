

namespace EjercicioAbstraccion
{
    public class ConversionMoneda : FormulaMatematica
    {
        public double CantidadLempiras;
        public override double Calcular()
        {
            return CantidadLempiras * 25.25;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"{CantidadLempiras} Lps, equivalen a {Calcular()} dolares");
        }
    }
}
