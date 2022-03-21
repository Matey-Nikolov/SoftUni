using System;
using System.IO;

public static class FindFile
{
    private static void TraverseDirDFS(DirectoryInfo dir, string fileName)
    {
        try
        {
            FileInfo[] files = dir.GetFiles();

            foreach (var direction in files)
            {
                if (direction.ToString() == fileName)
                {
                    Console.WriteLine($"{direction.Name} is found in {dir.FullName}");
                }
            }
        }
        catch
        {
            Console.WriteLine($"No access to {dir}");
        }
    }

    public static void TraverseDirDFS(string directoryPath, string fileName)
    {
        TraverseDirDFS(new DirectoryInfo(directoryPath), fileName);
    }

    static void Main()
    {
        //Change directoryPath and fileName if needed
        //TraverseDirDFS(@"C:\", "Trees-BFS-DFS-Exercises.docx"); 
    }
}