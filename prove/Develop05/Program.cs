using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        Boolean running = true;
        while (running)
        {
            Console.WriteLine("\n--- Eternal Quest Menu ---");
            manager.DisplayPlayerInfo();
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.CreateGoal();
                    break;
                case "2":
                    Console.WriteLine();
                    manager.ListGoalDetails();
                    break;
                case "3":
                    manager.SaveGoals();
                    break;
                case "4":
                    manager.LoadGoals();
                    break;
                case "5":
                    manager.RecordEvent();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }
    }
}

/* So I added the save and load function which seems to be a part of the above and beyond thing so thats my exceeding requirments */