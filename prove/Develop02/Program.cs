using System;

class Program
{
    static void Main(string[] args)
    {
        Journal     journal = new Journal();
        int         menuUserInput = 0;

        List<string>    menu = new List<string>
        {
            "Please select one of the following choices",
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit",
            "What would you like to do?"
        };

        while (menuUserInput !=5)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserInput = int.Parse(Console.ReadLine());

            if (menuUserInput == 1)
            {
                PromptGenerator randomPrompt = new PromptGenerator();
                Console.WriteLine($"{randomPrompt.GetRandomPrompt()}");
                Console.Write(">");
                string userEntry = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                journal.CreateJournalEntry(dateText, randomPrompt.GetRandomPrompt(), userEntry);
            }

            if(menuUserInput == 2){
               journal.DisplayJournalEntry();
            }

            if(menuUserInput == 3){
                Console.WriteLine("What is your file name: ");
                string userFileName = Console.ReadLine();
                journal.LoadFromCSV(userFileName);
            }
            
            if(menuUserInput == 4){
                Console.WriteLine("What is y your file name: ");
                string userFileName = Console.ReadLine();
                journal.SaveToCSV(userFileName);
            }


        }
       
    }
}