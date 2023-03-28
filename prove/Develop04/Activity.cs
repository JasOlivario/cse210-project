using System.Diagnostics;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration = 0;
    public int spinnerCounter;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

   
    public int GetDuration(int duration)
    {
        return _duration;
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to {_name} activity");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
    }
    

    

    public void displaySpinner(int numSecondsToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            spinnerCounter++;        
            switch (spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }
 
        Console.Write(" ");
    } 
 
    public void displayCountDown(int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >= 1; i--)
        {            
            Console.Write(string.Format("You may begin in: {0}", i));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }






}