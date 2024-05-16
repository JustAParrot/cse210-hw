public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
    };

    public ReflectionActivity(int duration) : base(duration) { }

    public override void StartActivity()
    {
        Console.WriteLine("Reflection Activity:");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("Get ready to begin...");
        Console.WriteLine("Starting in 3...");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("2...");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("1...");
        System.Threading.Thread.Sleep(1000);

        for (int i = 0; i < _duration; i++)
        {
            string prompt = _prompts[new Random().Next(0, _prompts.Count)];
            Console.WriteLine(prompt);

            foreach (string question in _questions)
            {
                Console.WriteLine(question);
                System.Threading.Thread.Sleep(3000);
            }
        }

        Console.WriteLine("Well done! You have completed the Reflection Activity for {_duration} seconds.");
        System.Threading.Thread.Sleep(3000);
    }
}
