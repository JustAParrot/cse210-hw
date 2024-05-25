public class SimpleGoal : Goal {
    public SimpleGoal(string name, string description, int points) : base(name, description, points) {}

    public override void RecordEvent() {
        // Record the event for a simple goal
    }

    public override bool IsComplete() {
        // Implement logic to check if simple goal is complete
        return false;
    }
}
