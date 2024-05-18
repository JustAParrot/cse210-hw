public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
    };

    public ListingActivity(int duration) 
        : base(duration, "Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public override void StartActivity()
    {
        DisplayStartingMessage();

        string prompt = _prompts[new Random().Next(_prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("Start listing...");
        PauseWithCountdown(5);

        for (int i = 0; i < _duration; i++)
        {
            Console.WriteLine($"Time left: {_duration - i} seconds");
            System.Threading.Thread.Sleep(1000);
        }

        DisplayEndingMessage();
    }
}