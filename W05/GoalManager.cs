using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> goals;
    private int score;

    public GoalManager()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in goals)
        {
            if (goal.Name == goalName)
            {
                goal.RecordEvent();
                score += goal.Points;
                if (goal is ChecklistGoal checklistGoal && checklistGoal.IsCompleted)
                {
                    score += checklistGoal.BonusPoints;
                }
                break;
            }
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetProgress());
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine("Current Score: " + score);
    }

    public void SaveGoals(string filePath)
    {
        //in work
    }

    public void LoadGoals(string filePath)
    {
        //in work
    }
}
