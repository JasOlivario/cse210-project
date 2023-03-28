using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = 1;
        List<int> numbers = new List<int>();
        
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }


        int total = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();
        int min = 1;
        if (number > 0)
        {
            min = numbers.Min();
        }
        numbers.Sort();

        Console.WriteLine();
        Console.WriteLine($"The Sum is: {total}");
        Console.WriteLine($"The Average is {average}");
        Console.WriteLine($"The Largest number is: {max}");
        Console.WriteLine($"The Smallest Positive number is: {min}");
        Console.WriteLine("The Sorted list is: ");

        foreach (int x in numbers)
        {
            Console.WriteLine(x);
        }


    }
}