public abstract class Activity
{
    protected int _duration;

    protected Activity(int duration)
    {
        _duration = duration;
    }

    public abstract void StartActivity();
}