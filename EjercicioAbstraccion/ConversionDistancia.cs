

namespace EjercicioAbstraccion
{
    public class ConversionDistancia : FormulaMatematica
    {

        public double CantidadKilometros;
        public override double Calcular()
        {
            return CantidadKilometros*0.62;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"{CantidadKilometros} kms equivalen a {Calcular()} millas");
        }
    }
}
