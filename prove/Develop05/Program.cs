using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalPoints = 0;
        int choice;

        while ((choice = DisplayMenu()) != 6)
        {
            switch (choice)
            {
                case 1:
                    goals.Add(CreateNewGoal());
                    break;
                case 2:
                    ListGoals(goals);
                    break;
                case 3:
                    SaveGoals(goals);
                    break;
                case 4:
                    goals = LoadGoals();
                    break;
                case 5:
                    totalPoints += RecordEvent(goals);
                    System.Console.WriteLine($"You now have {totalPoints} points.");
                    break;
                default:
                    System.Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static int DisplayMenu()
    {
        System.Console.WriteLine("\nEternal Question Menu: ");
        System.Console.WriteLine("1. Create New Goal");
        System.Console.WriteLine("2. List Goals");
        System.Console.WriteLine("3. Save Goals");
        System.Console.WriteLine("4. Load Goals");
        System.Console.WriteLine("5. Record Event");
        System.Console.WriteLine("6. Quit");

        System.Console.WriteLine("\nEnter your choice: ");
        int.TryParse(Console.ReadLine(), out int choice);
        return choice;
    }

    static Goal CreateNewGoal()
    {
        System.Console.WriteLine("\nChoose the type of goal:");
        System.Console.WriteLine("1. Simple Goal");
        System.Console.WriteLine("2. Eternal Goal");
        System.Console.WriteLine("3. Checklist Goal");

        System.Console.WriteLine("Enter your choice: ");
        int.TryParse(Console.ReadLine(), out int choice);
        
        System.Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();

        System.Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();

        System.Console.WriteLine("What is the amount of points associated with this goal? ");
        int.TryParse(Console.ReadLine(), out int points);

        switch (choice)
        {
            case 1:
                return new SimpleGoal(name, description, points);
            
            case 2:
                return new EternalGoal(name, description, points);
            case 3:
                System.Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                int.TryParse(Console.ReadLine(), out int goalCount);

                System.Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                int.TryParse(Console.ReadLine(), out int bonus);

                return new ChecklistGoal(name, description, points, goalCount, bonus);
            default:
                System.Console.WriteLine("Invalid option. Creating a Simple Goal by default.");
                return new SimpleGoal(name, description, points);
        }
    }

    static void ListGoals(List<Goal> goals)
    {
        System.Console.WriteLine("\nList of Goals: ");
        foreach (Goal goal in goals)
        {
            System.Console.WriteLine(goal);
        }
    }

    static void SaveGoals(List<Goal> goals)
    {
        System.Console.WriteLine("Enter the filename of the goal file: ");
        string filename = Console.ReadLine();

        using StreamWriter writer = new StreamWriter(filename);
        foreach (Goal goal in goals)
        {
            writer.WriteLine(goal.GetType().Name);
            writer.WriteLine(goal._name);
            writer.WriteLine(goal._description);
            writer.WriteLine(goal._points);
            if (goal is ChecklistGoal checklistGoal)
            {
                writer.WriteLine(checklistGoal._goalCount);
                writer.WriteLine(checklistGoal._bonus);
            }
        }
    }

    static List<Goal> LoadGoals()
    {
        System.Console.WriteLine("Enter the filename of the goal file: ");
        string filename = Console.ReadLine();

        List<Goal> goals = new List<Goal>();
        using StreamReader reader = new StreamReader(filename);

        string line;
        while ((line = reader.ReadLine()) != null)
        {
            string name = reader.ReadLine();
            string description = reader.ReadLine();
            int.TryParse(reader.ReadLine(), out int points);

            switch (line)
            {
                case nameof(SimpleGoal):
                    goals.Add(new SimpleGoal(name, description, points));
                    break;
                case nameof(EternalGoal):
                    goals.Add(new EternalGoal(name, description, points));
                    break;
                case nameof(ChecklistGoal):
                    int.TryParse(reader.ReadLine(), out int goalCount);
                    int.TryParse(reader.ReadLine(), out int bonus);
                    goals.Add(new ChecklistGoal(name, description, points, goalCount, bonus));
                    break;
            }
        }
        return goals;
    }

    static int RecordEvent(List<Goal> goals)
    {
        System.Console.WriteLine("\nChoose the goal you want to record an event for: ");
        for (int i = 0; i < goals.Count; i++)
        {
            System.Console.WriteLine($"{i + 1}. {goals[i]}");
        }

        System.Console.WriteLine("Enter your choice: ");
        int.TryParse(Console.ReadLine(), out int choice);

        if (choice > 0 && choice <= goals.Count)
        {
            Goal selectedGoal = goals[choice - 1];
            selectedGoal.RecordEvent();
            System.Console.WriteLine($"Event recorded for goal: {selectedGoal._name}");
            return selectedGoal._completed ? selectedGoal._points : 0;
        }
        else
        {
            System.Console.WriteLine("Invalid option. No event recorded.");
            return 0;
        }
    }
}