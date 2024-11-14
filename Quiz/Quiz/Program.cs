using System;

namespace QuizItem
{
    public class QuizItem
    {
        public string Text { get; set; }
        public QuizItem(string text) => Text = text;
    }

    public class BinaryTreeNode<T>
    {
        public T Data { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; }
        public int Count { get; set; }

        public BinaryTree()
        {
            Root = null;
            Count = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<QuizItem> tree = GetTree();
            BinaryTreeNode<QuizItem> node = tree.Root;

            while (node != null)
            {
                if (node.Left != null || node.Right != null)
                {
                    Console.Write(node.Data.Text + " (Y/N): ");
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    Console.WriteLine(); // Adiciona uma nova linha após a tecla pressionada
                    if (keyInfo.Key == ConsoleKey.Y)
                    {
                        WriteAnswer("Yes");
                        node = node.Left;
                    }
                    else if (keyInfo.Key == ConsoleKey.N)
                    {
                        WriteAnswer("No");
                        node = node.Right;
                    }
                    else
                    {
                        WriteAnswer("Invalid input. Please press Y or N.");
                    }
                }
                else
                {
                    WriteAnswer(node.Data.Text);
                    node = null; // Seta node como null para sair do loop
                }
            }
        }

        private static BinaryTree<QuizItem> GetTree()
        {
            BinaryTree<QuizItem> tree = new BinaryTree<QuizItem>
            {
                Root = new BinaryTreeNode<QuizItem>(new QuizItem("Você gosta de viajar?"))
                {
                    Left = new BinaryTreeNode<QuizItem>(new QuizItem("Você gostaria de aprender uma nova língua?"))
                    {
                        Left = new BinaryTreeNode<QuizItem>(new QuizItem("Sim, adoro aprender")),
                        Right = new BinaryTreeNode<QuizItem>(new QuizItem("Não odeio essa merda"))
                    },
                    Right = new BinaryTreeNode<QuizItem>(new QuizItem("Você já fez trabalho voluntário?"))
                    {
                        Left = new BinaryTreeNode<QuizItem>(new QuizItem("Sim, adoro ajudar os necessitados")),
                        Right = new BinaryTreeNode<QuizItem>(new QuizItem("Você já me viu com pobre?"))
                        {
                            Left = new BinaryTreeNode<QuizItem>(new QuizItem("Sim, adoro ajudar os necessitados")),
                            Right = new BinaryTreeNode<QuizItem>(new QuizItem("Você já me viu com pobre?"))
                        }
                    }
                },
                Count = 9
            };
            return tree;
        }

        private static void WriteAnswer(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}