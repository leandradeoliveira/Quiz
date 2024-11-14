using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio
{
     public class Tree
    {
        public Node? Root { get; set; }

        public void PrintTree(Node node){

            Console.Write($"Name: {node.Data?.Name}\n");
            Console.Write($"Role: {node.Data?.Role}\n");
            Console.Write("--\n");

            if(node.Children!.Count() > 0){
                foreach(var i in node.Children!){
                    PrintTree(i);
                }
            }
        }
    }
}