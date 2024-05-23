using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;
    static readonly string filePath = "goals.json";

    static void Main(string[] args)
    {
        // Example usage
        // Add some sample goals
        AddSampleGoals();

        // Main loop
        while (true)
        {
            Console.Clear();
            DisplayGoals();
            Console.WriteLine($"\nCurrent Score: {score}");
            Console.WriteLine("\n1. Record Event");
            Console.WriteLine("2. Add New Goal");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RecordEvent();
                    break;
                case "2":
                    AddNewGoal();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in goals)
        {
            goal.DisplayGoal();
        }
    }

    static void AddSampleGoals()
    {
        goals.Add(new SimpleGoal("Run a marathon", 1000));
        goals.Add(new EternalGoal("Read scriptures", 100));
        goals.Add(new ChecklistGoal("Attend the temple", 50, 10, 500));
    }

    static void RecordEvent()
    {
        Console.Write("Enter the goal number to record an event: ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex >= 0 && goalIndex < goals.Count)
        {
            score += goals[goalIndex].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    static void AddNewGoal()
    {
        Console.WriteLine("Choose goal type: 1. Simple 2. Eternal 3. Checklist");
        var goalType = Console.ReadLine();
        Console.Write("Enter goal name: ");
        var name = Console.ReadLine();
        Console.Write("Enter points: ");
        var points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                goals.Add(new SimpleGoal(name, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                var targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                var bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void SaveGoals()
    {
        var options = new JsonSerializerOptions { WriteIndented = true, Converters = { new GoalConverter() } };
        var json = JsonSerializer.Serialize(goals, options);
        File.WriteAllText(filePath, json);
        File.WriteAllText("score.json", score.ToString());
    }

    static void LoadGoals()
    {
        if (File.Exists(filePath))
        {
            var options = new JsonSerializerOptions { Converters = { new GoalConverter() } };
            var json = File.ReadAllText(filePath);
            goals = JsonSerializer.Deserialize<List<Goal>>(json, options);
            score = int.Parse(File.ReadAllText("score.json"));
        }
    }
}
