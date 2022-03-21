using Nearest_Exit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NearestExit
{
    public static char[,] labyrinth;
    public static int widthX;
    public static int heightY;
    const char visitedCell = 's';

    public static void Main()
    {
        widthX = int.Parse(Console.ReadLine());
        heightY = int.Parse(Console.ReadLine());

        labyrinth = new char[heightY, widthX];

        for (int i = 0; i < heightY; i++)
        {
            string input = Console.ReadLine(); // string[] .Split("")

            for (int j = 0; j < widthX; j++)
            {
                    labyrinth[i, j] = input[j];
            }
        }

        string shortestParthToExit = FindShortestPathToExit();

        if (shortestParthToExit == null)
        {
            Console.WriteLine("No exit!");
        }
        else if (shortestParthToExit == "")
        {
            Console.WriteLine("Start is at the exit.");
        }
        else
        {
            Console.WriteLine($"Shortest exit: {shortestParthToExit}");
        }
    }

    public static string FindShortestPathToExit()
    {
        var queue = new Queue<Point>();
        Point startPositonYX = FindSartPosition();

        if (startPositonYX == null)
        {
            return null;
        }

        queue.Enqueue(startPositonYX);
        
        while (queue.Count > 0)
        {
            Point currentCell = queue.Dequeue();

            if (IsExit(currentCell))
                return TracePathBack(currentCell);


            TryDirection(queue, currentCell, "U", 0, -1);
            TryDirection(queue, currentCell, "R", 1, 0);
            TryDirection(queue, currentCell, "D", 0, 1);
            TryDirection(queue, currentCell, "L", -1, 0);
        }

        return null;
    }

    private static Point FindSartPosition()
    {
        for (int i = 0; i < widthX; i++)
        {
            for (int j = 0; j < heightY; j++)
            {
                if (labyrinth[j, i] == visitedCell)
                {
                    return new Point() { X = i, Y = j };
                }
            }
        }

        return null;
    }

    public static string TracePathBack(Point currentCell)
    {
        StringBuilder sb = new StringBuilder();

        while (currentCell.PreviousPoint != null)
        {
            sb.Append(currentCell.Direction);
            currentCell = currentCell.PreviousPoint;
        }

        var reversedSb = new StringBuilder(sb.Length);
        for (int i = sb.Length - 1; i >= 0; i--)
        {
            reversedSb.Append(sb[i]);
        }

        return reversedSb.ToString();
    }

    public static void TryDirection(Queue<Point> queue, Point currentCell, string direction, int deltaX, int deltaY)
    {
        int newX = currentCell.X + deltaX;
        int newY = currentCell.Y + deltaY;

        if (newX >= 0 && newX < widthX && newY > 0 
            && newY < heightY 
            && labyrinth[newY, newX] == '-')
        {
            labyrinth[newY, newX] = visitedCell;
            var nextCell = new Point()
            {
                X = newX,
                Y = newY,
                Direction = direction,
                PreviousPoint = currentCell
            };
            queue.Enqueue(nextCell);
        }
    }

    public static bool IsExit(Point currentCell)
    {
        bool isOnBorderX = currentCell.X == 0 || currentCell.X == widthX - 1;
        bool isOnBorderY = currentCell.Y == 0 || currentCell.Y == heightY - 1;

        return isOnBorderX || isOnBorderY;
    }
}