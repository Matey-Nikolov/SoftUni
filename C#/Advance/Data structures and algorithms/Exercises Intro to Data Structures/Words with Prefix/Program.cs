namespace WordswithPrefix
{
    using System;
    using rm.Trie;

    class Program
    {
        static void Main()
        {
            Trie trieWords = new Trie();

            string[] text = Console.ReadLine()
                .Split();

            string givenPrefix = Console.ReadLine();

            if (givenPrefix != "")
            {
                for (int i = 0; i < text.Length; i++)
                {
                    trieWords.AddWord(text[i]);
                }
            }

            Console.WriteLine(trieWords.Count());
            Console.WriteLine(trieWords.UniqueCount());
            Console.WriteLine(string.Join(", ", trieWords.GetWords()));

            Console.WriteLine(string.Join(", ", trieWords.GetWords(givenPrefix)));
            trieWords.RemovePrefix(givenPrefix);
            Console.WriteLine(string.Join(", ", trieWords.GetWords()));
        }
    }
}