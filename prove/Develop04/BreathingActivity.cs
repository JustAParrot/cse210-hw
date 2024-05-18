public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) 
        : base(duration, "Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void StartActivity()
    {
        DisplayStartingMessage();

        for (int i = 0; i < _duration / 10; i++)
        {
            AnimateBreathingIn();
            AnimateBreathingOut();
        }

        DisplayEndingMessage();
    }
}