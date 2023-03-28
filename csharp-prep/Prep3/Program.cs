using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        
        while(response == "yes")
        {
            int guesses = 0;
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            int number2 = 0;
            while (number2 != number)
            {
                Console.Write("What is your guess?");
                string userInput2 = Console.ReadLine();
                number2 = int.Parse(userInput2);
            
                if (number2 > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (number2 < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                guesses++;           
            }
            Console.WriteLine("You Win!");
            Console.WriteLine($"You got it in {guesses} guesses");
            Console.WriteLine();
            Console.Write("Would you like to play again? (Yes/No)");
            response = Console.ReadLine();      
        }
    }
}