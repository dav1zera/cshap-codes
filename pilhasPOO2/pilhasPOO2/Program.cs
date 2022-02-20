using System;
using System.Collections.Generic;
//POO 2 usando a estrutura de dados Pilha(stack)
//Peek = Retorna o objeto na parte superior do Stack<T> sem remover
//Pop  = Remove e retorna o objeto na parte superior do Stack<T>

class Pilhas
{
    static int Main(string[] args)
    {
        Stack<string> stacknomes = new Stack<string>();
        stacknomes.Push("Davi");
        stacknomes.Push("Alves");
        stacknomes.Push("dos");
        stacknomes.Push("Santos");

        Console.WriteLine(" == Pilha == ");
        foreach (string s in stacknomes)
            Console.WriteLine(s);

         Console.WriteLine($"Quantidade de elementos:  {stacknomes.Count}");
         Console.WriteLine($"Elemento do topo: {stacknomes.Peek()}");
         Console.WriteLine($"Elemento do topo para remover: {stacknomes.Pop()}");

        Console.WriteLine(" == Pilha == ");
        foreach (string s in stacknomes)
            Console.WriteLine(s);
            Console.WriteLine($"Quantidade de elementos: {stacknomes.Count}");


        return 0;
    }
}
