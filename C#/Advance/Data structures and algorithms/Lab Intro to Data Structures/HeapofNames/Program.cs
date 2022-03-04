namespace HeapofNames
{
    using System;
    using MoreComplexDataStructures;

    class Program
    {
        static void Main()
        {
            /*
            MaxHeap<int> heap = new MaxHeap<int>();

            heap.Insert(2);
            heap.Insert(4);
            heap.Insert(5);
            heap.Insert(65);
            heap.Insert(12);

            for (int i = 0; i < heap.Count; i++)
            {
                Console.WriteLine(heap.ExtractMax());
            }
            */


            MaxHeap<string> heapName = new MaxHeap<string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                heapName.Insert(name);
            }


            for (int i = heapName.Count; i > 0; i--)
            {
                Console.WriteLine(heapName.ExtractMax());
            }
        }
    }
}
