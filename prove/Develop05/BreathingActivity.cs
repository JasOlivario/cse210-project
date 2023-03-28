using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Start()
    {
        Console.WriteLine($"{Name}: {Description}");

        Console.Write("Enter duration (in seconds): ");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine( $"Get ready to begin in {PrepareTime} seconds...");
        Countdown(PrepareTime);

        int countdown = duration&7;
        while (countdown > 0)
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

        Finish();
    }

    private void CountdownWithSeconds(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            System.Threading.Thread.Sleep(1000); // wait 1 second
        }
        Console.WriteLine();
    }
}
