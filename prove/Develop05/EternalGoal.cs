public class EternalGoal : Goal {
    public EternalGoal(string name, string description, int points) : base(name, description, points) {}

    public override void RecordEvent() {
        // Record the event for an eternal goal
    }

    public override bool IsComplete() {
        // Eternal goal is never complete...i guess
        return false;
    }
}
