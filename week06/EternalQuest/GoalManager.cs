public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create New Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Remove a Goal");
            Console.WriteLine("9. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    CreateGoal();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.Write("Enter file name to save to: ");
                    SaveGoals(Console.ReadLine());
                    break;
                case "7":
                    Console.Write("Enter file name to load from: ");
                    LoadGoals(Console.ReadLine());
                    break;
                case "8":
                    RemoveGoal();
                    break;
                case "9":
                    return;
                    
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }



    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filePath)
    {
        _goals = new List<Goal>();
        if (!File.Exists(filePath)) return;

        string[] lines = File.ReadAllLines(filePath);
        if (lines.Length == 0) return;

        if (!int.TryParse(lines[0], out _score))
        {
            _score = 0; // fallback if score line is missing or invalid
        }
        for (int i = 1; i < lines.Length; i++)
        {
            Goal goal = Goal.DeserializeGoal(lines[i]);
            if (goal != null)
            {
                _goals.Add(goal);
            }
        }
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
        Console.WriteLine("Goal Details:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }

        Console.WriteLine("Which goal did you accomplish?");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Enter goal number: ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) &&
            goalIndex > 0 && goalIndex <= _goals.Count)
        {
            Goal goal = _goals[goalIndex - 1];
            goal.recordEvent(); // handle goal logic
            _score += goal.GetLastEarnedPoints(); // only add what was actually earned
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }


    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (choice)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter bonus points for completing checklist: ");
                int bonus = int.Parse(Console.ReadLine());

                Console.Write("Enter number of times to complete checklist: ");
                int target = int.Parse(Console.ReadLine());

                newGoal = new ChecklistGoal(name, description, points, bonus, target);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal added!");
    }
    public void RemoveGoal()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to remove.");
            return;
        }

        Console.WriteLine("Select a goal to remove:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Enter goal number to remove: ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) &&
            goalIndex > 0 && goalIndex <= _goals.Count)
        {
            Console.WriteLine($"Removed goal: {_goals[goalIndex - 1].GetName()}");
            _goals.RemoveAt(goalIndex - 1);
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

}
