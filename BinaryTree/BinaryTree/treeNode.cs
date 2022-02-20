using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class treeNode
    {
        public char data;
        public treeNode sad;  // *direita
        public treeNode sae;  // *esquerda

        //Folhas
        public treeNode(char data)
        {
            this.data = data;
        }

        //Nós Intermediarios
        public treeNode(char data, treeNode sae, treeNode sad)
        {
            this.data = data;
            this.sad = sad;
            this.sae = sae;
        }

        public void Print()
        {
            Console.WriteLine(data);
            if (sae != null)
                sae.Print();

            if (sad != null)
                sad.Print();

        }
    }
}
