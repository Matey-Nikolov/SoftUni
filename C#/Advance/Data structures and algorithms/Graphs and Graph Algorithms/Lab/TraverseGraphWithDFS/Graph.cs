namespace TraverseGraphWithDFS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Graph
    {
        private static int verticesCount;
        private static List<int>[] adjacents;

        public Graph(int verticesCountLocal)
        {
            adjacents = new List<int>[verticesCountLocal];

            for (int i = 0; i < adjacents.Length; i++)
            {
                adjacents[i] = new List<int>();
            }
            verticesCount = verticesCountLocal;
        }

        public void AddEdge(int firstVertex, int secondVertex)
        {
            adjacents[firstVertex].Add(secondVertex);
        }

        public void DFS(int vertex)
        {
            bool[] visitedVertices = new bool[verticesCount];

            DFSUtil(vertex, visitedVertices);
        }

        public void DFSUtil(int vertex, bool[] visitedVertices)
        {
            visitedVertices[vertex] = true;

            Console.WriteLine(vertex + " ");

            List<int> verticesList = adjacents[vertex];

            foreach (var item in verticesList)
            {
                if (!visitedVertices[item])
                {
                    DFSUtil(item, visitedVertices);
                }
            }
        }
    }
}
