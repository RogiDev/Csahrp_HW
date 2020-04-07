using System;

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] strarr =
            {
                new string[] {"main", "up", "sub"},
                new string[] {"down", "center", "up"},
                new string[]{"sub","down","main"}
            };
          
            for (int i = 0; i < strarr.Length;i++)
            {
                for(int j = 0; j<strarr.Length; j++)
                {
                    Console.Write(strarr[i][j] + " ");
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}