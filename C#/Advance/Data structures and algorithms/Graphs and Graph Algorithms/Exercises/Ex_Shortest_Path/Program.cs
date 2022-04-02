namespace Ex_Shortest_Path
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            var graph = ReadGraph();

            int startVertex = int.Parse(Console.ReadLine());
            int endVertex = int.Parse(Console.ReadLine());

            Console.WriteLine($"Shortest path length from {startVertex} to {endVertex}:");

            graph.PrintSortPathCount(startVertex, endVertex);
        }

        public static Graph ReadGraph()
        {
            int verticesCount = int.Parse(Console.ReadLine());
            Graph GraphRead = new Graph(verticesCount);

            int countOfEgesN = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfEgesN; i++)
            {
                int[] firstAndSecondVertexOfEdge = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                int firstVertex = firstAndSecondVertexOfEdge[0];
                int secondVertex = firstAndSecondVertexOfEdge[1];

                GraphRead.AddEdge(firstVertex, secondVertex);
            }

            return GraphRead;
        }
    }
    
}