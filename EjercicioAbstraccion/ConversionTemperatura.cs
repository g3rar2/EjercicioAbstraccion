

namespace EjercicioAbstraccion
{
    public class ConversionTemperatura : FormulaMatematica
    {
        public double CantidadCelcius;
        public override double Calcular()
        {
            return CantidadCelcius+273;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"{CantidadCelcius} grados celsius equivalen a {Calcular()} grados farenheit");
        }
    }
}
