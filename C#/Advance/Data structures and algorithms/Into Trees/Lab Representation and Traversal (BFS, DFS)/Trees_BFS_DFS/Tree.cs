namespace Trees_BFS_DFS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Tree<T>
    {
        public Node<T> Root { get; set; }

        public Tree(Node<T> root)
        {
            Root = root;
        }

        public void BFS()
        {
            //add root in queue
            //while queue not empty
            //remove and princt current element in queue
            //add all children in queue

            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();
                Console.WriteLine(currentNode.Value);

                foreach (var child in currentNode.Children)
                {
                    queue.Enqueue(child);
                }
            }
        }

        public void DFS(Node<T> node)
        {
            foreach (var child in node.Children)
            {
                DFS(child);
            }
            Console.WriteLine(node.Value);
        }
    }
}