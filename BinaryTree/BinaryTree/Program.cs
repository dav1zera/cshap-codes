using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            treeNode J = new treeNode('J');
            treeNode L = new treeNode('L');
            treeNode K = new treeNode('K', J, L);

            treeNode M = new treeNode('M');
            treeNode I = new treeNode('I', null, M);

            treeNode root = new treeNode('B', K, I);
            root.Print();

        }
    }

}        
    


