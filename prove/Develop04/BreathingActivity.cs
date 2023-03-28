using System;

public class BreathingActivity : Activity
{
    private int _duration;

    public BreathingActivity (string name, string description, int duration) : base(name, description)
    {
        _duration = duration;
    }

    public void BreathingDuration()
    {
        Console.Write("How long would you like to do this in seconds?: ");
        string answer = Console.ReadLine();
        int duration = int.Parse(answer);
    }
    
    public void StartActivity()
    {

        Console.Write("How long would you like to do this in seconds?: ");
        string answer = Console.ReadLine();
        int duration = int.Parse(answer);

        int countDown = duration&7;
        while (countDown < 0)
        {
           Console.WriteLine("Breathe in...");
            CountdownWithSeconds(countdown);

            if (countdown == 1) // last breath
            {
                Console.WriteLine("Breathe out...");
                CountdownWithSeconds(1);
                break;
            }

            Console.WriteLine("Breathe out...");
            CountdownWithSeconds(countdown);

            countdown -= 2;
        }

    }

    public int GetDuration()
    {
        return _duration;
    }
}