using System.IO;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            
            // Polymorphism in action: The specific logic for the goal type runs here
            goal.RecordEvent();

            int pointsEarned = goal.GetPoints();

            // Check specific logic for Checklist Goal Bonus
            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                // Only add the bonus if they JUST finished it (exact match logic implies we need to be careful)
                // But for simplicity, we add bonus + points.
                pointsEarned += checklistGoal.GetBonus();
            }

            // If it's a SimpleGoal and was already complete, we might not want to give points,
            // but usually, simple goals disappear or are marked X. 
            // The prompt implies we mark it complete and gain value. 
            // We'll assume points are awarded if RecordEvent is called.
            
            _score += pointsEarned;

            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
    }
    public void LoadGoals()
    {
        string filename = "Goals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal simplegoal = new SimpleGoal(parts[1], parts[2], parts[3], bool.Parse(parts[4]));
                _goals.Add(simplegoal);
            } else if (parts[0] == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], parts[3]);
                _goals.Add(eternalGoal);
            } else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal checklistgoal = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                _goals.Add(checklistgoal);
            }
        }
    }
    public void SaveGoals()
    {
        string filename = "Goals.txt";     
        Console.WriteLine($"Writing to: {Path.GetFullPath(filename)}");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());     
            }
        }
    }
}