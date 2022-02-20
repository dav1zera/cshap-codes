using System;
using System.Globalization;


namespace somaClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Somar a, b;
            a = new Somar();
            b = new Somar();

            Console.WriteLine("Digite dois numeros: ");
            a.num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double res = (a.num1 + b.num2);

            Console.WriteLine(res);
        }
    }
}
