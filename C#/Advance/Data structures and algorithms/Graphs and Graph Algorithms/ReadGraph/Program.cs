namespace ReadGraph
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            var graph = ReadGraph();

            int startVertex = int.Parse(Console.ReadLine());

            Console.WriteLine($"Following is Depth First Traversal(starting from vertex {startVertex})");

            graph.DFS(startVertex);
        }

        private static GraphDFS ReadGraph()
        {
            int verticesCount = int.Parse(Console.ReadLine());
            GraphDFS GraphDFS = new GraphDFS(verticesCount);

            int countOfEgesN = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfEgesN; i++)
            {
                int[] firstAndSecondVertexOfEdge = Console.ReadLine()
                    .Split(" ").Select(int.Parse).ToArray();

                int firstVertex = firstAndSecondVertexOfEdge[0];
                int secondVertex = firstAndSecondVertexOfEdge[1];

                GraphDFS.AddEdge(firstVertex, secondVertex);
            }

            return GraphDFS;
        }
    }
}