using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Userinterface
    {

        //here we have the method to get the number till 5, and register that number in a list
        public static void AskNumber(int[] numbers, int[] oppositeNumbers)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
                oppositeNumbers[i] = -1 * numbers[i];
            }
        }
        // The displayer of numbers inserted
        public static void DisplayOriginalNumbers(int[] numbers)
        {
            Console.WriteLine("Original Numbers:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        //tricky one, this one displayes the opposite number and re
        // public static void ReadAndDisplayOppositeNumbers()
        // {
        //int[] numbers = new int[5];
        //int[] oppositeNumbers = new int[5];
        //
        //Console.WriteLine("Inverted Numbers:");
        //   for (int i = 0; i < 5; i++)
        //    {
        // Console.WriteLine(oppositeNumbers[i]);

        /// <summary>
        ///Remade above
        /// </summary>
        /// <returns></returns>
        public static int[] ReadOppositeNumbers()
        {
            int[] numbers = new int[5];
            int[] oppositeNumbers = new int[5];

            return oppositeNumbers;
        }

        public static void DisplayOppositeNumbers(int[] oppositeNumbers)
        {
            Console.WriteLine("Inverted Numbers:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(oppositeNumbers[i]);
            }
        }
    }


}

