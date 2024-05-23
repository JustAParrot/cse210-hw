public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        // Implementation to mark the goal as completed
        MarkComplete();
    }

    public override string GetProgress()
    {
        return IsCompleted ? "[X] " + Name : "[ ] " + Name;
    }
}
