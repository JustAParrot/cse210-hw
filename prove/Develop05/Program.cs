using System;

class Program {
    static void Main(string[] args) {
        GoalManager manager = new GoalManager();
        manager.Start();

        DisplayMainMenu(manager);
    }

    // Added a user friendly game-like menu and the delete option for exceeding requirements

    static void DisplayMainMenu(GoalManager manager) {
        while (true) {
            Console.WriteLine("=== Goal Management Menu ===");
            Console.WriteLine("1. List Goals");
            Console.WriteLine("2. Create New Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Display Player Info");
            Console.WriteLine("5. View Completed Goals");
            Console.WriteLine("6. Delete Goal");
            Console.WriteLine("7. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    manager.ListGoalDetails();
                    break;
                case "2":
                    CreateNewGoal(manager);
                    break;
                case "3":
                    RecordEvent(manager);
                    break;
                case "4":
                    manager.DisplayPlayerInfo();
                    break;
                case "5":
                    manager.ListCompletedGoals();
                    break;
                case "6":
                    DeleteGoal(manager);
                    break;
                case "7":
                    Console.WriteLine("Thank you for using the Goal Management System. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateNewGoal(GoalManager manager) {
        Console.WriteLine("Enter goal type (simple, eternal, checklist): ");
        string goalType = Console.ReadLine();

        Console.WriteLine("Enter goal name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal description: ");
        string description = Console.ReadLine();

        Console.WriteLine("Enter points for completing the goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType.ToLower()) {
            case "checklist":
                Console.WriteLine("Enter target for the checklist goal: ");
                int target = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter bonus points for completing the checklist goal: ");
                int bonus = int.Parse(Console.ReadLine());

                manager.CreateGoal(goalType, name, description, points, target, bonus);
                break;
            default:
                manager.CreateGoal(goalType, name, description, points);
                break;
        }
    }

    static void RecordEvent(GoalManager manager) {
        Console.WriteLine("Enter the name of the goal for which you want to record an event: ");
        string goalName = Console.ReadLine();
        manager.RecordEvent(goalName);
    }

    static void DeleteGoal(GoalManager manager) {
        Console.WriteLine("Enter the name of the goal you want to delete: ");
        string goalName = Console.ReadLine();
        manager.DeleteGoal(goalName);
    }
}
