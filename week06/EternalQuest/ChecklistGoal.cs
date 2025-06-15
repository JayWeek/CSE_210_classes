public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // constructor
    public ChecklistGoal(string name, string description, int points, int bonusPoints, int target) : base(name, description, points)
    {
        _bonus = bonusPoints;
        _target = target;
        _amountCompleted = 0;
    }


    // metrhods

    // Setters
    private void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
    public override void recordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
            _lastEarnedPoints = GetPoint();

            if (IsComplete())
            {
                _lastEarnedPoints += _bonus;
                Console.WriteLine($"Congrats! You completed the checklist. You have earned {_lastEarnedPoints} points!");
            }
            else
            {
                Console.WriteLine($"Congrats! You have earned {_lastEarnedPoints} points!");
            }
        }
        else
        {
            _lastEarnedPoints = 0;
            Console.WriteLine("You have already completed this goal!");
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        return false;
    }

    public override string GetDetailsString()
    {
        string _shortName = GetName();
        String _description = GetDescription();
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        return $"[] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    // Serialization 
    public override string GetStringRepresentation()
    {
        int points = GetPoint();
        string _shortName = GetName();
        String _description = GetDescription();
        return $"ChecklistGoal:{_shortName} | {_description} | {points} | {_bonus} | {_target} | {_amountCompleted}";
    }

    // deserialization 
    public static ChecklistGoal Deserialize(string line)
    {
        if (!line.StartsWith("ChecklistGoal:")) return null;
        string[] parts = line.Substring(14).Trim().Split('|');
        if (parts.Length != 6) return null;
        string name = parts[0].Trim();
        string description = parts[1].Trim();
        if (!int.TryParse(parts[2].Trim(), out int points)) return null;
        if (!int.TryParse(parts[3].Trim(), out int bonus)) return null;
        if (!int.TryParse(parts[4].Trim(), out int target)) return null;
        int amountCompleted;

        if (!int.TryParse(parts[5].Trim(), out amountCompleted))
        {
            amountCompleted = 0;
        }

        ChecklistGoal checklistGoal1 = new ChecklistGoal(name, description, points, bonus, target);
        checklistGoal1.SetAmountCompleted(amountCompleted);
        return checklistGoal1;
    }
}