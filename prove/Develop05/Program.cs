using System;

class Program
{
    static void Main(string[] args)
    {
        // Display menu options
        Console.WriteLine("Select an activity:");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");

        // Get user input
        int choice = int.Parse(Console.ReadLine());

        // Start selected activity
        switch (choice)
        {
            case 1:
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Start();
                break;

            // Add code for ReflectionActivity and ListingActivity here

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
