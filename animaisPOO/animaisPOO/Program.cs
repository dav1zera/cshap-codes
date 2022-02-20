using System;

namespace animaisPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat oscar = new Cat("Oscar", 5, "male", "Azul");
            Console.WriteLine($"{oscar.Name}, The Cat");

            
        }
    }
}
