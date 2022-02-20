using System;
using System.Collections.Generic;
//POO 2 usando a estrutura de dados fila(queue)
//Peek = Retorna o objeto na parte superior do Stack<T> sem remover
//Dequeue = remove o elemento do topo

class Fila
{
    static int Main(string[] args)
    {
        Queue<string> queuenomes = new Queue<string>();
        queuenomes.Enqueue("Davi");
        queuenomes.Enqueue("Alves");
        queuenomes.Enqueue("Dos");
        queuenomes.Enqueue("Santos");
        
        Console.WriteLine(" == Fila == ");
        foreach (string s in queuenomes)
            Console.WriteLine(s);

        Console.WriteLine($"Quantidade de elementos:  {queuenomes.Count}");
        Console.WriteLine($"Elemento do topo: {queuenomes.Peek()}");
        Console.WriteLine($"Elemento que será removido: {queuenomes.Dequeue()}");

        Console.WriteLine(" == Fila == ");
        foreach (string s in queuenomes)
            Console.WriteLine(s);
        Console.WriteLine($"Quantidade de elementos: {queuenomes.Count}");


        return 0;
    }
}
