using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();


        int square = SquareNumber(userNumber);
        DisplayResult(userName,square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    {
        Console.Write("Please Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please Enter your favorite number: ");
        string userInput = Console.ReadLine();
        int num = int.Parse(userInput);
        return num;
    }

    static int SquareNumber(int number)
    {
        int squared = (number * number);
        return squared;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"Brother {name}, the square of your number is {square}");
    }
}
