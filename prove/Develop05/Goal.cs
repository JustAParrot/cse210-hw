public abstract class Goal {
    protected string name;
    protected string description;
    protected int points;

    public Goal(string name, string description, int points) {
        this.name = name;
        this.description = description;
        this.points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString() {
        return $"{name}: {description}, Points: {points}";
    }

    public string GetName() {
        return name;
    }

    public int GetPoints() {
        return points;
    }
}
