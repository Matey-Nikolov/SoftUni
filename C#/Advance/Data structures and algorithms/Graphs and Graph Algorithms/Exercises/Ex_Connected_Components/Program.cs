namespace Ex_Connected_Components
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        private static bool[] visited;
        private static List<int>[] graph;

        static void Main()
        {
            graph = ReadGraph();
            FindGraphConnectedComponents();
        }

        public static void FindGraphConnectedComponents()
        {
            int lengthGraph = graph.Length;
            visited = new bool[lengthGraph];

            for (int startNodeVertex = 0; startNodeVertex < lengthGraph; startNodeVertex++)
            {
                if (!visited[startNodeVertex])
                {
                    Console.Write("Connected component:");
                    DFS(startNodeVertex);
                    Console.WriteLine();
                }
            }
        }

        public static void DFS(int vertex)
        {
            if (!visited[vertex])
            {
                visited[vertex] = true;

                foreach (var childVertexNode in graph[vertex])
                {
                    DFS(childVertexNode);
                }

                Console.Write(" " + vertex);
            }
        }

        public static List<int>[] ReadGraph()
        {
            int n = int.Parse(Console.ReadLine());
            List<int>[] graph = new List<int>[n];

            for (int i = 0; i < n; i++)
            {
                graph[i] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
            }

            return graph;
        }

    }
}