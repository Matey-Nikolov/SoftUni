namespace BFSTraverseFolders
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        static void Main()
        {
             TraverseDirBFS(@"C:\Windows\assembly");
        }

        public static void TraverseDirBFS(string directoryPath)
        {
            Queue<DirectoryInfo> visitedFolders = new Queue<DirectoryInfo>();

            visitedFolders.Enqueue(new DirectoryInfo(directoryPath));

            while (visitedFolders.Count > 0)
            {
                DirectoryInfo currentDir = visitedFolders.Dequeue();
                Console.WriteLine(currentDir.FullName);

                DirectoryInfo[] children = currentDir.GetDirectories();

                foreach (DirectoryInfo child in children)
                {
                    visitedFolders.Enqueue(child);
                }
            }
        }
    }
}