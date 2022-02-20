/*
  using System;


namespace Calculadora
{
    class Programa10
    {
        static void Main(string[] args)
        {
            int menu;
            do
            {

                Console.WriteLine("|Soma-1 | Subtraçao-2 | Multiplicaçao-3 | Divisao-4 | Sair-0|");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Digite um numero: ");
                       float pnum1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo: ");
                        float snum2 = float.Parse(Console.ReadLine());
                        Console.Write("A soma eh: ", pnum1 + snum2);
                        float soma = (pnum1 + snum2);
                        Console.WriteLine("Soma: " + soma);
                        break;
                    case 2:
                        Console.WriteLine("Digite um numero: ");
                        double snum1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo: ");
                        double sunum2 = double.Parse(Console.ReadLine());
                        double sub = snum1 - sunum2;
                        Console.WriteLine("Subtração: " + sub);
                        break;
                    case 3:
                        Console.WriteLine("Digite um numero: ");
                        double mnum1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo: ");
                        double munum2 = double.Parse(Console.ReadLine());
                        double mult = mnum1 * munum2;
                        Console.WriteLine("Multiplicação: " + mult);
                        break;
                    case 4:
                        Console.WriteLine("Digite um numero: ");
                        double dnum1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo: ");
                        double divnum2 = double.Parse(Console.ReadLine());
                        double div = dnum1 / divnum2;
                        Console.WriteLine("Divisão: " + div);
                        break;

                    default:
                        Console.WriteLine("Saiu");
                        Console.ReadKey();
                        break;

                }

            } while (menu != 0);



        }
    }
}
*/

using System;
using System.Globalization;

namespace calculadoracs {

    class Calculadora {

        static void Main(string[] args) {

            double x = 0.0;
            double y = 0.0;
            double result = 0.0;
            char oper = '+';

            


            Calcular c;
            while (true) { 
            
            Console.WriteLine("Calculator Console Application");
            Console.WriteLine("Please enter the operation to perform. Format: a+b | a-b | a*b | a/b");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            result = c.Calcular(x, oper, y);

            }


        }


    }

}