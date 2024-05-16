public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration) { }

    public override void StartActivity()
    {
        Console.WriteLine("Breathing Activity:");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("Get ready to begin...");
        Console.WriteLine("Starting in 3...");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("2...");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("1...");
        System.Threading.Thread.Sleep(1000);

        for (int i = 0; i < _duration; i++)
        {
            Console.Write("Breathe in: ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write("██");
                System.Threading.Thread.Sleep(500 - j * 40); 
            }
            Console.WriteLine();

            Console.Write("Breathe out: ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write("██");
                System.Threading.Thread.Sleep(500 + j * 40); 
            }
            Console.WriteLine();
        }

        Console.WriteLine($"Well done! You have completed the Breathing Activity for {_duration} seconds.");
        System.Threading.Thread.Sleep(3000);
    }
}
