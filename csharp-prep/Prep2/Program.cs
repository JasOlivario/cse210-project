using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage is your grade? ");
        string grade = Console.ReadLine();

        int number = int.Parse(grade);
        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign;
        if (number%10 >= 7 && !(letter == "A" || letter == "F"))
        {
            sign = "+";
        }
        else if (number%10 <= 3 && !(letter == "F" ))
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }


    

        Console.WriteLine($"{letter}{sign}");

        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Better Luck Next time.");
        }
    }
}