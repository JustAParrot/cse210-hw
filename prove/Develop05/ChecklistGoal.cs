public class ChecklistGoal : Goal {
    private int target;
    private int bonus;
    private int amountCompleted;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points) {
        this.target = target;
        this.bonus = bonus;
        amountCompleted = 0;
    }

    public override void RecordEvent() {
        amountCompleted++;
    }

    public override bool IsComplete() {
        return amountCompleted >= target;
    }

    public override string GetDetailsString() {
        return $"{base.GetDetailsString()}, Completed: {amountCompleted}/{target}";
    }
}
