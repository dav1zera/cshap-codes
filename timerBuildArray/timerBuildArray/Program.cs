using System;
using System.Collections.Generic;
using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {
            
           int [] nums = new int[1000000];
           Stopwatch timer = new Stopwatch();
           timer.Start();
           BuildArray(nums);
           timer.Stop();
           Console.WriteLine($"Tempo que levou: {timer.Elapsed}");

           timer.Start();
           PrintArray(nums); 
           timer.Stop();
           Console.WriteLine($"Tempo para imprimir: {timer.Elapsed}");

        }

            static void BuildArray (int [] arr)
    {
                Random random = new Random();
                for (int i = 0; i < arr.Length; i++)
        {
                   arr[i] = random.Next();
        }
    }
                    static void PrintArray (int [] arr)
    {
                        foreach (var item in arr)
        {
                          Console.WriteLine($"Valor = {item}");
        }
    }
    }

