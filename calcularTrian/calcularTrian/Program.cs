using System;
using System.Globalization;

namespace calcularTrian
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.ladoA  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.ladoB  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.ladoC  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo y: ");
            y.ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            double areaX = x.Area();

            
            double areaY = y.Area();

            Console.WriteLine("Area de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");

            }
            else
            {
                Console.WriteLine("Maior area: Y");

            }

        }
    }
}
