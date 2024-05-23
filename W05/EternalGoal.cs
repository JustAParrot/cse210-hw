public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        //some stuff
    }

    public override string GetProgress()
    {
        return "[∞] " + Name;
    }
}
