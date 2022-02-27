namespace Linked_Strings
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string last = Console.ReadLine();
            string afterFirst = Console.ReadLine();
            string beforeLast = Console.ReadLine();

            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst(first);
            list.AddLast(last);
            list.AddAfter(list.First, afterFirst);
            list.AddBefore(list.Last, beforeLast);

            Console.WriteLine(String.Join(", ", list));

        }
    }
}