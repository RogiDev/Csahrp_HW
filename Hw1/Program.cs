using System;
using System.Linq;

namespace Hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Array Length");
            int arrayLen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter a number");
            int mulNum = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[arrayLen];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i * mulNum;
                Console.Write($"{myArray[i]} ");
                
            }

            Console.ReadKey();
        }
    }
}