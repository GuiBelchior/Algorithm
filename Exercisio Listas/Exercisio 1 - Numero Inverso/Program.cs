using ConsoleApp2;
using System;

internal class Program
{

    static void Main(string[] args)
    {
        int[] numbers = new int[5];
        int[] oppositeNumbers = new int[5];
        Userinterface Userinterface = new Userinterface();
        Console.WriteLine("Welcome to the inverse number detector.");

        Userinterface.AskNumber(numbers, oppositeNumbers);

        Console.WriteLine("Original Numbers:");
        Userinterface.DisplayOriginalNumbers(numbers);

        Console.WriteLine("Inverted Numbers:");
        Userinterface.DisplayOppositeNumbers(oppositeNumbers);
    }
}
