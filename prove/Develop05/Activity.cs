public abstract class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int PrepareTime { get; set; } = 3; // default prepare time of 3 seconds

    public abstract void Start();

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}... ");
            System.Threading.Thread.Sleep(1000); // wait 1 second
        }
        Console.WriteLine("Go!");
    }

    protected void Finish()
    {
        Console.WriteLine("Good job! You have completed the {0} activity for {1} seconds.", Name, Duration);
        Console.WriteLine();
        Countdown(PrepareTime);
    }

    private int _duration;
    protected int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }
}
