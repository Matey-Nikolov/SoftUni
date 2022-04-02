using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Shortest_Path
{
    public class Graph
    {
        private static int verticesCount;
        private static List<int>[] adjacents;

        private static int countSort;
        private static int countSortSave;

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
            //adjacents[secondVertex].Add(firstVertex);
        }

        public void PrintSortPathCount(int startNode, int endNode)
        {
            bool[] isVisited = new bool[verticesCount];
            List<int> pathList = new List<int>();

            // add source to path[]
            pathList.Add(startNode);



            // Call recursive utility
            CountPathsUtil(startNode, endNode, isVisited, pathList);
        }

        private void CountPathsUtil(int startNodeMove, int endNodeMove, bool[] isVisited, List<int> pathList)
        {
            if (countSortSave < 0)
            {
                return;
            }

            if (startNodeMove.Equals(endNodeMove))
            {
                if (countSortSave < countSort)
                {
                    countSortSave = countSort;
                }
                else
                {
                    Console.WriteLine($"Path found. Length: {countSort}");
                }


                countSort = 0;
                return;
            }

            isVisited[startNodeMove] = true;


            foreach (var itemCheck in adjacents[startNodeMove])
            {
                if (!isVisited[itemCheck])
                {
                    countSort++;

                    pathList.Add(itemCheck);
                    CountPathsUtil(itemCheck, endNodeMove, isVisited, pathList);
                    pathList.Remove(itemCheck);
                }
            }

            if (countSortSave == 0)
            {
                Console.WriteLine("No path exists");
                countSortSave = -1;
                return;
            }

            isVisited[startNodeMove] = false;


        }
    }
}
