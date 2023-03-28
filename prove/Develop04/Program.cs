using System;

class Program
{
    static void Main(string[] args)
    {
        int menuUserInput = 0;
        List<string>    menu = new List<string>
        {
            "Menu Options:",
            "1. Start Breathing Activity",
            "2. Start Reflecting Activity",
            "3. Start Listing Activity",
            "4. Quit",
            "Select a choice from the menu."
        };

        while (menuUserInput !=4)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserInput = int.Parse(Console.ReadLine());

            if (menuUserInput == 1)
            {
                
                Console.Clear();
                BreathingActivity activity = new BreathingActivity("Breathing Activity", 
                                                "This Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing", 0);
                activity.DisplayStartMessage();
                activity.BreathingDuration();
                Console.Clear();
                Console.Write("Get Ready...");
                activity.displaySpinner(3);
                activity.StartActivity();

            }

            if(menuUserInput == 2){
                Console.Clear();
                Activity activity = new Activity("Reflecting Acitivity", 
                                                  "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                activity.DisplayStartMessage();
            }

            if(menuUserInput == 3){
                Console.Clear();
                Activity activity = new Activity("Listing Activity", 
                                                  "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            }
            


        }
       
    }
}