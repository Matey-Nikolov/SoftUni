namespace Ex_Cycles_in_a_Graph
{
    using System;
    using System.Collections.Generic;
    using System.Text;

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
            adjacents[secondVertex].Add(firstVertex);
        }

        public bool isCyclic()
        {
            bool[] visitedVertices = new bool[verticesCount];

            for (int j = 0; j < verticesCount; j++)
            {
                if (!visitedVertices[j])
                {
                    if (isCyclicUtil(j, visitedVertices, -1))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool isCyclicUtil(int vertex, bool[] visitedVertices, int parent)
        {
            visitedVertices[vertex] = true;

            foreach (var item in adjacents[vertex])
            {
                if (!visitedVertices[item])
                {
                    if (isCyclicUtil(item, visitedVertices, vertex))
                    {
                        return true;
                    }
                }
                else if (item != parent)
                {
                    return true;
                }
            }

            return false;
        }
    }
}