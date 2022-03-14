﻿namespace Trees_BFS_DFS
{
    using System;

    public class Program
    {
        static void Main()
        {
            Node<int> root =
                new Node<int>(7,
                    new Node<int>(19,
                        new Node<int>(1),
                        new Node<int>(12),
                        new Node<int>(31)
                    ),
                    new Node<int>(21),
                    new Node<int>(14,
                        new Node<int>(23),
                        new Node<int>(6)
                    )
                );

            var tree = new Tree<int>(root);
            tree.BFS();

            Console.WriteLine("-------------------------");

            tree.DFS(tree.Root);
        }
    }
}