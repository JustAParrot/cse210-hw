using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        goalManager.AddGoal(new SimpleGoal("Run a marathon", 1000));
        goalManager.AddGoal(new EternalGoal("Read scriptures", 100));
        goalManager.AddGoal(new ChecklistGoal("Attend the temple", 50, 10, 500));

        goalManager.RecordEvent("Read scriptures");
        goalManager.RecordEvent("Attend the temple");

        goalManager.DisplayGoals();
        goalManager.DisplayScore();

        // Save and load goals as needed
        goalManager.SaveGoals("goals.txt");
        goalManager.LoadGoals("goals.txt");
    }
}
