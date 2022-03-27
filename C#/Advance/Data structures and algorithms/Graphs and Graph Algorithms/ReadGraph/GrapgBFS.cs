namespace ReadGraph
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GrapgBFS
    {
        private static int verticesCount;
        private static LinkedList<int>[] adjacents;

        public GrapgBFS(int verticesCountLocal)
        {
            adjacents = new LinkedList<int>[verticesCountLocal];

            for (int i = 0; i < adjacents.Length; i++)
            {
                adjacents[i] = new LinkedList<int>();
            }
            verticesCount = verticesCountLocal;
        }

        public void AddEdge(int firstVertex, int secondVertex)
        {
            adjacents[firstVertex].AddLast(secondVertex);
        }

        public void BFS(int vertex)
        {
            bool[] visitedVertices = new bool[verticesCount];

            LinkedList<int> queue = new LinkedList<int>();

            visitedVertices[vertex] = true;
            queue.AddLast(vertex);

            while (queue.Count > 0)
            {
                vertex = queue.First();

                Console.Write(vertex + " ");

                queue.RemoveFirst();

                LinkedList<int> list = adjacents[vertex];

                foreach (var adjacent in list)
                {
                    if (!visitedVertices[adjacent])
                    {
                        visitedVertices[adjacent] = true;
                        queue.AddLast(adjacent);
                    }
                }
            }
        }
    }
}
