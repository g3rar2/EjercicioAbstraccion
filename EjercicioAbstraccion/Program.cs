using EjercicioAbstraccion;

int opcion;

ConversionDistancia convertirDistancia = new ConversionDistancia();
ConversionMoneda convertirMoneda = new ConversionMoneda();
ConversionTemperatura convertirTemperatura = new ConversionTemperatura();

Console.WriteLine("******************************");
Console.WriteLine("             MENU             ");
Console.WriteLine("* 1. Convertir Distancia     *");
Console.WriteLine("* 2. Convertir Moneda        *");
Console.WriteLine("* 3. Convertir Temperatura   *");
Console.WriteLine("******************************");

Console.WriteLine("Seleccione la opcion:");
opcion = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

switch (opcion)
{
	case 1:
        Console.WriteLine("Ingrese la cantidad en Kilometros:");
        convertirDistancia.CantidadKilometros=Convert.ToInt32(Console.ReadLine());
        convertirDistancia.Imprimir();

        break;

    case 2:
        Console.WriteLine("Ingrese la cantidad en Lempiras:");
        convertirMoneda.CantidadLempiras=Convert.ToInt32(Console.ReadLine());
        convertirMoneda.Imprimir();


        break;
        
    case 3:

        Console.WriteLine("Ingrese la cantidad en Grados Celsius:");
        convertirTemperatura.CantidadCelcius = Convert.ToInt32(Console.ReadLine());
        convertirTemperatura.Imprimir();

        break;

    default:
        Console.WriteLine("Ingrese una opcion valida");
        break;
}