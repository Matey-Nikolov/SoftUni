﻿namespace TraverseGraphWithBFS
{
    using System;

   public class Program
    {
        static void Main()
        {
            Graph graph = new Graph(4);

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);

            graph.BFS(1);
        }
    }
}