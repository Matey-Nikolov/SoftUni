using System;

class ConnectedArea
{

    static int widthX;
    static int heightY;
    static char[,] labyrinth;

    static void Main()
    {
        ReadMatrix();

        int maxSize = 0;

        for (int row = 0; row < heightY; row++)
        {
            for (int col = 0; col < widthX; col++)
            {
                if (labyrinth[row, col] == '1')
                {
                    int areaSize = FindArea(row, col);
                    if (areaSize > maxSize)
                    {
                        maxSize = areaSize;
                    }
                }
            }
        }

        Console.WriteLine($"The largest connected area of the matrix is: {maxSize}");
    }

    private static void ReadMatrix()
    {
        heightY = int.Parse(Console.ReadLine());
        widthX = int.Parse(Console.ReadLine());

        labyrinth = new char[heightY, widthX];

        for (int i = 0; i < heightY; i++)
        {
            string input = Console.ReadLine();

            for (int j = 0; j < widthX; j++)
            {
               // if (input[j] != ' ')
               // {
                    labyrinth[i, j] = input[j];
               // }
            }
        }
    }

    private static int FindArea(int row, int col)
    {
        if (row >= heightY || row < 0
            || col >= widthX || col < 0)
        {
            return 0;
        }

        if (labyrinth[row, col] == '.')
            return 0;

        labyrinth[row, col] = '.';
        int areaSize = 1;

        areaSize += FindArea(row + 1, col);
        areaSize += FindArea(row - 1, col);
        areaSize += FindArea(row, col + 1);
        areaSize += FindArea(row, col - 1);

        return areaSize;
    }
}