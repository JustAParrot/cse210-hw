public abstract class Activity
{
    protected int _duration;
    protected string _name;
    protected string _description;

    protected Activity(int duration, string name, string description)
    {
        _duration = duration;
        _name = name;
        _description = description;
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"{_name} Activity:");
        Console.WriteLine(_description);
        Console.WriteLine("Get ready to begin...");
        PauseWithCountdown(3);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! You have completed the {_name} Activity for {_duration} seconds.");
        Pause(3);
    }

    protected void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Starting in {i}...");
            System.Threading.Thread.Sleep(1000);
        }
    }

    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void AnimateBreathingIn()
    {
        Console.Write("Breathe in: ");
        for (int j = 0; j < 10; j++)
        {
            Console.Write("██");
            System.Threading.Thread.Sleep(100 + j * 40); 
        }
        Console.WriteLine();
    }

    protected void AnimateBreathingOut()
    {
        Console.Write("Breathe out: ");
        for (int j = 0; j < 10; j++)
        {
            Console.Write("██");
            System.Threading.Thread.Sleep(500 - j * 40); 
        }
        Console.WriteLine();
    }

    public abstract void StartActivity();
}
