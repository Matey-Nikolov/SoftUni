namespace Numbers_Sorter
{
    using System;

    class Program
    {
        static void Main()
        {
            long[] arrayNum = new long[3];

            for (int i = 0; i < 3; i++)
            {
                arrayNum[i] = long.Parse(Console.ReadLine());
            }


            for (int i = 0; i < arrayNum.Length - 1; i++)
            {
                for (int j = 1; j < arrayNum.Length - i; j++)
                {
                    if (arrayNum[j - 1] < arrayNum[j])
                    {
                        long temp = arrayNum[j];
                        arrayNum[j] = arrayNum[j - 1];
                        arrayNum[j - 1] = temp;
                    }

                }
            }
            Console.WriteLine(string.Join("\n", arrayNum));
        }
    }
}