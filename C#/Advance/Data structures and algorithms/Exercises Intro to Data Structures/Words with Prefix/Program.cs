namespace Words_with_Prefix
{
    using System;
    using rm.Trie;

    class Program
    {
        static void Main()
        {
            ITrie trieWords = new Trie();


            string[] text = Console.ReadLine()
                .Split(" ");


            for (int i = 0; i < text.Length; i++)
            {
                trieWords.AddWord(text[i]);
            }


            var forPrint = trieWords.GetWords();

            string givenPrefix = Console.ReadLine();

            var printWithGivenPrefix = trieWords.GetWords(givenPrefix);

            foreach (var word in forPrint)
            {
                Console.Write($"{word}, ");
            }
            Console.WriteLine();

            Console.WriteLine(trieWords.Count());
            Console.WriteLine(trieWords.UniqueCount());

            foreach (var word in printWithGivenPrefix)
            {
                Console.Write($"{word}, ");
            }
            Console.WriteLine();

            trieWords.RemovePrefix(givenPrefix);

            var printAgain = trieWords.GetWords();
            foreach (var word in printAgain)
            {
                Console.Write($"{word}, ");
            }
        }
    }
}