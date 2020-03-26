using System;
using System.Linq;

namespace Hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please Enter Array Length");
            //takes the array length from user input and convert to int --- user input always string
            int arrayLen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter a number");
            // takes a mul number from user and convert it to int from string
            int mulNum = Convert.ToInt32(Console.ReadLine());
            //new array initilize
            int[] myArray = new int[arrayLen];
            // for loop to print the numbers
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i * mulNum;
                Console.Write($"{myArray[i]} ");
                
            }
            // wait from user to press some key
            Console.ReadKey();
        }
    }
}