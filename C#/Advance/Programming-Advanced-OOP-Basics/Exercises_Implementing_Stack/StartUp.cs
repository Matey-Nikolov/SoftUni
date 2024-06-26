﻿namespace ImplementCustomStack
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            var stack = new CustomStack();
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            stack.ForEach(x => Console.WriteLine(x));
        }
    }
}
