using System;
//Foreach com Matriz simples de nomes

    class Program
    {
        static void Main(string[] args)
        {
         string[] nomes = { "Davi", "Luiz", "Ana", "Suellen", "João", "Gabriel" };

           foreach (string s in nomes)
        {
            Console.WriteLine("{0}", s);
            
        }
        }
    }

