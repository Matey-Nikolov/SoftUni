﻿namespace DFSTraverseFoldersandFiles
{
    using System;
    using System.IO;
    //using SimpleTreeNode;

    class Program
    {
        static void Main()
        {
            //TraverseDirDFS(@"C:\Windows\assembly");
        }

        private static void TraverseDirDFS(DirectoryInfo dir, string spaces)
        {
            Console.WriteLine(spaces + dir.FullName);

            FileInfo[] files = dir.GetFiles();

            foreach (var file in files)
            {
                Console.WriteLine(spaces + " " + file.FullName);
            }

            DirectoryInfo[] children = dir.GetDirectories();

            foreach (DirectoryInfo child in children)
            {
                TraverseDirDFS(child, spaces + " ");
            }
        }

        public static void TraverseDirDFS(string directoryPath)
        {
            TraverseDirDFS(new DirectoryInfo(directoryPath), string.Empty);
        }
    }
}
