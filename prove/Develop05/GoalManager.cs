using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

public class GoalManager {
    private List<Goal> goals;
    private int score;

    public GoalManager() {
        goals = new List<Goal>();
        score = 0;
    }

    public void Start() {
        LoadGoals();
    }

    public void DisplayPlayerInfo() {
        Console.WriteLine($"Current Score: {score}");
    }

    public void ListGoalDetails() {
        foreach (var goal in goals) {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListCompletedGoals() {
        var completedGoals = goals.Where(g => g.IsComplete()).ToList();
        if (completedGoals.Any()) {
            Console.WriteLine("=== Completed Goals ===");
            foreach (var goal in completedGoals) {
                Console.WriteLine(goal.GetDetailsString());
            }
        } else {
            Console.WriteLine("No goals have been completed yet.");
        }
    }

    public void CreateGoal(string goalType, string name, string description, int points, params object[] additionalArgs) {
        Goal goal;
        switch (goalType.ToLower()) {
            case "simple":
                goal = new SimpleGoal(name, description, points);
                break;
            case "eternal":
                goal = new EternalGoal(name, description, points);
                break;
            case "checklist":
                if (additionalArgs.Length < 2) {
                    Console.WriteLine("Additional arguments (target and bonus) are required for checklist goals.");
                    return;
                }
                int target = (int)additionalArgs[0];
                int bonus = (int)additionalArgs[1];
                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type!");
                return;
        }
        goals.Add(goal);
    }

    public void RecordEvent(string goalName) {
        var goal = goals.FirstOrDefault(g => g.GetName() == goalName);
        if (goal != null) {
            goal.RecordEvent();
            score += goal.GetPoints();
            SaveGoals();
        } else {
            Console.WriteLine("Goal not found!");
        }
    }

    public void DeleteGoal(string goalName) {
        var goal = goals.FirstOrDefault(g => g.GetName() == goalName);
        if (goal != null) {
            goals.Remove(goal);
            Console.WriteLine($"Goal '{goalName}' has been deleted.");
            SaveGoals();
        } else {
            Console.WriteLine("Goal not found!");
        }
    }

    public void SaveGoals() {
        var data = new {
            Goals = goals,
            Score = score
        };
        string jsonData = JsonSerializer.Serialize(data);
        File.WriteAllText("goals.json", jsonData);
    }

    public void LoadGoals() {
        if (File.Exists("goals.json")) {
            string jsonData = File.ReadAllText("goals.json");
            var data = JsonSerializer.Deserialize<dynamic>(jsonData);
            goals = data["Goals"];
            score = data["Score"];
        } else {
            Console.WriteLine("No saved goals found.");
        }
    }
}
