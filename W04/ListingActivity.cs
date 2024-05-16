public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
    };

    public ListingActivity(int duration) : base(duration) { }

    public override void StartActivity()
    {
        Console.WriteLine("Listing Activity:");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("Get ready to begin...");
        Console.WriteLine("Starting in 3...");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("2...");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("1...");
        System.Threading.Thread.Sleep(1000);

        string prompt = _prompts[new Random().Next(0, _prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("Start listing...");

        System.Threading.Thread.Sleep(5000);
        for (int i = 0; i < _duration; i++)
        {
            Console.WriteLine($"Time left: {_duration - i} seconds");
            System.Threading.Thread.Sleep(1000);
        }

        Console.WriteLine("Well done! You have completed the Listing Activity for {_duration} seconds.");
        System.Threading.Thread.Sleep(3000);
    }
}
