public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) 
        : base(name, points)
    {
        this.targetCount = targetCount;
        this.currentCount = 0;
        this.bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        currentCount++;
        if (currentCount >= targetCount)
        {
            MarkComplete();
        }
    }

    public override string GetProgress()
    {
        return IsCompleted ? "[X] " + Name + " (Completed)" 
                           : "[ ] " + Name + " (Completed " + currentCount + "/" + targetCount + " times)";
    }
}
