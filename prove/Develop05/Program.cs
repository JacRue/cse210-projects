using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace EternalQuest
{
    class Program
    {
        static List<Goal> goals = new List<Goal>();
        static string filename = "goals.json";
        static void Main(string[] args)
        {
            LoadGoals();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Eternal Quest");
                Console.WriteLine("-------------");
                Console.WriteLine($"Total score: {goals.Sum(g => g.PointValue)}\n");

                Console.WriteLine("Goals:");
                foreach (var goal in goals)
                {
                    Console.WriteLine($"{goal.GetStatus()} {goal.Name} ({goal.PointValue} points)");
                }
                Console.WriteLine();

                Console.WriteLine("1. Create new goal");
                Console.WriteLine("2. Record an event");
                Console.WriteLine("3. Exit");
                Console.Write("\nEnter a choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        CreateGoal();
                        break;
                    case 2:
                        RecordEvent();
                        break;
                    case 3:
                        SaveGoals();
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static void CreateGoal()
        {
            Console.Clear();
            Console.WriteLine("Create new goal");
            Console.WriteLine("---------------");
            Console.WriteLine("1. Simple goal");
            Console.WriteLine("2. Eternal goal");
            Console.WriteLine("3. Checklist goal");
            Console.Write("\nEnter a choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                return;
            }

            Goal goal;
            switch (choice)
            {
                case 1:
                    goal = new SimpleGoal();
                    break;
                case 2:
                    goal = new EternalGoal();
                    break;
                case 3:
                    goal = new ChecklistGoal();
                    break;
                default:
                    return;
            }

            Console.Write("Enter goal name: ");
            goal.Name = Console.ReadLine();

            Console.Write("Enter point value: ");
            if (!int.TryParse(Console.ReadLine(), out int PointValue))
            {
                return;
            }
            goal.PointValue = PointValue;

            if (goal is ChecklistGoal)
            {
                Console.Write("Enter required value: ");
                if (!int.TryParse(Console.ReadLine(), out int requiredValue))
                {
                    return;
                }
                ((ChecklistGoal)goal).RequiredValue = requiredValue;
                Console.Write("Enter bonus value: ");
                if (!int.TryParse(Console.ReadLine(), out int bounusValue))
                {
                    return;
                }
                ((ChecklistGoal)goal).BonusValue = bounusValue;
            }

            goals.Add(goal);
        }

        static void RecordEvent()
        {
            Console.Clear();
            Console.WriteLine("Record an event");
            Console.WriteLine("---------------");
            Console.WriteLine("Select a goal:");

            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].Name}");
            }

            Console.Write("\nEnter a choice: ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                return;
            }

            if (choice < 1 || choice > goals.Count)
            {
                return;
            }

            Goal goal = goals[choice - 1];
            goal.RecordEvent();
            Console.WriteLine($"\nEvent recorded for {goal.Name}. You earned {goal.PointValue} points");
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }

        static void LoadGoals()
        {
            if (File.Exists(filename))
            {

                string json = File.ReadAllText(filename);
                goals = JsonSerializer.Deserialize<List<Goal>>(json);

            }
        }

        static void SaveGoals()
        {
            string json = JsonSerializer.Serialize(goals);
            using (StreamWriter streamWriter = new StreamWriter(filename))
            {
                streamWriter.Write(json);
            }
        }
    }
}